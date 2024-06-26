﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppData.FPhoneDbContexts;
using AppData.IServices;
using AppData.Models;
using AppData.Utilities;
using AppData.ViewModels.Options;

namespace AppData.Services
{
    public class BlogService :IBlogService
    {
        private FPhoneDbContext _context;

        public BlogService(FPhoneDbContext context)
        {
            _context = context;
        }
        public BlogEntity Add(BlogEntity obj)
        {
            var data = new BlogEntity();
            try
            {
                BeanUtils.CopyAllPropertySameName(obj,data);
                _context.Blogs.Add(data);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                    
            }

            return data;
        }

        public BlogEntity Update(BlogEntity obj)
        {
            var data = _context.Blogs.FirstOrDefault(c => c.Id == obj.Id);
            try
            {
                BeanUtils.CopyAllPropertySameName(obj,data);
                _context.Blogs.Update(data);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

            }

            return data;
        }

        public BlogEntity Delete(Guid id)
        {
            var data = _context.Blogs.FirstOrDefault(c => c.Id == id);
            try
            {
                _context.Blogs.Remove(data);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                
            }

            return data;
        }

        public BlogEntity Details(Guid id)
        {
            return _context.Blogs.FirstOrDefault(c => c.Id == id);
        }

        public List<BlogEntity> GetAll(BlogEntity searchData, ListOptions listOptions)
        {
            var lst = new List<BlogEntity>();
            try
            {
                lst = _context.Blogs.Where(c => searchData == null ||
                                                (searchData.Title == null || c.Title.Contains(searchData.Title)) &&
                                                (searchData.Status == null || c.Status.Equals(searchData.Status))
                ).OrderByDescending(c =>c.CreatedDate).Skip(listOptions.SkipCalc).Take(listOptions.PageSize).ToList();

                listOptions.AllRecordCount = _context.Blogs.Count(c => searchData == null ||
                                                                       (searchData.Title == null ||
                                                                        c.Title.Contains(searchData.Title)) &&
                                                                       (searchData.Status == null ||
                                                                        c.Status.Equals(searchData.Status)));
            }
            catch (Exception e)
            {
            }

            return lst;
        }
    }
}
