namespace OrquestraVirtual
{
    using System;

    namespace OrquestraVirtual
    {
        // A classe Tambor também implementa a interface IInstrumento.
        public class Tambor : IInstrumento
        {
            public string Nome => "Tambor";

            // Implementação do método Tocar() para o Tambor.
            public void Tocar()
            {
                Console.WriteLine("Tambor: ♫ tum tum tum ♫");
            }
        }
    }
}