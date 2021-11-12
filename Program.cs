using System;
using System.Collections;




namespace Nodos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Nodo Lista Simple");
            Lista lista= new Lista();
            Console.Write("Ingrese longitud de la lista: \n" );
            int longitud = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cantidad de nodos Actual: "+ lista.cantidadNodos);
            
            for(int i=0; i<longitud;i++){
                Console.WriteLine("Ingrese # para la lista simple: \n" );
                int dato = Convert.ToInt32(Console.ReadLine());
                
                lista.Insertar(dato);
                
                
                Console.WriteLine("Cantidad de nodos Actual: "+ lista.cantidadNodos);
            }
            PrintValues(lista.nodeList);
            
            
            
        }
        public static void PrintValues(IEnumerable myList){
              foreach ( Node obj in myList ){
                 Console.Write( "   {0}", obj.dato);
                 
              }
              Console.WriteLine();             
          
        }
    }
   
    public class Lista{
        public Node primero;
        public Node ultimo;
        public int  cantidadNodos=0;
       public  ArrayList nodeList = new ArrayList();
        public Lista(){
            this.primero = null;
            this.ultimo=null;
        }
        public Boolean vacio(){
            Node node = this.primero;
            return node ==null;
        }
        public void Insertar(int dato){
            Node newNodo = new Node(dato);
            if(vacio()){
                this.primero = newNodo;
                this.ultimo =newNodo;
                Console.WriteLine("El primer Nodo es: " + this.primero.dato +" El ultimo Nodo es: "+ this.ultimo.dato);
                nodeList.Add(this.ultimo);
            }else{
               this.ultimo = this.primero;
                while(this.ultimo.sig != null){
                    this.ultimo = ultimo.sig;
                }
                this.ultimo.sig =newNodo;
                Console.WriteLine("El primer Nodo es: " + this.primero.dato +" El ultimo Nodo es: "+ this.ultimo.sig.dato);
                nodeList.Add(this.ultimo.sig);
            }
            this.cantidadNodos++;

        }

    }
    
}
