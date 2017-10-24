namespace SimuRails
{
    class KeyValue
    {
        public int Clave { get; set; }
        public string Valor { get; set; }
        public KeyValue(int clave, string valor)
        {
            Clave = clave;
            Valor = valor;
        }

    }
}

