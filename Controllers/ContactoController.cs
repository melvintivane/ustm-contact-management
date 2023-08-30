using GestorDeContactos.Data;
using GestorDeContactos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GestorDeContactos.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ContactosDBContext mvcContactoDbContext;

        public ContactoController(ContactosDBContext mvcContactoDbContext)
        {
            this.mvcContactoDbContext = mvcContactoDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var contactos = await mvcContactoDbContext.Contactos.ToListAsync();
            return View(contactos);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddContactoViewModel addContactoRequest)
        {
            var contacto = new Contacto()
            {
                Id = Guid.NewGuid(),
                Nome = addContactoRequest.Nome,
                Apelido = addContactoRequest.Apelido,
                Email = addContactoRequest.Email,
                Telefone = addContactoRequest.Telefone
            };

            await mvcContactoDbContext.Contactos.AddAsync(contacto);
            await mvcContactoDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var contacto = await mvcContactoDbContext.Contactos.FirstOrDefaultAsync(x => x.Id == id);

            if (contacto != null)
            {
                
                var viewModel = new UpdateContactoViewModel()
                {
                    Id = contacto.Id,
                    Nome = contacto.Nome,
                    Apelido = contacto.Apelido,
                    Email = contacto.Email,
                    Telefone = contacto.Telefone
                };
                return await Task.Run(() => View("View", viewModel));
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateContactoViewModel model)
        {
            var contacto = await mvcContactoDbContext.Contactos.FindAsync(model.Id);

            if (contacto != null)
            {
                contacto.Nome = model.Nome;
                contacto.Apelido = model.Apelido;
                contacto.Email = model.Email;
                contacto.Telefone = model.Telefone;

                await mvcContactoDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateContactoViewModel model)
        {
            var contacto = await mvcContactoDbContext.Contactos.FindAsync(model.Id);

            if (contacto != null)
            {
                mvcContactoDbContext.Contactos.Remove(contacto);
                await mvcContactoDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }
}