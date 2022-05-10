// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Api.Data.Context;
// using Api.Domain.Entities;
// using Api.Domain.Interfaces;
// using Microsoft.EntityFrameworkCore;

// namespace Api.Data.Repository
// {
//     public class PlanoRepository<T> : IRepository<T> where T : PlanosEntity
//     {
//         protected readonly MyContext _context;
//         private DbSet<T> _dataset;
//         public PlanoRepository(MyContext context)
//         {
//             _context = context;
//             _dataset = _context.Set<T>();
//         }



//         public async Task<bool> ExistAsync(Guid id)
//         {
//             return await _dataset.AnyAsync(p => p.Id.Equals(id));
//         }

//         public async Task<T> SelectAsync(Guid id)
//         {
//             try
//             {
//                 return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
//             }
//             catch (Exception ex)
//             {
//                 throw ex;
//             }
//         }

//         public async Task<IEnumerable<T>> SelectAsync(string operadora)
//         {
//             try
//             {
//                 // return await _dataset.Find(p => p.operadora.Equals(operadora));
//                 // return await _dataset.Find(p => p.operadora.Equals(operadora));
//                 // // get all data from table by column
//                 // return await _dataset.FindAsync(p => p.operadora.Equals(operadora));
//                 return _dataset.FromSqlRaw("SELECT * FROM planos WHERE operadora = '" + operadora + "'");
//             }
//             catch (Exception ex)
//             {
//                 throw ex;
//             }
//         }

//         public async Task<T> UpdateAsync(T item)
//         {
//             try
//             {
//                 var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
//                 if (result == null)
//                     return null;

//                 _context.Entry(result).CurrentValues.SetValues(item);
//                 await _context.SaveChangesAsync();
//             }
//             catch (Exception ex)
//             {

//                 throw ex;
//             }
//             return item;
//         }
//     }
// }
