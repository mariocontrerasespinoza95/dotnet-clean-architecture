﻿namespace Application.Exceptions;
public sealed record ValidationError(string PropertName, string ErrorMessage);
