using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdminBLL
    {
        private readonly AdminDAL adminDAL;

        public AdminBLL(string connectionString)
        {
            adminDAL = new AdminDAL(connectionString);
        }
        public bool IsIdentificationDuplicate(string identification)
        {
            return adminDAL.IsIdentificationDuplicate(identification);
        }

        public void AddAdmin(Admin admin)
        {
            ValidateAdmin(admin);
            adminDAL.AddAdmin(admin);
        }
        public void UpdateAdmin(Admin admin)
        {
            ValidateAdmin(admin);
            adminDAL.UpdateAdmin(admin);
        }

        public void DeleteAdmin(string identificacion)
        {
            if (string.IsNullOrEmpty(identificacion))
            {
                throw new ArgumentException("La identificación no puede estar vacía.");
            }
            adminDAL.DeleteAdmin(identificacion);
        }

        public List<Admin> GetAllAdmins()
        {
            return adminDAL.GetAllAdmins();
        }
        private void ValidateAdmin(Admin admin)
        {
            if (string.IsNullOrEmpty(admin.NombreCompleto))
            {
                throw new ArgumentException("El nombre completo no puede estar vacío.");
            }

            if (string.IsNullOrEmpty(admin.Identificacion))
            {
                throw new ArgumentException("La identificación no puede estar vacía.");
            }

            if (string.IsNullOrEmpty(admin.Cargo))
            {
                throw new ArgumentException("El cargo no puede estar vacía.");
            }
        }
    }
}
