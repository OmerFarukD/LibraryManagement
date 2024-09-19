﻿namespace LibraryManagement.ConsoleUI.Models.Dtos;

public record BookDetailDto(
    int Id,
    string CategoryName,
    string Title,
    string Description,
    int PageSize,
    string PublishDate,
    string ISBN
    );