﻿using Sirius.Domain.Entities;
using Sirius.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sirius.Domain.Mapper
{
    /// <summary>
    /// Mapeamento do contrato inteligente
    /// </summary>
    public static class SmartContractMapper
    {
        public static SmartContractModel ToSmartContractModel(this SmartContractEntity smartContractEntity) =>
            new SmartContractModel(smartContractEntity.Id
                , smartContractEntity.Title
                , smartContractEntity.Description
                , smartContractEntity.TerminationCondition
                , smartContractEntity.ConclusionCondition
                , smartContractEntity.Value
                , smartContractEntity.CompanyEntity == null ? null : new CompanyModel(smartContractEntity.CompanyEntity.Id, smartContractEntity.CompanyEntity.Name
                    , smartContractEntity.CompanyEntity.Nickname, smartContractEntity.CompanyEntity.CNPJ
                    , smartContractEntity.CompanyEntity.Phone, smartContractEntity.CompanyEntity.Email
                    , null
                    , null, smartContractEntity.CompanyEntity.CreatedOn, smartContractEntity.CompanyEntity.UpdatedOn
                    , smartContractEntity.CompanyEntity.Deleted, smartContractEntity.CompanyEntity.Blocked));

        public static IEnumerable<SmartContractModel> ToSmartContractModel(this IEnumerable<SmartContractEntity> smartContractEntities) =>
            smartContractEntities.Select(s => s.ToSmartContractModel())?.ToList();

        public static SmartContractEntity ToSmartContractEntity(this SmartContractModel smartContractModel) =>
            new SmartContractEntity()
            {
                Id = smartContractModel.Id,
                CompanyEntity = smartContractModel.CompanyModel?.ToCompanyEntity(),
                ConclusionCondition = smartContractModel.ConclusionCondition,
                Description = smartContractModel.Description,
                TerminationCondition = smartContractModel.TerminationCondition,
                Title = smartContractModel.Title,
                Value = smartContractModel.Value
            };

        public static IEnumerable<SmartContractEntity> ToSmartContractEntity(this ICollection<SmartContractModel> smartContractModels) =>
            smartContractModels.Select(s => s.ToSmartContractEntity());

        public static SmartContractEntity ToSmartContractEntity(this CreateSmartContractModel smartContractModel) =>
            new SmartContractEntity()
            {
                Id = smartContractModel.Id,
                CompanyEntity = smartContractModel.CompanyModel?.ToCompanyEntity(),
                ConclusionCondition = smartContractModel.ConclusionCondition,
                Description = smartContractModel.Description,
                TerminationCondition = smartContractModel.TerminationCondition,
                Title = smartContractModel.Title,
                Value = smartContractModel.Value,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                Deleted = false,
                Inactived = false, 
                CurrentCompanyEntityId = smartContractModel.Id
            };

        public static SmartContractEntity ToSmartContractEntity(this UpdateSmartContractModel smartContractModel) =>
            new SmartContractEntity()
            {
                Id = smartContractModel.Id,
                CompanyEntity = smartContractModel.CompanyModel?.ToCompanyEntity(),
                ConclusionCondition = smartContractModel.ConclusionCondition,
                Description = smartContractModel.Description,
                TerminationCondition = smartContractModel.TerminationCondition,
                Title = smartContractModel.Title,
                Value = smartContractModel.Value,
                CreatedOn = DateTime.Now,
                UpdatedOn = smartContractModel.UpdatedOn,
                Deleted = smartContractModel.Deleted,
                Inactived = smartContractModel.Inactived
            };
    }
}
