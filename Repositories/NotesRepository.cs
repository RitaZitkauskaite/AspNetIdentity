using AspNetIdentity.Areas.Identity.Data;
using AspNetIdentity.Model;
using AspNetIdentity.Pages.Notes;

namespace AspNetIdentity.Repositories
{
    public class NotesRepository
    {
        private readonly AspNetIdentityContext _context;

        public NotesRepository(AspNetIdentityContext context)
        {
            _context = context;
        }

        public List<Note> GetNotes()
        {
            return _context.Notes.ToList();
        }

        public List<Note> GetNotesByUserId(string id)
        {
            return _context.Notes.Where(note => note.AspNetIdentityUserId == id).ToList();
        }
    }
}
