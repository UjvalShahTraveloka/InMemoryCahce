using System;
using Microsoft.Extensions.Caching.Memory;
using Npgsql;

namespace MemoryCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myGCCol = new Program();
            
            var cs = "Host=localhost;Port=54323;Username=masterdata-user;Password=masterdata-password;Database=masterdata-db";

            using var con = new NpgsqlConnection(cs);
            
            int count = 0;

            #region Companies
            
            con.Open();
            Console.WriteLine("----------------------------Companies------------------------------------------"); 
            string sql = $"SELECT * FROM public.\"Companies\"";
            using var cmd = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader rdr = cmd.ExecuteReader();
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory before cache: {0}", GC.GetTotalMemory(false));
            
            var cache = new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions());

            while (rdr.Read())
            {
                //Console.WriteLine("{0} {1}", rdr.GetString(0), rdr.GetString(1));
                var result = cache.Set(rdr.GetString(0), rdr.GetString(1));
                count++;
            }

            //Console.WriteLine("Size of the Cache : {0} " + size);
            Console.WriteLine(cache.Count);
            Console.WriteLine(count);
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory After Caching: {0}", GC.GetTotalMemory(false));
            
            Console.WriteLine("----------------------------Companies------------------------------------------"); 
            con.Close();
            
            #endregion
            
            #region Currencies
            
            con.Open();
            Console.WriteLine("----------------------------Currencies------------------------------------------"); 
            sql = $"SELECT * FROM public.\"Currencies\"";
            using var cmd1 = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader rdr1 = cmd1.ExecuteReader();
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory before cache: {0}", GC.GetTotalMemory(false));
            
            //var cache = new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions());

            while (rdr1.Read())
            {
                //Console.WriteLine("{0} {1}", rdr.GetString(0), rdr.GetString(1));
                cache.Set(rdr1.GetString(0), rdr1.GetString(1));
                count++;
            }

            //Console.WriteLine("Size of the Cache : {0} " + size);
            Console.WriteLine(cache.Count);
            Console.WriteLine(count);
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory After Caching: {0}", GC.GetTotalMemory(false));
            
            Console.WriteLine("----------------------------Currencies------------------------------------------"); 
            con.Close();
            #endregion
            
            #region MutationTypes
            con.Open();
            Console.WriteLine("----------------------------MutationTypes------------------------------------------"); 
            sql = $"SELECT * FROM public.\"MutationTypes\"";
            using var cmd2 = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader rdr2 = cmd2.ExecuteReader();
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory before cache: {0}", GC.GetTotalMemory(false));
            
            //var cache = new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions());

            while (rdr2.Read())
            {
                //Console.WriteLine("{0} {1}", rdr.GetString(0), rdr.GetString(1));
                cache.Set(rdr2.GetString(0), rdr2.GetString(1));
                count++;
            }

            //Console.WriteLine("Size of the Cache : {0} " + size);
            Console.WriteLine(cache.Count);
            Console.WriteLine(count);
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory After Caching: {0}", GC.GetTotalMemory(false));
            
            Console.WriteLine("----------------------------MutationTypes------------------------------------------"); 
            con.Close();
            #endregion
            
            #region LedgerAccountTypes
            con.Open();
            Console.WriteLine("----------------------------LedgerAccountTypes------------------------------------------"); 
            sql = $"SELECT * FROM public.\"LedgerAccountTypes\"";
            using var cmd3 = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader rdr3 = cmd3.ExecuteReader();
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory before cache: {0}", GC.GetTotalMemory(false));
            
            //var cache = new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions());

            while (rdr3.Read())
            {
                //Console.WriteLine("{0} {1}", rdr.GetString(0), rdr.GetString(1));
                cache.Set(rdr3.GetString(0), rdr3.GetString(1));
                count++;
            }

            //Console.WriteLine("Size of the Cache : {0} " + size);
            Console.WriteLine(cache.Count);
            Console.WriteLine(count);
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory After Caching: {0}", GC.GetTotalMemory(false));
            
            Console.WriteLine("----------------------------LedgerAccountTypes------------------------------------------"); 
            con.Close();
            #endregion
            
            #region LedgerAccounts
            con.Open();
            Console.WriteLine("----------------------------LedgerAccounts------------------------------------------"); 
            sql = $"SELECT * FROM public.\"LedgerAccounts\"";
            using var cmd4 = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader rdr4 = cmd4.ExecuteReader();
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory before cache: {0}", GC.GetTotalMemory(false));
            
            //var cache = new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions());

            while (rdr4.Read())
            {
                //Console.WriteLine("{0} {1}", rdr.GetString(0), rdr.GetString(1));
                cache.Set(rdr4.GetString(0), rdr4.GetString(1));
                count++;
            }

            //Console.WriteLine("Size of the Cache : {0} " + size);
            Console.WriteLine(cache.Count);
            Console.WriteLine(count);
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory After Caching: {0}", GC.GetTotalMemory(false));
            
            Console.WriteLine("----------------------------LedgerAccounts------------------------------------------"); 
            con.Close();
            #endregion
            
            #region CounterpartyTypes
            con.Open();
            Console.WriteLine("----------------------------CounterpartyTypes------------------------------------------"); 
            sql = $"SELECT * FROM public.\"CounterpartyTypes\"";
            using var cmd5 = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader rdr5 = cmd5.ExecuteReader();
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory before cache: {0}", GC.GetTotalMemory(false));
            
            //var cache = new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions());

            while (rdr5.Read())
            {
                //Console.WriteLine("{0} {1}", rdr.GetString(0), rdr.GetString(1));
                cache.Set(rdr5.GetString(0), rdr5.GetString(1));
                count++;
            }

            //Console.WriteLine("Size of the Cache : {0} " + size);
            Console.WriteLine(cache.Count);
            Console.WriteLine(count);
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory After Caching: {0}", GC.GetTotalMemory(false));
            
            Console.WriteLine("----------------------------CounterpartyTypes------------------------------------------"); 
            con.Close();
            #endregion
            
            #region ControlAccounts
            con.Open();
            Console.WriteLine("----------------------------ControlAccounts------------------------------------------"); 
            sql = $"SELECT * FROM public.\"ControlAccounts\"";
            using var cmd6 = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader rdr6 = cmd6.ExecuteReader();
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory before cache: {0}", GC.GetTotalMemory(false));
            
            //var cache = new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions());

            while (rdr6.Read())
            {
                //Console.WriteLine("{0} {1}", rdr.GetString(0), rdr.GetString(1));
                cache.Set(rdr6.GetString(0), rdr6.GetString(1));
                count++;
            }

            //Console.WriteLine("Size of the Cache : {0} " + size);
            Console.WriteLine(cache.Count);
            Console.WriteLine(count);
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory After Caching: {0}", GC.GetTotalMemory(false));
            
            Console.WriteLine("----------------------------ControlAccounts------------------------------------------"); 
            con.Close();
            #endregion
            
            #region Counterparties
            con.Open();
            Console.WriteLine("----------------------------Counterparties------------------------------------------"); 
            sql = $"SELECT * FROM public.\"Counterparties\"";
            using var cmd7 = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader rdr7 = cmd7.ExecuteReader();
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory before cache: {0}", GC.GetTotalMemory(false));
            
            //var cache = new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions());

            while (rdr7.Read())
            {
                //Console.WriteLine("{0} {1}", rdr.GetString(0), rdr.GetString(1));
                cache.Set(rdr7.GetString(0), rdr7.GetString(1));
                count++;
            }

            //Console.WriteLine("Size of the Cache : {0} " + size);
            Console.WriteLine(cache.Count);
            Console.WriteLine(count);
            
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            
            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory After Caching: {0}", GC.GetTotalMemory(false));
            
            Console.WriteLine("----------------------------Counterparties------------------------------------------"); 
            con.Close();
            #endregion
            
        }
    }
}