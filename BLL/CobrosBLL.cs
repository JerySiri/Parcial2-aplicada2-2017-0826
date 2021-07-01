using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial2_aplicada2_2017_0826.DAL;
using Parcial2_aplicada2_2017_0826.Models;

namespace Parcial2_aplicada2_2017_0826.BLL
{
    public class CobrosBLL
    {
        public static bool Guardar(Cobros cobro)
        {
            if (!Existe(cobro.cobroId))
                return Insertar(cobro);
            else
                return false;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool fueEncontrado = false;

            try
            {
                fueEncontrado = contexto.Cobros.Any(e => e.cobroId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return fueEncontrado;
        }

        private static bool Insertar(Cobros cobro)
        {
            bool fueInsertada = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Cobros.Add(cobro);
                fueInsertada = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return fueInsertada;
        }

        public static Cobros Buscar(int id)
        {
            Cobros cobro = new Cobros();
            Contexto contexto = new Contexto();

            try
            {
                cobro = contexto.Cobros
                    .Where(e => e.cobroId == id)
                    .Include(e => e.CobrosDetalles)
                    .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return cobro;
        }

        public static bool Eliminar(int id)
        {
            bool fueEliminada = false;
            Contexto contexto = new Contexto();
            try
            {
                
                Cobros cobro = contexto.Cobros.Find(id);

                if (cobro != null)
                {
                    contexto.Cobros.Remove(cobro);
                    fueEliminada = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return fueEliminada;
        }

        public static List<Cobros> GetList(Expression<Func<Cobros, bool>> criterio)
        {
            List<Cobros> ListaCobros = new List<Cobros>();
            Contexto contexto = new Contexto();
            try
            {
                ListaCobros = contexto.Cobros.Where(criterio).Include(e => e.CobrosDetalles).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ListaCobros;
        }


    }
}
