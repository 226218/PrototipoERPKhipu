using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.DAL
{
    public class Administrador
    {
        public string ingresar(string pCodUsuario, string pcontraseña )
        {
            string valor;
            var db = new InstitutoKhipuEntities();
            
                var ingreso = (from u in db.Usuario
                               where u.CodUsuario == pCodUsuario && 
                               u.contraseña==pcontraseña
                               select u.Tipo).First();
            
                valor = ingreso;
            return valor;
        }

        public List<TMatriculaSemetre> Notas(string pCodEstudiante)
        {
            List<TMatriculaSemetre> listanota;
            var db = new InstitutoKhipuEntities();

            var listanotaconsulta = (from u in db.TMatriculaSemetre
                           where u.CodEstudiante == pCodEstudiante
                           select u);
            listanota = listanotaconsulta.ToList();
            return listanota;
        }

        public TCarrera SeleccionarTCarrera(string pCodCurso)
        {
            var db = new InstitutoKhipuEntities();
            return db.TCarrera.Find(pCodCurso);
        }
        public List<TCarrera> SeleccionarTCarreras()
        {
            var db = new InstitutoKhipuEntities();
            return db.TCarrera.ToList<TCarrera>();
        }


        public TCurso SeleccionarTCurso(string pCodCurso)
        {
            var db = new InstitutoKhipuEntities();
            return db.TCurso.Find(pCodCurso);
        }
        public List<TCurso> SeleccionarTCursos()
        {
            var db = new InstitutoKhipuEntities();
            return db.TCurso.ToList<TCurso>();
        }


        public TDocente SeleccionarTDocente(string pCodDocente)
        {
            var db = new InstitutoKhipuEntities();
            return db.TDocente.Find(pCodDocente);
        }
        public List<TDocente> SeleccionarTDocentes()
        {
            var db = new InstitutoKhipuEntities();
            return db.TDocente.ToList<TDocente>();
        }


        public TEstudiante SeleccionarTEstudiante(string pCodEstudiante)
        {
            var db = new InstitutoKhipuEntities();
            return db.TEstudiante.Find(pCodEstudiante);
        }
        public List<TEstudiante> SeleccionarTEstudiantes()
        {
            var db = new InstitutoKhipuEntities();
            return db.TEstudiante.ToList<TEstudiante>();
        }


        public TMatricula SeleccionarTMatricula(string pCodMatricula)
        {
            var db = new InstitutoKhipuEntities();
            return db.TMatricula.Find(pCodMatricula);
        }
        public List<TMatricula> SeleccionarTMatriculas()
        {
            var db = new InstitutoKhipuEntities();
            return db.TMatricula.ToList<TMatricula>();
        }


        public TMatriculaSemetre SeleccionarTMatriculaSemetre(string pCodMatriculaSemetre)
        {
            var db = new InstitutoKhipuEntities();
            return db.TMatriculaSemetre.Find(pCodMatriculaSemetre);
        }
        public List<TMatriculaSemetre> SeleccionarTMatriculaSemetres()
        {
            var db = new InstitutoKhipuEntities();
            return db.TMatriculaSemetre.ToList<TMatriculaSemetre>();
        }

        public TModuloCarrera SeleccionarTModuloCarrera(string pCodModulo)
        {
            var db = new InstitutoKhipuEntities();
            return db.TModuloCarrera.Find(pCodModulo);
        }
        public List<TModuloCarrera> SeleccionarTModuloCarreras()
        {
            var db = new InstitutoKhipuEntities();
            return db.TModuloCarrera.ToList<TModuloCarrera>();
        }
    }
}
