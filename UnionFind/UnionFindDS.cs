namespace DataStructureAlgorithm.UnionFind
{
    public class UnionFindDS
    {
        public int size;
        public int[] sz;
        public int[] id;

        public int numOfComponents;

        public UnionFindDS(int n){
            size=n;
            sz=new int[size];
            id=new int[size];
            numOfComponents=size;
            for (int i=0;i<size;i++){
                sz[i]=1;
                id[i]=i;
            }
        }

        public int Find(int p){
            int root=p;
            while(id[root] != root){
                root=id[root];
            }
            //Path Compression
            while(root!=p){
                int next = id[p];
                id[p]=root;
                p=next;
            }
            return root;
        }

        public bool IsConnected(int p, int q){
            return Find(p)==Find(q);
        }
        
        public int ComponentSize(int p){
            return sz[Find(p)];
        }

        public int Size(){
            return size;
        }

        public void Union(int p, int q){
            if (IsConnected(p,q)){
                return;
            }
            int root1=Find(p);
            int root2=Find(q);
            if(sz[root1]<sz[root2]){
                sz[root2]=sz[root2]+sz[root1];
                id[root1]=root2;
            }else{
                sz[root1]=sz[root1]+sz[root2];
                id[root2]=root1;
            }
            numOfComponents--;
        }
    }
}