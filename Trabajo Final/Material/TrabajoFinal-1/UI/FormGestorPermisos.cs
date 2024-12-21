using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormGestorPermisos : Form
    {
        public FormGestorPermisos()
        {
            InitializeComponent();
            oBLLUsuario = new BLLEmpleado();
            oBEUsuario = new BEEmpleado();
            oBLLPermiso = new BLLPermiso();
            oBLLBitacora = new BLLBitacora();
        }
        public BEEmpleado UsuarioActual;
        BEEmpleado oBEUsuario;
        BLLEmpleado oBLLUsuario;
        BLLPermiso oBLLPermiso;
        BLLBitacora oBLLBitacora;
        private void FormGestorPermisos_Load(object sender, EventArgs e)
        {
            configurarDatagridViews(this);
            this.Shown += Form_Shown;
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            CargarDataGridUsuarios();
            CargarTreeViewPermisos();
        }

        private void CargarTreeViewPermisos()
        {
            // Se cargan los tree view con los diferentes roles y permisos
            treeView1.CheckBoxes = true;
            treeView1.Nodes.Clear();
            foreach (BERol padre in oBLLPermiso.ListarRoles())
            {
                TreeNode nodoPadre = new TreeNode(padre.Nombre);
                nodoPadre.Tag = padre;
                foreach (BEPermiso hijo in padre.ObtenerHijos())
                {
                    TreeNode nodoHijo = new TreeNode(hijo.Nombre);
                    nodoHijo.Tag = hijo;
                    nodoPadre.Nodes.Add(nodoHijo);
                }
                treeView1.Nodes.Add(nodoPadre);
            }
        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Al darle check a un rol o permiso este se le añade al usuario
            if(e.Node.Nodes.Count != 0)
            {
                BERol Rol = (BERol)e.Node.Tag;
                MarcarPermisosHijos(e.Node, e.Node.Checked);
                AsignarQuitarPermiso(Rol,"Rol", e.Node.Checked);
            }
            else
            {
                BEPermiso Permiso = (BEPermiso)e.Node.Tag;
                AsignarQuitarPermiso(Permiso,"Permiso", e.Node.Checked);
            }
            
        }

        private void MarcarPermisosHijos(TreeNode nodoPadre, bool check)
        {
            treeView1.AfterCheck -= treeView1_AfterCheck;
            foreach (TreeNode nodoHijo in nodoPadre.Nodes)
            {
                nodoHijo.Checked = check;

            }
            treeView1.AfterCheck += treeView1_AfterCheck;
        }

        private void AsignarQuitarPermiso(BEComponente oBEComponente,string Tipo, bool Asignar)
        {
            try
            {
                if(Asignar == true)
                {
                    if(Tipo == "Rol")
                    {
                        BERol Rol = (BERol)oBEComponente;
                        oBEUsuario = (BEEmpleado)this.dataGridViewUsuarios.CurrentRow.DataBoundItem;
                        if (oBLLPermiso.AsignarPermisoUsuario(oBEUsuario, Rol) == true)
                        {
                            oBEUsuario.listaPermisos = oBLLPermiso.ListarPermisosUsuario(oBEUsuario);
                            CargarTreeViewPermisosUsuario();
                            oBLLBitacora.Log(UsuarioActual, $"Rol {Rol.Nombre} asignado al usuario {oBEUsuario.NombreUsuario}");
                        }
                    }
                    else
                    {
                        BEPermiso permisoIndividual = (BEPermiso)oBEComponente;
                        oBEUsuario = (BEEmpleado)this.dataGridViewUsuarios.CurrentRow.DataBoundItem;
                        if (oBLLPermiso.AsignarPermisoUsuario(oBEUsuario, permisoIndividual) == true)
                        {
                            oBEUsuario.listaPermisos = oBLLPermiso.ListarPermisosUsuario(oBEUsuario);
                            CargarTreeViewPermisosUsuario();
                            oBLLBitacora.Log(UsuarioActual, $"Permiso {permisoIndividual.Nombre} asignado al usuario {oBEUsuario.NombreUsuario}");
                        }
                    }
                    
                }
                else
                {
                    oBEUsuario = (BEEmpleado)this.dataGridViewUsuarios.CurrentRow.DataBoundItem;
                    if (oBLLPermiso.BorrarPermisoUsuario(oBEUsuario, oBEComponente) == true)
                    {
                        oBEUsuario.listaPermisos = oBLLPermiso.ListarPermisosUsuario(oBEUsuario);
                        CargarTreeViewPermisosUsuario();
                        oBLLBitacora.Log(UsuarioActual, $"Permiso {oBEComponente.Nombre} retirado al usuario {oBEUsuario.NombreUsuario}");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarTreeViewPermisosUsuario()
        {
            treeView1.AfterCheck -= treeView1_AfterCheck;
            LimpiarChecksTreeView();
            foreach (TreeNode nodoPadre in treeView1.Nodes)
            {
                BEComponente permisoNodo = (BEComponente)nodoPadre.Tag;
                if (oBEUsuario.listaPermisos.Exists(x => x.Id == permisoNodo.Id))
                {
                    if (nodoPadre.Nodes != null)
                    {
                        BERol rol = (BERol)nodoPadre.Tag;
                        nodoPadre.Checked = true;
                        foreach (TreeNode nodoHijo in nodoPadre.Nodes)
                        {
                            nodoHijo.Checked = true;
                        }
                    }
                }
                else
                {
                    foreach(TreeNode nodoHijo in nodoPadre.Nodes)
                    {
                        if(oBEUsuario.listaPermisos.Any(x => x.Nombre == nodoHijo.Text))
                        {
                            nodoHijo.Checked = true;
                        }
                    }
                }
            }
            treeView1.AfterCheck += treeView1_AfterCheck;
        }

        private void LimpiarChecksTreeView()
        {
            foreach (TreeNode nodo in treeView1.Nodes)
            {
                nodo.Checked = false;
                if(nodo.Nodes != null)
                {
                    foreach(TreeNode nodoHijo in nodo.Nodes)
                    {
                        nodoHijo.Checked = false;
                    }
                }
            }
        }

        public void configurarDatagridViews(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is DataGridView)
                {
                    ((DataGridView)c).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    ((DataGridView)c).AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                configurarDatagridViews(c);
            }
        }
        public void CargarDataGridUsuarios()
        {
            try
            {
                // Listo y muestro todos los usuarios
                this.dataGridViewUsuarios.DataSource = oBLLUsuario.ListarTodo().FindAll(x => x.Id != UsuarioActual.Id);
                this.dataGridViewUsuarios.Columns.Remove("Password");
                this.dataGridViewUsuarios.Columns.Remove("Sector");
                this.dataGridViewUsuarios.Columns.Remove("Id");
            }
            catch (Exception ex) { throw ex; }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // muestro los roles del usuario
                oBEUsuario = (BEEmpleado)this.dataGridViewUsuarios.CurrentRow.DataBoundItem;
                oBEUsuario.listaPermisos = oBLLPermiso.ListarPermisosUsuario(oBEUsuario);
                CargarTreeViewPermisosUsuario();
                //cargarDataGridRoles();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
