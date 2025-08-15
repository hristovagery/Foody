
using System.Text.Json.Serialization;
namespace Foody.Models
{
    internal class APIResponseDTO
    {
        [JsonPropertyName("msg")]

        public string? Msg {  get; set; }

        [JsonPropertyName("foodid")]
        public string? FoodId { get; set; }

    }
}
