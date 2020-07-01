using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisheyar.Application.Common.Interfaces;
using Pisheyar.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Pisheyar.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Pisheyar.Application.Accounts.Commands.RegisterClient;

namespace Pisheyar.Application.Contractors.Commands.CompleteContractorProfile
{
    public class CompleteContractorProfileCommand : IRequest<CompleteContractorProfileVm>
    {
        public string Address { get; set; }

        public string AboutMe { get; set; }

        public string Telephone { get; set; }

        public string Website { get; set; }

        public string Instagram { get; set; }

        public class RegisterContractorHandler : IRequestHandler<CompleteContractorProfileCommand, CompleteContractorProfileVm>
        {
            private readonly IPishePlusContext _context;
            private readonly ICurrentUserService _currentUser;

            public RegisterContractorHandler(IPishePlusContext context, ICurrentUserService currentUser)
            {
                _context = context;
                _currentUser = currentUser;
            }

            public async Task<CompleteContractorProfileVm> Handle(CompleteContractorProfileCommand request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new CompleteContractorProfileVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)CompleteContractorProfileState.UserNotFound
                };

                Contractor contractor = await _context.Contractor
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (contractor == null) return new CompleteContractorProfileVm()
                {
                    Message = "سرویس دهنده مورد نظر یافت نشد",
                    State = (int)CompleteContractorProfileState.ContractorNotFound
                };

                contractor.Address = request.Address;
                contractor.AboutMe = request.AboutMe;
                contractor.Telephone = request.Telephone;
                contractor.Website = request.Website;
                contractor.Instagram = request.Instagram;
                contractor.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return new CompleteContractorProfileVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)CompleteContractorProfileState.Success
                };
            }
        }
    }
}
