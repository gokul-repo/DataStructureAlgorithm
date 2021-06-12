namespace DataStructureAlgorithm.Hashing
{
    public class HashTableLinearProbing
    {
        public int[] HTable;
        public int Size ;

        public HashTableLinearProbing(int size){
            Size = size;
            HTable = new int[size];
        }

        public int HashFunction(int value){
            return value % Size;
        }

        public int Probe(int key){
            int i =0;
            while(HTable[(key+i)%Size]!=0){
                i++;
            }
            return key+i;
        }
        public void Insert(int value){
            int key = HashFunction(value);
            if(HTable[key]==0){
                HTable[key]=value;
                return;
            }
            key = Probe(key);
            HTable[key]=value;
            return;
        }

        public bool Search(int value){
            int key = HashFunction(value);
            if(HTable[key]== value){
                return true;
            }
            int i=0;
            while(HTable[(key+i)%Size] != value){
                if (HTable[(key+i)%Size] ==0){
                    return false;
                }
                i++;
            }
            return true;
        }


    }
}