namespace Nodos
{
    public class Node
    {
        public Node sig;
        public int dato;

        public Node(int dato){
            this.dato =dato;
            this.sig = null;
        }
    }
}