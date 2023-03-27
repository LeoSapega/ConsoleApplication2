using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            int n = 1;
            while (n != 0)
            {
                Console.WriteLine("введите значение");

                tree.Add(Int32.Parse(Console.ReadLine()));
                n = Int32.Parse(Console.ReadLine());
            }
            tree.WrightTree(tree.root);
            Console.ReadKey();
        }
    }
    public class BinaryTree //создание дерева
    {
        public class BinaryNode //узел дерева
        {
            public BinaryNode left { get; set; } //указатели узла
            public BinaryNode right { get; set; }
            public int value; //вставляемое значение

            public BinaryNode(int val)
            {
                value = val; //конструктор заполняет узел значением
                left = null;
                right = null;
            }
        }

        public BinaryNode root; //корень дерева
        public BinaryTree() //конструктор (по умолчанию) создания дерева
        {
            root = null; //при создании корень не определен
        }

        public BinaryTree(int value)
        {
            root = new BinaryNode(value); //если изначально задаём корневое значение
        }
        public void Add(int value) //узел и его значение
        {
            if (root == null)
            {
                root = new BinaryNode(value);
                return;
            }
            BinaryNode current = root; //текущий равен корневому
                bool added = false;
                //обходим дерево
                do
                {
                    if (value >= current.value)  //идём вправо
                    {
                        if (current.right == null)
                        {
                            current.right = new BinaryNode(value);
                            return;

                        }
                        else
                        {
                            current = current.right;
                        }

                    }
                    else if (value<current.value) //идём влево
                    {
                        if(current.left == null)
                        {
                            current.left = new BinaryNode(value);
                            added = true;
                        }
                        else
                        {
                            current = current.left;
                        }
                    }
                    else
                    {
                        current = current.left;
                    }
                }
                while (!added);
            }
        public void WrightTree(BinaryNode root)
        {
            Console.WriteLine(root.value.ToString());
            if (root.left != null) WrightTree(root.left);
            if (root.right != null) WrightTree(root.right);
        }
    }
    
}
