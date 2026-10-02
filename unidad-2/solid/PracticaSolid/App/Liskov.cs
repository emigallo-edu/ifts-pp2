namespace App
{
    public class Rectangulo
    {
        protected int ancho;
        protected int alto;

        public virtual void SetearAncho(int ancho)
        {
            this.ancho = ancho;
        }

        public virtual void SetearAlto(int alto)
        {
            this.alto = alto;
        }

        public string CalcularArea()
        {
            int area = ancho * alto;
            Console.WriteLine($"El área del rectángulo es: {area}");
            return $"El área del rectángulo es: {area}";
        }
    }

    public class Cuadrado : Rectangulo
    {
        public override void SetearAncho(int ancho)
        {
            this.ancho = ancho;
            this.alto = ancho;
        }

        public override void SetearAlto(int alto)
        {
            this.ancho = alto;
            this.alto = alto;
        }
    }
}