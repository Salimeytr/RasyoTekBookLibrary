using BookLibrary.DTO;
using BookLibrary.Ent.Entities;

namespace BookLibrary.UI.Models.ViewModel
{
    public class BooksModel
    {
        public Books Books {get; set;}
        public List<CategoriesSelect> categoriesSelects { get; set; }
        public List<PublishersSelect> publishersSelects { get; set; }
        public List<WritersSelect> writersSelects { get; set; }

    }
}
