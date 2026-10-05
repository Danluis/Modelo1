using System.Linq.Expressions;
using DANLUIS_AP1_P1.Context;
using DANLUIS_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace DANLUIS_AP1_P1.Services;

public class AutorService(
    IDbContextFactory<Contexto> DbFactory
    ) : Aplicada1.Core.IService<Autor, int>
{
    public async Task<bool> Guardar(Autor entidad)
    {
        if (!await Existe(entidad.AutorId))
        {
            return await Insertar(entidad);
        }
        else
        {
            return await Modificar(entidad);
        }
    }

    private async Task<bool> Existe(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Autorc
            .AnyAsync(m => m.AutorId == id);
    }

    private async Task<bool> Insertar(Autor entidad)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Autorc.Add(entidad);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Autor entidad)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Autorc.Update(entidad);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<Autor?> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Autorc
            .FirstOrDefaultAsync(m => m.AutorId == id);
    }

    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Autorc
            .AsNoTracking()
            .Where(m => m.AutorId == id)
            .ExecuteDeleteAsync() > 0;
    }

    public async Task<List<Autor>> GetList(Expression<Func<Autor, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Autorc
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }
}