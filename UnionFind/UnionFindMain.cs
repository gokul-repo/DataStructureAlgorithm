namespace DataStructureAlgorithm.UnionFind
{
    public class UnionFindMain
    {
         static void UF_Main(string[] args)
        {
            UnionFindDS uf = new UnionFindDS(9);
            uf.Union(1,2);
            uf.Union(3,4);
            uf.Union(5,6);
            uf.Union(7,8);
            uf.Union(2,4);
            uf.Union(2,5);
            uf.Union(1,3);
            uf.Union(6,8);
            uf.Union(5,7);


        }
    }
}