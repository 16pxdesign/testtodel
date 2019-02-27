/**
 * 
 * name         :   Mark.cs
 * author       :   Kevin McDonald
 * email        :   kevin.mcdonald@dundeeandangus.ac.uk
 * version      :   1.0
 * date         :   15th February 2019
 * description  :   Mark model class representing a student result
 *
 * */

namespace Assessment.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Mark")]
    public partial class Mark
    {
        public int Id { get; set; }

        public int Total { get; set; }
    }
}
//--    End of File --//