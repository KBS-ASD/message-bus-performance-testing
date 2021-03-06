using System.Collections.Generic;

namespace KBS.Topics.WebshopCase
{
    /// <summary>
    /// Complete item list from the webshop, received by buyer
    /// </summary>
    public interface ICatalogueReply : IMessageDiagnostics
    {
        /// <summary>
        /// String array of all available items
        /// </summary>
        Dictionary<string, int> Catalogue { get; }
    }
}
