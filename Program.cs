namespace RetanguloEstruturado;

class Program
{
    static void Main(string[] args)
    {
       double largura, altura, area, perimetro, diagonal;
        Console.WriteLine("Vamos calcular as propriedades do triangulo!");
        Console.WriteLine("Informe a Largura: ");
        largura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a Altura: ");
        altura = Convert.ToDouble(Console.ReadLine());
        area = largura*altura;
        perimetro = 2*(largura)+2*(altura);
        diagonal = Math.Sqrt((altura*altura)+(largura*largura));
        Console.WriteLine($"Largura:{largura}\nAltura: {altura}\nArea: {area}\nPerimetro: {perimetro}\nDiagonal: {diagonal}");

    }
}
