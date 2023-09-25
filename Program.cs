class Program {
    static void Main() {
        Circle circle = new Circle();
        circle.CualEsMiRadio();
        circle.CalculaTuPerimetro();
        circle.CalculaTuArea();
    }
}

class Circle {
    float radio_size;
     public void CualEsMiRadio() {
        Console.WriteLine("Escribe el radio del circulo");
        radio_size = int.Parse(Console.ReadLine());
     }


     public void CalculaTuPerimetro() {
        Console.WriteLine("\nMi perimetro es " + 2 * Math.PI * radio_size);
     }

     public void CalculaTuArea() {
        Console.WriteLine("Mi area es " + Math.PI * Math.Pow(radio_size, 2));
     }
}