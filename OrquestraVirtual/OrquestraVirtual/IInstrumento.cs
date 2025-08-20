namespace OrquestraVirtual
{
    // Define um namespace para nosso projeto da orquestra.
    namespace OrquestraVirtual
    {
        // --- O CONTRATO (INTERFACE) ---
        // Uma interface é como um contrato que define o que uma classe DEVE fazer,
        // mas não diz COMO ela deve fazer.
        // Qualquer classe que "assinar" este contrato (implementar esta interface)
        // é OBRIGADA a ter um método chamado Tocar().
        public interface IInstrumento
        {
            // Assinatura do método que todas as classes de instrumento deverão implementar.
            void Tocar();

            // Adicionamos uma propriedade para facilitar a identificação do instrumento.
            string Nome { get; }
        }
    }
}