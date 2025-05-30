﻿using Microsoft.EntityFrameworkCore.Storage;

namespace SchoolProject.Domain.Interfaces.Persistence;

public interface IGenericRepository<T>
    where T : class
{
    Task DeleteRangeAsync(ICollection<T> entities);

    Task<T?> GetByIdAsync(int id);

    Task SaveChangesAsync();

    IDbContextTransaction BeginTransaction();

    void Commit();

    void RollBack();

    IQueryable<T> GetTableNoTracking();

    IQueryable<T> GetTableAsTracking();

    Task<T?> AddAsync(T entity);

    Task AddRangeAsync(ICollection<T> entities);

    Task<bool> UpdateAsync(T entity);

    Task UpdateRangeAsync(ICollection<T> entities);

    Task<bool> DeleteAsync(T entity);
}