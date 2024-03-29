﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace Business
{
    public class BCategoria
    {
        private DCategoria DCategoria = null;

        public List<Categoria> Listar(int IdCategoria)
        {
            List<Categoria> categorias = null;
            try
            {
                DCategoria = new DCategoria();
                categorias = DCategoria.Listar(new Categoria { IdCategoria = IdCategoria });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return categorias;
        }

        public int GetMaxId(int IdCategoria)
        {
            List<Categoria> categorias = null;
            try
            {
                DCategoria = new DCategoria();
                categorias = DCategoria.Listar(new Categoria { IdCategoria = IdCategoria });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var idmax = 0;
            for(var i=0; i<categorias.Count; i++)
            {
                if(idmax < categorias[i].IdCategoria)
                {
                    idmax = categorias[i].IdCategoria;
                }
            }
            return idmax + 1;
        }

        public bool Insertar(Categoria categoria)
        {
            bool result = true;
            try
            {
                DCategoria = new DCategoria();
                DCategoria.Insertar(categoria);
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool Actualizar (Categoria categoria)
        {
            bool result = true;
            try
            {
                DCategoria = new DCategoria();
                DCategoria.Actualizar(categoria);
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool Eliminar(int IdCategoria)
        {
            bool result = true;
            try
            {
                DCategoria = new DCategoria();
                DCategoria.Eliminar(IdCategoria);
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
