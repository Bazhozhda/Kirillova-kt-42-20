using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Database.Configurations
{
    public class DisciplinesConfiguration
    {
        private const string TableName = "cd_group";

        public void Configure(EntityTypeBuilder<Groups> builder)
        {
            //Задаем первичный ключ
            builder
                .HasKey(p => p.GroupsId)
                .HasName($"pk_{TableName}_group_id");

            //Для целочисленного первичного ключа задаем автогенерацию (к каждой новой записи будет добавлять +1)
            builder.Property(p => p.GroupsId)
                    .ValueGeneratedOnAdd();

            //Расписываем как будут называться колонки в БД, а так же их обязательность и тд
            builder.Property(p => p.GroupsId)
                .HasColumnName("group_id")
                .HasComment("Идентификатор записи группы");

            //HasComment добавит комментарий, который будет отображаться в СУБД (добавлять по желанию)
            builder.Property(p => p.GroupName)
                .IsRequired()
                .HasColumnName("c_group_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название группы");

            builder.Property(p => p.GroupSpecialization)
                .HasColumnName("c_group_specialization")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Специализация");

            builder.Property(p => p.GroupYear)
                .HasColumnName("c_group_year")
                .HasColumnType(ColumnType.Date)
                .HasComment("Год зачисления");

            builder.Property(p => p.GroupIsExist)
                .HasColumnName("c_group_is_exist")
                .HasColumnType(ColumnType.Bool)
                .HasComment("Статус удаления");

            builder.ToTable(TableName);
        }
}
