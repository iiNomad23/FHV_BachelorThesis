﻿using Domain.ids;

namespace Domain.Repositories;

public interface ITestCaseRepository
{
    string NextIdentity();
    Task<TestCase> GetById(int id);
    Task<List<TestCase>> GetAll();
    Task Add(TestCase testCase);
    Task Update(TestCase testCase);
    Task Remove(string id);
}