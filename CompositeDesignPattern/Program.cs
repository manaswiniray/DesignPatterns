namespace CompositeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var leaf1 = new EmployeeLeafNode("Leaf 1.1");
            var leaf2 = new EmployeeLeafNode("Leaf 1.2");
            var leaf3 = new EmployeeLeafNode("Leaf 1.3");
            var leaf4 = new EmployeeLeafNode("Leaf 2.1");
            var leaf5 = new EmployeeLeafNode("Leaf 2.2");
            var leaf6 = new EmployeeLeafNode("Leaf 2.3");
            var leaf7 = new EmployeeLeafNode("Leaf 3.1");
            var leaf8 = new EmployeeLeafNode("Leaf 3.2");
            var leaf9 = new EmployeeLeafNode("Leaf 3.3");
            var leaf10 = new EmployeeLeafNode("Leaf 3.4");

            var parent1 = new EmployeeParentNode("Parent 1");
            var parent2 = new EmployeeParentNode("Parent 2");
            var parent3 = new EmployeeParentNode("Parent 3");

            parent1.Add(parent2);
            parent2.Add(parent3);

            parent1.Add(leaf1);
            parent1.Add(leaf2);
            parent1.Add(leaf3);

            parent2.Add(leaf4);
            parent2.Add(leaf5);
            parent2.Add(leaf6);

            parent3.Add(leaf7);
            parent3.Add(leaf8);
            parent3.Add(leaf9);
            parent3.Add(leaf10);

            Console.WriteLine(parent1.GetName());
            foreach(var child in parent1.GetEmployeesList())
            {
                PrintEmployeeList(child);
            }
        }

        static void PrintEmployeeList(IEmployeeNode employeeNode)
        {
            Console.WriteLine(employeeNode.GetName());
            if (employeeNode.GetEmployeesList() != null)
            {
                foreach(var child in employeeNode.GetEmployeesList())
                {
                    Console.WriteLine(child.GetName());
                }
            }
            
        }

        

    }


}