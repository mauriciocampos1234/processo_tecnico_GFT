namespace OrquestraVirtual
{
    using System;

    namespace OrquestraVirtual
    {
        // A classe Piano também implementa a interface IInstrumento.
        public class Piano : IInstrumento
        {
            public string Nome => "Piano";

            // Implementação do método Tocar() para o Piano.
            public void Tocar()
            {
                Console.WriteLine("Piano: ♫ plim plim plim ♫");
            }
        }
    }
}