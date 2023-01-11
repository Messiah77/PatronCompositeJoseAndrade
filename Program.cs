
//PatronComposite

// Interfaz para los elementos de la estructura
interface IComponent
{
    void Print();
}

// Clase para las hojas
class Leaf : IComponent
{
    private string _name;
    public Leaf(string name)
    {
        _name = name;
    }

    public void Print()
    {
        Console.WriteLine("Leaf " + _name);
    }
}

// Clase para los nodos
class Composite : IComponent
{
    private List<IComponent> _children = new List<IComponent>();
    private string _name;

    public Composite(string name)
    {
        _name = name;
    }
    public void Add(IComponent component)
    {
        _children.Add(component);
    }

    public void Remove(IComponent component)
    {
        _children.Remove(component);
    }

    public void Print()
    {
        Console.WriteLine("Composite " + _name);
        foreach (var component in _children)
        {
            component.Print();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creando una hoja
        Leaf leaf1 = new Leaf("1");
        Leaf leaf2 = new Leaf("2");
        Leaf leaf3 = new Leaf("3");

        // Creando un nodo compuesto y agregando hojas como hijos
        Composite composite = new Composite("Node");
        composite.Add(leaf1);
        composite.Add(leaf2);

        // Creando otro nodo compuesto y agregando hojas y el nodo anterior como hijos
        Composite composite2 = new Composite("Node2");
        composite2.Add(leaf3);
        composite2.Add(composite);

        // Imprimir toda la estructura
        composite2.Print();

        Console.ReadKey();
    }
}
