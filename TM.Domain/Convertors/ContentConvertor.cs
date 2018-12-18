using System;
using System.Collections.Generic;
using System.Text;
using TM.Domain.Entities;
using TM.DTO.Objects;

namespace TM.Domain.Convertors
{
    public static class ContentConvertor
    {
        public static ContentDto Convert(Content data)
        {
            return new ContentDto()
            {
                Id = data.Id,
                Type = data.Type,
                Value = data.Value,
                Header = data.Header,
                Subheader = data.Subheader,
                Order = data.Order,
                Year = data.Year,
                IsDeleted = data.IsDeleted
            };
        }

        public static Content Convert(ContentDto dto)
        {
            return new Content()
            {
                Id = dto.Id,
                Type = dto.Type,
                Value = dto.Value,
                Header = dto.Header,
                Subheader = dto.Subheader,
                Order = dto.Order,
                Year = dto.Year,
                IsDeleted = dto.IsDeleted
            };
        }
    }
}
