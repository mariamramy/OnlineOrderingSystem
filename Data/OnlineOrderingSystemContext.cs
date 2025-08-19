﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OnlineOrderingSystem.Data;

public partial class OnlineOrderingSystemContext : DbContext
{
    public OnlineOrderingSystemContext()
    {
    }

    public OnlineOrderingSystemContext(DbContextOptions<OnlineOrderingSystemContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-C9DIFIT;Database=OnlineOrderingSystem;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
