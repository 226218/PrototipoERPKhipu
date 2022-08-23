using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstitutoKhipuERP.DAL;
namespace InstitutoKhipuERP.BL
{
    public class Administrador
    {
        public string ingresar(string pCodUsuario, string pcontraseña)
        {


            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.Usuario();
            return adm.ingresar(pCodUsuario, pcontraseña);

        }

        public List<Entidades.TMatriculaSemetre> Notas(string pCodEstudiante)
        {
           
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TMatriculaSemetre();
            return traductor.HaciaTMatriculaSemetre(adm.Notas(pCodEstudiante));

        }






        public Entidades.TCarrera SeleccionarTCarrera(string pCodCarrera)
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TCarrera();
            return traductor.HaciaTCarrera(adm.SeleccionarTCarrera(pCodCarrera));
        }
        public List<Entidades.TCarrera> SeleccionarTCarreras()
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TCarrera();
            return traductor.HaciaTCarrera(adm.SeleccionarTCarreras());
        }

        public Entidades.TCurso SeleccionarTCurso(string pCodCurso)
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TCurso();
            return traductor.HaciaTCurso(adm.SeleccionarTCurso(pCodCurso));
        }
        public List<Entidades.TCurso> SeleccionarTCursos()
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TCurso();
            return traductor.HaciaTCurso(adm.SeleccionarTCursos());
        }



        public Entidades.TDocente SeleccionarTDocente(string pCodDocente)
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TDocente();
            return traductor.HaciaTDocente(adm.SeleccionarTDocente(pCodDocente));
        }
        public List<Entidades.TDocente> SeleccionarTDocentes()
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TDocente();
            return traductor.HaciaTDocente(adm.SeleccionarTDocentes());
        }



        public Entidades.TEstudiante SeleccionarTEstudiante(string pCodEstudiante)
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TEstudiante();
            return traductor.HaciaTEstudiante(adm.SeleccionarTEstudiante(pCodEstudiante));
        }
        public List<Entidades.TEstudiante> SeleccionarTEstudiantes()
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TEstudiante();
            return traductor.HaciaTEstudiante(adm.SeleccionarTEstudiantes());
        }



        public Entidades.TMatricula SeleccionarTMatricula(string pCodMatricula)
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TMatricula();
            return traductor.HaciaTMatricula(adm.SeleccionarTMatricula(pCodMatricula));
        }
        public List<Entidades.TMatricula> SeleccionarTMatriculas()
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TMatricula();
            return traductor.HaciaTMatricula(adm.SeleccionarTMatriculas());
        }


        public Entidades.TMatriculaSemetre SeleccionarTMatriculaSemetre(string pCodMatriculaSemetre)
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TMatriculaSemetre();
            return traductor.HaciaTMatriculaSemetre(adm.SeleccionarTMatriculaSemetre(pCodMatriculaSemetre));
        }
        public List<Entidades.TMatriculaSemetre> SeleccionarTMatriculaSemetres(string pCodEstudiante)
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TMatriculaSemetre();
            return traductor.HaciaTMatriculaSemetre(adm.Notas(pCodEstudiante));
        }




        public Entidades.TModuloCarrera SeleccionarTModuloCarrera(string pCodModulo)
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TModuloCarrera();
            return traductor.HaciaTModuloCarrera(adm.SeleccionarTModuloCarrera(pCodModulo));
        }
        public List<Entidades.TModuloCarrera> SeleccionarTModuloCarreras()
        {
            var adm = new InstitutoKhipuERP.DAL.Administrador();
            var traductor = new Traductores.TModuloCarrera();
            return traductor.HaciaTModuloCarrera(adm.SeleccionarTModuloCarreras());
        }



    }
}
