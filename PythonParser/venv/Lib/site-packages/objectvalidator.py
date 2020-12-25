"""
Module :mod:`objectvalidator` provides functionality for validating and
caching values returned from methods.

    ::

        import os

        from objectvalidator import option, OptionsContainer

        SETTINGS = {
            'NAME': 'ExampleApp',
            'DATABASE': {
                'db': 'exampleapp_db',
                'host': 'localhost',
                'port': 3306,
                'user': 'exampleapp-rw',
                'password': 'a8RnU43A',
            },
        }


        class Config(OptionsContainer):

            def initialize(self, settings):
                self._settings = settings

            @option(required=True, attrtype=str)
            def name(self):
                return self._settings['NAME']

            @option
            def database(self):
                return DatabaseConfig(self._settings['DATABASE'])


        class DatabaseConfig(OptionsContainer):

            def initialize(self, database_settings):
                self._database_settings = database_settings

            @option(required=True, attrtype=str)
            def db(self):
                db = os.environ.get('DATABASE_DB')
                if db is not None:
                    return db
                return self._database_settings['db']

            @option(required=True, attrtype=str)
            def host(self):
                host = os.environ.get('DATABASE_HOST')
                if host is not None:
                    return host
                return self._database_settings['host']

            @option(required=True, attrtype=int)
            def port(self):
                port = os.environ.get('DATABASE_PORT')
                if port is not None:
                    return int(port)
                return self._database_settings.get('port', 3306)

            @option(required=True, attrtype=str)
            def user(self):
                user = os.environ.get('DATABASE_USER')
                if user is not None:
                    return user
                return self._database_settings['user']

            @option(required=True, attrtype=str)
            def password(self):
                password = os.environ.get('DATABASE_PASSWORD')
                if password is not None:
                    return password
                return self._database_settings['password']


        >>> config = Config(SETTINGS)
        >>> config.name
        'ExampleApp'
        >>> config.database
        <DatabaseConfig: db='exampleapp_db', host='localhost', ...>
        >>> config.database.db
        'exampleapp_db'
"""

import functools
import inspect

__all__ = ['option', 'OptionsContainer']

__version__ = '1.1.0'


class option(object):
    """
    Decorator which validates and caches values returned from methods. Can
    be used either with arguments or without. If arguments are ommited,
    value is not validated, only cached. Allowed arguments are **required**
    and **attrtype**. If **required** is :data:`True`, value returned from
    method mustn't be :data:`None`. **attrtype** is a type which is allowed
    for value. Can be either single type or :class:`tuple` containig types.

    .. code-block:: python

        @option
        def foo(self):
            return ...

        @option(required=True, attrtype=int)
        def bar(self):
            return ...

        @option(required=True, attrtype=(int, float))
        def baz(self):
            return ...
    """

    def __new__(cls, func=None, required=False, attrtype=None):
        if func is not None:
            # Decorated without any arguments: @option
            return cls._create_instance(func, required, attrtype)
        else:
            # Decorated with arguments: @option(required=True, ...)
            def decorator(func):
                return cls._create_instance(func, required, attrtype)
            return decorator

    @classmethod
    def _create_instance(cls, func, required, attrtype):
        inst = object.__new__(cls)
        inst.func = func
        inst.required = required
        inst.attrtype = attrtype
        functools.update_wrapper(inst, func)
        return inst

    @classmethod
    def get_option_names(cls, inst):
        """
        Return :class:`list` containig method's names on *inst* instance which
        are decorated by :class:`option` decorator.
        """
        res = []
        for attrname, attrvalue in inspect.getmembers(inst.__class__):
            if isinstance(attrvalue, cls):
                res.append(attrname)
        return res

    @classmethod
    def load_all_options(cls, inst):
        """
        Try reading values from all methods on *inst* instance which
        are decorated by :class:`option` decorator. Reading will cause
        validation of theese values and cache them.
        """
        for attrname in cls.get_option_names(inst):
            getattr(inst, attrname)

    def __repr__(self):
        return "<{}: {}>".format(self.__class__.__name__, self.__qualname__)

    def __get__(self, inst, unused_objtype):
        if inst is None:
            return self
        else:
            if self.func.__name__ not in inst.__dict__:
                try:
                    value = self.func(inst)
                    self._validate(value)
                except Exception as exc:
                    raise ValueError("{}: {}".format(self.__qualname__, exc))
                inst.__dict__[self.__name__] = value
            return inst.__dict__[self.__name__]

    def __set__(self, inst, value):
        raise TypeError('Object does not support item assignment')

    def _validate(self, value):
        if value is None:
            if self.required:
                raise ValueError("Option value is required")
        else:
            if self.attrtype:
                if isinstance(value, type):
                    validator = issubclass
                else:
                    validator = isinstance
                if not validator(value, self.attrtype):
                    raise ValueError(
                        "{} type is expected".format(self.attrtype.__name__))


class OptionsContainer(object):
    """
    Container for options methods. During initialization values from all
    methods decorated by :class:`option` decorator are read. So if class
    is successfuly initialized, all options are validated a cached.
    """

    def __init__(self, *args, **kwargs):
        self.initialize(*args, **kwargs)
        option.load_all_options(self)

    def __repr__(self):
        options = (
            (name, getattr(self, name))
            for name in option.get_option_names(self)
        )
        return "<{}: {}>".format(
            self.__class__.__name__,
            ", ".join("{}={!r}".format(k, v) for k, v in options),
        )

    def initialize(self, *args, **kwargs):
        """
        Initialize instance attributes. You can override this method in
        the subclasses.
        """
        pass
