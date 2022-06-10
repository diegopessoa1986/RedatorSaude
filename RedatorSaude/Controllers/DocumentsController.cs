using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedatorSaude.Data;
using RedatorSaude.Models;
using RedatorSaude.Service;

namespace RedatorSaude.Controllers
{
    [Authorize]
    public class DocumentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        

        public DocumentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Documents
        public async Task<IActionResult> Index()
        {
            return View(await _context.Document.ToListAsync());
        }

        // GET: Documents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Document
                .FirstOrDefaultAsync(m => m.id == id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        // GET: Documents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Documents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Vara,Foro,Cidade,Estado,NumeroProcesso,Autor,Reu,NomePeca,Usuario")] DocumentVM documentoSimplesVM)
        {

            Document documentoSimples = new Document() 
            {
                Autor = documentoSimplesVM.Autor,
                Cidade = documentoSimplesVM.Cidade,
                DataCriacao = DateTime.Now.ToString("dd-MM-yyyy"),
                Estado = documentoSimplesVM.Estado,
                Foro = documentoSimplesVM.Foro,
                NomePeca = documentoSimplesVM.NomePeca,
                NumeroProcesso = documentoSimplesVM.NumeroProcesso,
                Reu = documentoSimplesVM.Reu,
                Vara = documentoSimplesVM.Vara,
                id = documentoSimplesVM.id
            };

            UsuarioSistema usuarioSistema = new UsuarioSistema() 
            { 
                Login = documentoSimplesVM.Usuario,
                PecaCriada = documentoSimplesVM.NomePeca,
                DataCriada = DateTime.Now
            };

            if (ModelState.IsValid)
            {
                try
                {
                    Stream stream = DocumentService.CreateSimpleDoc(documentoSimples);
                    if (stream != null)
                    {
                        
                        _context.Add(documentoSimples);
                        _context.Add(usuarioSistema);
                            
                        await _context.SaveChangesAsync();

                        var typeString = SimpleDocumentHelper.GetTypeString(documentoSimples.NomePeca);
                        return File(stream, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "Documento_" + typeString + ".docx");
                    }
                }
                catch (Exception e)
                {
                    //Retornar para uma pagina de erro.
                    //Ou aparece um modal.
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(documentoSimples);
        }

        // GET: Documents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Document.FindAsync(id);
            if (document == null)
            {
                return NotFound();
            }
            return View(document);
        }

        // POST: Documents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Vara,Foro,Cidade,Estado,NumeroProcesso,Autor,Reu,DataCriacao,NomePeca")] Document document)
        {
            if (id != document.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(document);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentExists(document.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(document);
        }

        // GET: Documents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Document
                .FirstOrDefaultAsync(m => m.id == id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        // POST: Documents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var document = await _context.Document.FindAsync(id);
            _context.Document.Remove(document);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocumentExists(int id)
        {
            return _context.Document.Any(e => e.id == id);
        }
    }
}
