using Cinefilo_1.BD;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinefilo_1
{
    static class BDCinefilo
    {
        static cinefiloEntities contexto = new cinefiloEntities();

        public static List<TIPOS_PAPEL> getTipoDePapel()
        {
            List<TIPOS_PAPEL> list = (from tipo in contexto.TIPOS_PAPEL
                                       select tipo).ToList();  
            return list;

        }

        public static bool setPapelToActor(String nombrePapel, String nombrePeli, String nombreActor)
        {
            bool resul = false;

            try
            {

                //obtenemos datos para buscar el objeto papel que se corresponada con el papel seleccionado
                PAPEL p = new PAPEL();
                
                p.id_tipo_papel = (int) getTipusPapel(nombrePapel);
                p.id_pelicula = (int) getIdPeliculaPorNombre(nombrePeli);
                p.dni = getDniActorPorNombre(nombreActor).ToString();
                contexto.PAPEL.Add(p);
                contexto.SaveChanges();

                resul = true;

            }
            catch (DbUpdateException sqlEx) //controlamos excepciones
            {
                SqlException ex = ((SqlException)sqlEx.InnerException.InnerException);
                String msg = BDerror.controlError(ex);
                BDCinefilo.undo();
                MessageBox.Show(msg);
            }

            return resul;
        }

        private static int getTipusPapel(String descripcion)
        {
            int tipusPaper = (from p in contexto.TIPOS_PAPEL
                                      where p.descripcion.Equals(descripcion)
                                      select p.id_tipos).First();

            return tipusPaper;
        }

        //insert papel
        public static void altaTipoPapel(String alta)
        {

            TIPOS_PAPEL tp = new TIPOS_PAPEL();

            try
            {
                if (!String.IsNullOrEmpty(alta))
                {
                    tp.descripcion = alta;
                    //hay que hacer un add una vez el objeto está seteado
                    contexto.TIPOS_PAPEL.Add(tp);
                    contexto.SaveChanges();
                    
                }
            }
            catch (DbUpdateException sqlEx) //controlamos excepciones
            {

                SqlException ex = ((SqlException)sqlEx.InnerException.InnerException);
                String msg = BDerror.controlError(ex);
                BDCinefilo.undo();
                MessageBox.Show(msg);
            };
        }

        //insert tema
        public static void altaTema(String alta)
        {

            TEMAS t = new TEMAS();

            //controla valores nulos o vacios
            if (!String.IsNullOrEmpty(alta))
            {
                 t.descripcion = alta;
                 contexto.TEMAS.Add(t);
                 contexto.SaveChanges();
            }
            
        }

        //insert pelicula
        public static bool altaNuevaPelicula(String tituloPelicula, String directorPelicula, List<TEMAS> listaTemas)
        {
            bool resul = false;

            PELICULAS p = new PELICULAS();    

            try
            {
                if (!String.IsNullOrEmpty(tituloPelicula) && !String.IsNullOrEmpty(directorPelicula))
                {      

                    //hay que hacer un add una vez el objeto está seteado
                    p.titulo = tituloPelicula;
                    p.director = directorPelicula;
                    foreach (var item in listaTemas)
                    {
                        p.TEMAS.Add(item);           
                    }

                    contexto.PELICULAS.Add(p);
                    contexto.SaveChanges();

                    resul = true;
                }
            }
            catch (DbUpdateException sqlEx) //controlamos excepciones
            {

                SqlException ex = ((SqlException)sqlEx.InnerException.InnerException);
                String msg = BDerror.controlError(ex);
                BDCinefilo.undo();
                MessageBox.Show(msg);
            }

            return resul;
        }

        //insert actor
        public static bool altaNuevoActor(String dni, String nombre, String sexo, int edad)
        {
            bool resul = false;

            ACTORES act = new ACTORES();

            try
            {
                if (!String.IsNullOrEmpty(dni))
                {
                    act.dni= dni;
                    act.nombre = nombre;
                    act.sexo = sexo;
                    act.edad = edad;
                    //hay que hacer un add una vez el objeto está seteado
                    contexto.ACTORES.Add(act);
                    contexto.SaveChanges();

                    resul = true;
                }
            }
            catch (DbUpdateException sqlEx) //controlamos excepciones
            {

                SqlException ex = ((SqlException)sqlEx.InnerException.InnerException);
                String msg = BDerror.controlError(ex);
                BDCinefilo.undo();
                MessageBox.Show(msg);
            }

            return resul;
        }

        public static bool comprobarDuplicidadesPeliculas(
            String titulo, 
            String director, 
            List<TEMAS> list)
        {
            bool resul = false;

            List<PELICULAS> listPeliculas = getPeliculas(); 

            //recorremos List buscando posibles duplicidades
            foreach (PELICULAS p in listPeliculas)
            {
                //hemos encontrado una duplicidad
                if (p.titulo.Equals(titulo) &&
                    p.director.Equals(director) &&
                    p.TEMAS == p.TEMAS)
                {
                    resul = true;
                }
            }

            return resul;
        }

        //"Commit" sobre la base de datos
        public static void confirmarCambios()
        {
            contexto.SaveChanges();
        }

        public static List<ACTORES> getActores()
        {
            List<ACTORES> list = (from actor in contexto.ACTORES
                                select actor).ToList();

            return list;
        }

        public static List<String> getActoresNombre()
        {
            List<String> list = (from actor in contexto.ACTORES
                                  select actor.nombre).ToList();

            return list;
        }

        public static ACTORES getActoresPorDni(String dniActor)
        {
            ACTORES actor = (from a in contexto.ACTORES
                                 where a.dni.Equals(dniActor)
                                 select a).First();
            return actor;
        }


        public static List<TEMAS> getTema()
        {
            List<TEMAS> list = (from tema in contexto.TEMAS
                                select tema).ToList();

            return list;
        }

        public static List<PELICULAS> getPeliculas()
        {
            List<PELICULAS> list = (from p in contexto.PELICULAS
                                select p).ToList();

            return list;
        }

        public static List<String> getPeliculasTitulo()
        {
            List<String> list = (from p in contexto.PELICULAS
                                    select p.titulo).ToList();

            return list;
        }

        /**
         * Busca las peliculas por id.
         * Devuelve un objeto de la clase PELICULAS
         */
        public static PELICULAS getPeliculasById(int id_pelicula)
        {
            PELICULAS item = (PELICULAS)(from p in contexto.PELICULAS
                                         where p.id_pelicula == id_pelicula
                                         select p).First();
            return item;
        }

        public static List<ACTORES> filterActores(String criterioBusquedaNombre, String criterioBusquedaSexo)
        {

            //Filtra por el campo pasado por el usuario en el textbox
            //En LINQ no hay Likes, así que utilizamos el método Contains
            List<ACTORES> list = (from a in contexto.ACTORES
                                   where a.nombre.Contains(criterioBusquedaNombre) &&
                                  a.sexo.Contains(criterioBusquedaSexo)
                                select a).ToList();

            return list;
        }


        public static List<TEMAS> filterTema(String criterioBusqueda)
        {

            //Filtra por el campo pasado por el usuario en el textbox
            //En LINQ no hay Likes, así que utilizamos el método Contains
            List<TEMAS> list = (from tema in contexto.TEMAS
                                where tema.descripcion.Contains(criterioBusqueda)
                                select tema
                                ).ToList();

            return list;
        }

        public static List<PELICULAS> filterPelis(String criterioBusquedaTitulo, String criterioBusquedaDirector)
        {

            //Filtra por el campo pasado por el usuario en el textbox
            //En LINQ no hay Likes, así que utilizamos el método Contains
            List<PELICULAS> list = (from peli in contexto.PELICULAS
                                where peli.titulo.Contains(criterioBusquedaTitulo) &&
                                    peli.director.Contains(criterioBusquedaDirector)
                                select peli
                                ).ToList();

            return list;
        }

        public static PELICULAS getPeliculaPorCriterios(String criterioBusquedaTitulo, String criterioBusquedaDirector)
        {

            PELICULAS p = (PELICULAS) (from peli in contexto.PELICULAS
                              where peli.titulo.Contains(criterioBusquedaTitulo) &&
                                  peli.director.Contains(criterioBusquedaDirector)
                              select peli).First();

            return p;
        }

        public static void confirmarModificaPelicula()
        {
            contexto.SaveChanges();
        }

        public static void borrarActor(String dni, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                //APUNTE: El método first hace que cojas el primer elemento
                //de lo contrario te cojerá toda una colección
                ACTORES actor = (ACTORES)(from a in contexto.ACTORES
                                             where a.dni.Equals(dni)
                                             select a).First();

                if (actor != null)
                {
                    contexto.ACTORES.Remove(actor);
                    contexto.SaveChanges();
                }

            }
            catch (DbUpdateException sqlEx) //controlamos excepciones
            {

                SqlException sql = ((SqlException)sqlEx.InnerException.InnerException);
                String msg = BDerror.controlError(sql);
                BDCinefilo.undo();
                MessageBox.Show(msg);
                e.Cancel = true;

            }

        }


        public static void borrarPelicula(int index, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                //APUNTE: El método first hace que cojas el primer elemento
                //de lo contrario te cojerá toda una colección
                PELICULAS item = (PELICULAS)(from peli in contexto.PELICULAS
                                                     where peli.id_pelicula == index
                                                     select peli).First();
   
                if (item != null)
                {
                    contexto.PELICULAS.Remove(item);
                    contexto.SaveChanges();
                }

            }
            catch (DbUpdateException sqlEx) //controlamos excepciones
            {

                SqlException sql = ((SqlException)sqlEx.InnerException.InnerException);
                String msg = BDerror.controlError(sql);
                BDCinefilo.undo();
                MessageBox.Show(msg);
                e.Cancel = true;

            }    
                
        }


        public static List<TIPOS_PAPEL> filterTipoPapel(String criterioBusqueda)
        {

            //Filtra por el campo pasado por el usuario en el textbox
            //En LINQ no hay Likes, así que utilizamos el método Contains
            List<TIPOS_PAPEL> list = (from t in contexto.TIPOS_PAPEL
                                where t.descripcion.Contains(criterioBusqueda)
                                select t
                                ).ToList();

            return list;
        }


        //método undo() deshace cambios
        public static void undo()
        {
            foreach (DbEntityEntry item in 
                contexto.ChangeTracker.Entries())
            {
                item.State = System.Data.Entity.EntityState.Unchanged;
                item.Reload();
            }

        }

        public static List<String> getPeliculasBusqueda(String titulo, String director)
        {
            List<String> list = (from p in contexto.PELICULAS
                                 where p.titulo.Contains(titulo) &&
                                 p.director.Contains(director)
                                 select p.titulo).ToList();

            return list;
        }

        public static List<String> getBusquedaActores(string sexo, string nombre)
        {
            List<String> list = (from a in contexto.ACTORES
                                 where a.sexo.Contains(sexo) &&
                                 a.nombre.Contains(nombre)
                                 select a.nombre).ToList();

            return list;
        }


        #region ESTOS TRES MÉTODOS SE UTILIZAN PARA OBTENER LOS PAPELES DE LOS ACTORES SELECCIONADOS
        public static String getDniActorPorNombre(string nombre)
        {
            String list = (from a in contexto.ACTORES
                                 where a.nombre.Equals(nombre)
                                 select a.dni).First();

            return list;
        }

        public static int getIdTipoPapelActorPorDni(String dni)
        {
            int resul = (from a in contexto.PAPEL
                           where a.dni.Equals(dni)
                           select a.id_tipo_papel).First();

            return resul;
        }
         
        public static String getDescripcionPapelActorSeleccionado(int id)
        {
            String resul = (from a in contexto.TIPOS_PAPEL
                         where a.id_tipos == id
                         select a.descripcion).First();

            return resul;
        }
        #endregion

        public static List<String> getPapeles()
        {
            List<String> list = (from p in contexto.TIPOS_PAPEL                              
                                 select p.descripcion).ToList();

            return list;
        }

       
        public static int getIdPeliculaPorNombre(String nombrePeli)
        {
            int resul = (from p in contexto.PELICULAS
                         where p.titulo.Equals(nombrePeli)
                         select p.id_pelicula).First();

            return resul; 
            
        }


        public static PAPEL getUnPapelConcreto(String dniActor, int idPeli, int idTipoPapel)
        {
            PAPEL papel = (PAPEL) (from p in contexto.PAPEL
                          where p.dni.Equals(dniActor) &&
                            p.id_pelicula == idPeli &&
                            p.id_tipo_papel == idTipoPapel
                            select p).First();

            return papel;
        }
    }
}
