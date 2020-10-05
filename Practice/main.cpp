#include <iostream> 
#include <list>
using namespace std; 
  
class Graph { 
public: 
    Graph(int V) { 
        this->V = V; 
        adj = new list<int>[V]; 
    } 
  
    void addEdge(int v, int w) { 
        adj[v].push_back(w);
    } 
  
    void DFS(int v) { 
        bool *visited = new bool[V]; 

        for (int i = 0; i < V; i++) 
            visited[i] = false; 
   
        DFSUtil(v, visited); 
    } 

    void print() {
        for (size_t i = 0; i < V; i++) {
            for (auto x : adj[i]) {
              cout<< x << ' ';
            }
            cout << endl;
        }
    }

private:
    int V;
    list<int> *adj; 
  
    void DFSUtil(int v, bool visited[])  { 
        list<int>::iterator i; 
        visited[v] = true; 
        cout << v+1 << " "; 

        for (i = adj[v].begin(); i != adj[v].end(); ++i) 
            if (!visited[*i]) 
                DFSUtil(*i, visited); 
        
        
        
    }  
}; 

int main() { 
    Graph g(14); 

    g.addEdge(0, 1); 
    g.addEdge(0, 2); 
    g.addEdge(1, 3); 
    g.addEdge(1, 4); 
    g.addEdge(2, 5); 
    g.addEdge(2, 6);
    g.addEdge(5, 7);
    g.addEdge(5, 8);
    g.addEdge(5, 9);
    g.addEdge(9, 12);
    g.addEdge(9, 13);
    g.addEdge(6, 10);
    g.addEdge(6, 11);

    // g.print();

    g.DFS(0); 
  
    return 0; 
} 