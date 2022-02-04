namespace ES.Pagamentos.ESPag
{
    public class ESPagService
    {
        public readonly string ApiKey;
        public readonly string EncryptionKey;

        public ESPagService(string apiKey, string encryptionKey)
        {
            ApiKey = apiKey;
            EncryptionKey = encryptionKey;
        }
    }
}
