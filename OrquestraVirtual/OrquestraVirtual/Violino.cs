namespace OrquestraVirtual
{
    using System;

    namespace OrquestraVirtual
    {
        // A classe Violino "assina" o contrato IInstrumento.
        // Isso significa que ela promete ter um método Tocar() e uma propriedade Nome.
        public class Violino : IInstrumento
        {
            // Implementação da propriedade Nome exigida pela interface.
            public string Nome => "Violino";

            // Implementação específica do método Tocar() para o Violino.
            public void Tocar()
            {
                // Imprime o som característico do violino no console.
                Console.WriteLine("Violino: ♫ fiiiiiiuuu ♫");
            }
        }
    }
}