using System.Text.Json.Serialization;

namespace OpenAC.Net.NFSe.Nacional.Webservice
{
    public sealed class MensagemProcessamentoEvento
    {

        [JsonPropertyName("codigo")]
        public string Codigo { get; set; } = string.Empty;

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; } = string.Empty;
    }
}
