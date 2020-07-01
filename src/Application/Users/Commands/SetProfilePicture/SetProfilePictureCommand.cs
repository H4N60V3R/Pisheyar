using MediatR;
using Microsoft.EntityFrameworkCore;
using Pisheyar.Application.Common.Interfaces;
using Pisheyar.Domain.Entities;
using Pisheyar.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pisheyar.Application.Users.Commands.SetProfilePicture
{
    public class SetProfilePictureCommand : IRequest<SetProfilePictureVm>
    {
        public string ProfileDocumentGuid { get; set; }

        public class SetProfilePictureCommandHandler : IRequestHandler<SetProfilePictureCommand, SetProfilePictureVm>
        {
            private readonly IPishePlusContext _context;
            private readonly ICurrentUserService _currentUser;

            public SetProfilePictureCommandHandler(IPishePlusContext context, ICurrentUserService currentUserService)
            {
                _context = context;
                _currentUser = currentUserService;
            }

            public async Task<SetProfilePictureVm> Handle(SetProfilePictureCommand request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                   .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                   .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new SetProfilePictureVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)SetProfilePictureState.UserNotFound
                };

                Document profileDocument = await _context.Document
                    .SingleOrDefaultAsync(x => x.DocumentGuid == Guid.Parse(request.ProfileDocumentGuid), cancellationToken);

                if (profileDocument == null) return new SetProfilePictureVm()
                {
                    Message = "تصویر پروفایل کاربر مورد نظر یافت نشد",
                    State = (int)SetProfilePictureState.ProfileDocumentNotFound
                };

                currentUser.ProfileDocumentId = profileDocument.DocumentId;
                currentUser.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return new SetProfilePictureVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)SetProfilePictureState.Success
                };
            }
        }
    }
}
