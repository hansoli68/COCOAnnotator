using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LabelAnnotator.Records.COCO {
    public class AnnotationCOCO {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("category_id")]
        public int CategoryID { get; set; }

        [JsonPropertyName("image_id")]
        public int ImageID { get; set; }

        [JsonPropertyName("iscrowd")]
        public int IsCrowd { get; set; }

        [JsonPropertyName("bbox")]
        public List<double> BoundaryBox { get; set; } = new List<double>();

        [JsonPropertyName("area")]
        public double Area { get; set; }
    }
}
