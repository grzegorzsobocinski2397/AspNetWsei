namespace WseiProject.Web.Models
{
    /// <summary>
    /// Model of a tree from the forest.
    /// </summary>
    public class TreeModel
    {
        /// <summary>
        /// Unique ID of a tree in the forest.
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Any special information about the tree.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Whether the tree has been already cut down by the lumberjack.
        /// </summary>
        public bool IsCutDown { get; set; }

        /// <summary>
        /// Whether the tree information is valid.
        /// </summary>
        public bool IsValid()
        {
            bool isNameValid = ID.Length > 0;
            bool isDescriptionValid = Description.Length > 0;
            return isNameValid && isDescriptionValid;
        }
    }
}
