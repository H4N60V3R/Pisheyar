﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pisheyar.Application.Contractors.Commands.ChangeContractorCity;
using Pisheyar.Application.Contractors.Commands.CompleteContractorProfile;
using Pisheyar.Application.OrderRequests.Queries.GetContractorCategories;

namespace WebUI.Controllers
{
    [Authorize]
    public class ContractorController : ApiController
    {
        /// <summary>
        /// دریافت خدمات سرویس دهنده
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<ActionResult<GetContractorCategoriesVm>> GetCategories()
        {
            return await Mediator.Send(new GetContractorCategoriesQuery());
        }

        /// <summary>
        /// تغییر شهر
        /// </summary>
        /// <param name="command">اطلاعات شهر</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ActionResult<ChangeContractorCityVm>> ChangeCity(ChangeContractorCityCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// تکمیل پروفایل
        /// </summary>
        /// <param name="command">اطلاعات پروفایل</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ActionResult<CompleteContractorProfileVm>> CompleteProfile(CompleteContractorProfileCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}