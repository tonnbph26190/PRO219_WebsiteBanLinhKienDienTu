﻿using AppBusiness.Model.Pagination;
using AppBusiness.Model.QueryModel;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.IRepositories
{
    public interface VirtualItemRepository
    {
        public Task<Pagination<VirtualItemEntity>> GetAllAsync(VirtualItemQueryModel virtualItemQueryModel);
        public Task<VirtualItemEntity> SaveAsync(VirtualItemEntity virtualItemEntity);
        public Task<VirtualItemEntity> PatchAsync(VirtualItemEntity virtualItemEntity);
        public Task<List<VirtualItemEntity>> SaveAsync(List<VirtualItemEntity> virtualItemEntities);
        public Task<VirtualItemEntity> FindAsync (Guid Id);
        public Task<VirtualItemEntity> DeleteAsync(Guid Id);
    }
}
