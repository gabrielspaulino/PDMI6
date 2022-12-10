using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TPFinal.Models;

namespace TPFinal.Data
{
    public class MercadoriaDatabase
    {
        readonly SQLiteAsyncConnection database;

        public MercadoriaDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Mercadoria>().Wait();
        }

        public Task<List<Mercadoria>> GetNotesAsync()
        {
            //Get all notes.
            return database.Table<Mercadoria>().ToListAsync();
        }

        public Task<Mercadoria> GetNoteAsync(string ncm)
        {
            // Get a specific note.
            return database.Table<Mercadoria>()
                            .Where(i => i.Ncm == ncm)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Mercadoria mercadoria)
        {
            if (mercadoria.Ncm != "0")
            {
                // Update an existing note.
                return database.UpdateAsync(mercadoria);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(mercadoria);
            }
        }

        public Task<int> DeleteNoteAsync(Mercadoria mercadoria)
        {
            // Delete a note.
            return database.DeleteAsync(mercadoria);
        }
    }
}
