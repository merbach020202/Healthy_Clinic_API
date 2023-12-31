﻿using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;
using Healthy_Clinic_Manha_Edu.Utils;

namespace Healthy_Clinic_Manha_Edu.Repositores
{
    public class AdministradorRepository : IAdministradorRepository
    {
        private readonly Context _context;

        public AdministradorRepository()
        {
            _context = new Context();
        }

        public void Atualizar(Guid id, Administrador administrador)
        {
            Administrador administradorBuscado = _context.Administrador.Find(id);

            if (administradorBuscado != null)
            {
                administradorBuscado.Nome = administrador.Nome;
            }

            _context.Administrador.Update(administradorBuscado);

            _context.SaveChanges();
        }

        public Administrador BuscarPorId(Guid id)
        {
            return _context.Administrador.FirstOrDefault(e => e.IdAdministrador == id);
        }

        public void Cadastrar(Administrador administrador)
        {
            try
            {
                _context.Administrador.Add(administrador);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Administrador administradorBuscado = _context.Administrador.Find(id);

            _context.Administrador.Remove(administradorBuscado);

            _context.SaveChanges();
        }

        public List<Administrador> Listar()
        {
            return _context.Administrador.ToList();
        }
    }
}
