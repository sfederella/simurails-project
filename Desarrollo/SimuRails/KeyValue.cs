namespace SimuRails
{
    class KeyValue
    {
        public string Clave { get; set; }
        public double Valor { get; set; }
        public KeyValue(string clave, double valor)
        {
            Clave = clave;
            Valor = valor;
        }

    }
}

