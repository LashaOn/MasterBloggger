﻿using System;

namespace MB.Domain.ArticleAgg.Services
{
    public class ArticleValidatorService : IArticleValidatorService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleValidatorService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void CheckArticleEntityDuplicated(string title)
        {
            if (_articleRepository.Exist(x=>x.Title==title))
                throw new DuplicateWaitObjectException(title);
        }
    }
}