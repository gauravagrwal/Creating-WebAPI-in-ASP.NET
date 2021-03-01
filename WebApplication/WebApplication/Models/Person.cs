namespace WebApplication.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Id from sql
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// firstname of the user
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// lastname of the user 
        /// </summary>
        public string LastName { get; set; } = "";
    }
}