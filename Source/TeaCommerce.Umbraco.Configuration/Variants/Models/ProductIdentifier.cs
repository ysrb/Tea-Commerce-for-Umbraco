﻿
namespace TeaCommerce.Umbraco.Configuration.Variants.Models {
  public class ProductIdentifier {

    public int NodeId { get; set; }
    public string VariantId { get; set; }

    public ProductIdentifier( string productIdentifier ) {
      if ( productIdentifier.Contains( "_" ) ) {
        string nodeIdStr = productIdentifier.Split( '_' )[ 0 ];
        int nodeId;
        int.TryParse( nodeIdStr, out nodeId );
        NodeId = nodeId;
        VariantId = productIdentifier.Split( '_' )[ 1 ].Trim();
      } else {
        string nodeIdStr = productIdentifier;
        int nodeId;
        int.TryParse( nodeIdStr, out nodeId );
        NodeId = nodeId;
      }
    }
  }

}
