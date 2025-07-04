using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProductApi.Models;

namespace ProductApi.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<account> accounts { get; set; }

    public virtual DbSet<account_buff> account_buffs { get; set; }

    public virtual DbSet<account_cash_shop_gift> account_cash_shop_gifts { get; set; }

    public virtual DbSet<account_cash_shop_item> account_cash_shop_items { get; set; }

    public virtual DbSet<account_datum> account_data { get; set; }

    public virtual DbSet<account_warehouse> account_warehouses { get; set; }

    public virtual DbSet<accounts_allowed> accounts_alloweds { get; set; }

    public virtual DbSet<accounts_banned> accounts_banneds { get; set; }

    public virtual DbSet<accounts_disconnect> accounts_disconnects { get; set; }

    public virtual DbSet<accounts_security> accounts_securities { get; set; }

    public virtual DbSet<accounts_status> accounts_statuses { get; set; }

    public virtual DbSet<accounts_validation> accounts_validations { get; set; }

    public virtual DbSet<accounts_warning> accounts_warnings { get; set; }

    public virtual DbSet<arka_war_datum> arka_war_data { get; set; }

    public virtual DbSet<block_diskserial> block_diskserials { get; set; }

    public virtual DbSet<block_ip> block_ips { get; set; }

    public virtual DbSet<block_mac> block_macs { get; set; }

    public virtual DbSet<castle_siege_datum> castle_siege_data { get; set; }

    public virtual DbSet<castle_siege_guild> castle_siege_guilds { get; set; }

    public virtual DbSet<castle_siege_npc> castle_siege_npcs { get; set; }

    public virtual DbSet<castle_siege_registered_guild> castle_siege_registered_guilds { get; set; }

    public virtual DbSet<chaos_castle_survival_hall_of_fame> chaos_castle_survival_hall_of_fames { get; set; }

    public virtual DbSet<chaos_castle_survival_ranking> chaos_castle_survival_rankings { get; set; }

    public virtual DbSet<character_add_stat> character_add_stats { get; set; }

    public virtual DbSet<character_buff> character_buffs { get; set; }

    public virtual DbSet<character_chat_block> character_chat_blocks { get; set; }

    public virtual DbSet<character_date> character_dates { get; set; }

    public virtual DbSet<character_deleted> character_deleteds { get; set; }

    public virtual DbSet<character_event_count> character_event_counts { get; set; }

    public virtual DbSet<character_friend> character_friends { get; set; }

    public virtual DbSet<character_gameoption> character_gameoptions { get; set; }

    public virtual DbSet<character_gen> character_gens { get; set; }

    public virtual DbSet<character_gens_kill> character_gens_kills { get; set; }

    public virtual DbSet<character_gremory_case> character_gremory_cases { get; set; }

    public virtual DbSet<character_helper> character_helpers { get; set; }

    public virtual DbSet<character_hunting_record> character_hunting_records { get; set; }

    public virtual DbSet<character_info> character_infos { get; set; }

    public virtual DbSet<character_item_delay> character_item_delays { get; set; }

    public virtual DbSet<character_item_inventory> character_item_inventories { get; set; }

    public virtual DbSet<character_item_pentagram> character_item_pentagrams { get; set; }

    public virtual DbSet<character_jewel_bingo> character_jewel_bingos { get; set; }

    public virtual DbSet<character_jewel_bingo_grid> character_jewel_bingo_grids { get; set; }

    public virtual DbSet<character_kick> character_kicks { get; set; }

    public virtual DbSet<character_labyrinth> character_labyrinths { get; set; }

    public virtual DbSet<character_labyrinth_level> character_labyrinth_levels { get; set; }

    public virtual DbSet<character_labyrinth_zone> character_labyrinth_zones { get; set; }

    public virtual DbSet<character_mail> character_mails { get; set; }

    public virtual DbSet<character_majestic_stat> character_majestic_stats { get; set; }

    public virtual DbSet<character_majestic_tree> character_majestic_trees { get; set; }

    public virtual DbSet<character_mini_bomb> character_mini_bombs { get; set; }

    public virtual DbSet<character_mini_bomb_grid> character_mini_bomb_grids { get; set; }

    public virtual DbSet<character_monster_soul> character_monster_souls { get; set; }

    public virtual DbSet<character_mu_roomy> character_mu_roomies { get; set; }

    public virtual DbSet<character_mu_roomy_deck> character_mu_roomy_decks { get; set; }

    public virtual DbSet<character_mupass> character_mupasses { get; set; }

    public virtual DbSet<character_notification> character_notifications { get; set; }

    public virtual DbSet<character_numeric_baseball> character_numeric_baseballs { get; set; }

    public virtual DbSet<character_quest_evo> character_quest_evos { get; set; }

    public virtual DbSet<character_quest_guided> character_quest_guideds { get; set; }

    public virtual DbSet<character_quest_mu> character_quest_mus { get; set; }

    public virtual DbSet<character_restriction> character_restrictions { get; set; }

    public virtual DbSet<character_score> character_scores { get; set; }

    public virtual DbSet<character_skill> character_skills { get; set; }

    public virtual DbSet<character_statistic> character_statistics { get; set; }

    public virtual DbSet<character_warp_favorite_list> character_warp_favorite_lists { get; set; }

    public virtual DbSet<crywolf_datum> crywolf_data { get; set; }

    public virtual DbSet<event_arka_war_kill> event_arka_war_kills { get; set; }

    public virtual DbSet<event_arka_war_ranking> event_arka_war_rankings { get; set; }

    public virtual DbSet<event_castle_siege_kill> event_castle_siege_kills { get; set; }

    public virtual DbSet<event_castle_siege_ranking> event_castle_siege_rankings { get; set; }

    public virtual DbSet<event_castle_siege_time> event_castle_siege_times { get; set; }

    public virtual DbSet<event_dungeon_instance> event_dungeon_instances { get; set; }

    public virtual DbSet<event_jewel_bingo_ranking> event_jewel_bingo_rankings { get; set; }

    public virtual DbSet<event_labyrinth_league> event_labyrinth_leagues { get; set; }

    public virtual DbSet<event_labyrinth_schedule> event_labyrinth_schedules { get; set; }

    public virtual DbSet<event_mini_bomb_ranking> event_mini_bomb_rankings { get; set; }

    public virtual DbSet<event_mu_roomy_ranking> event_mu_roomy_rankings { get; set; }

    public virtual DbSet<event_numeric_baseball_ranking> event_numeric_baseball_rankings { get; set; }

    public virtual DbSet<event_race_ranking> event_race_rankings { get; set; }

    public virtual DbSet<event_ranking> event_rankings { get; set; }

    public virtual DbSet<event_ranking_labyrinth> event_ranking_labyrinths { get; set; }

    public virtual DbSet<event_scramble_ranking> event_scramble_rankings { get; set; }

    public virtual DbSet<event_stage> event_stages { get; set; }

    public virtual DbSet<gen_ranking> gen_rankings { get; set; }

    public virtual DbSet<giant_mount_setting> giant_mount_settings { get; set; }

    public virtual DbSet<guild_list> guild_lists { get; set; }

    public virtual DbSet<guild_matching> guild_matchings { get; set; }

    public virtual DbSet<guild_member> guild_members { get; set; }

    public virtual DbSet<guild_score> guild_scores { get; set; }

    public virtual DbSet<item_recovery> item_recoveries { get; set; }

    public virtual DbSet<item_serial> item_serials { get; set; }

    public virtual DbSet<lo_de> lo_des { get; set; }

    public virtual DbSet<master_pc> master_pcs { get; set; }

    public virtual DbSet<migration> migrations { get; set; }

    public virtual DbSet<monster_respawn> monster_respawns { get; set; }

    public virtual DbSet<party> parties { get; set; }

    public virtual DbSet<party_member> party_members { get; set; }

    public virtual DbSet<personal_access_token> personal_access_tokens { get; set; }

    public virtual DbSet<serial_check> serial_checks { get; set; }

    public virtual DbSet<server_monster_soul_reset> server_monster_soul_resets { get; set; }

    public virtual DbSet<server_ranking> server_rankings { get; set; }

    public virtual DbSet<server_signal> server_signals { get; set; }

    public virtual DbSet<tormented_square_survival_hall_of_fame> tormented_square_survival_hall_of_fames { get; set; }

    public virtual DbSet<tormented_square_survival_ranking> tormented_square_survival_rankings { get; set; }

    public virtual DbSet<tormented_square_survival_team> tormented_square_survival_teams { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<account>(entity =>
        {
            entity.HasKey(e => e.guid).HasName("PRIMARY");

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guid).HasColumnType("int(10) unsigned");
            entity.Property(e => e.DiscordAvatar).HasMaxLength(255);
            entity.Property(e => e.DiscordDiscriminator).HasColumnType("int(11)");
            entity.Property(e => e.DiscordEmail).HasMaxLength(255);
            entity.Property(e => e.DiscordId).HasColumnType("int(11)");
            entity.Property(e => e.DiscordLogin)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.DiscordUsername).HasMaxLength(255);
            entity.Property(e => e.account1)
                .HasMaxLength(255)
                .HasColumnName("account");
            entity.Property(e => e.activated)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ban_time)
                .ValueGeneratedOnAddOrUpdate()
                .HasColumnType("datetime");
            entity.Property(e => e.blocked)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.create_date).HasColumnType("datetime");
            entity.Property(e => e.created_at).HasColumnType("datetime");
            entity.Property(e => e.deletion_token)
                .HasMaxLength(40)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.email).HasMaxLength(255);
            entity.Property(e => e.email_token)
                .HasMaxLength(40)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.email_verified_at).HasColumnType("datetime");
            entity.Property(e => e.facebook_status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.golden_channel)
                .HasDefaultValueSql("'1500434821'")
                .HasColumnType("bigint(20)");
            entity.Property(e => e.ip).HasMaxLength(20);
            entity.Property(e => e.lock_token).HasMaxLength(40);
            entity.Property(e => e.new_email)
                .HasMaxLength(64)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.passlost_token)
                .HasMaxLength(40)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.password).HasMaxLength(255);
            entity.Property(e => e.register).HasColumnType("bigint(20)");
            entity.Property(e => e.registration_token).HasMaxLength(40);
            entity.Property(e => e.secured)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.security_code)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.social_id)
                .HasMaxLength(13)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.token).HasMaxLength(50);
            entity.Property(e => e.updated_at).HasColumnType("datetime");
            entity.Property(e => e.web_admin)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
        });

        modelBuilder.Entity<account_buff>(entity =>
        {
            entity.HasKey(e => new { e.account_id, e.buff })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("account_buff")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.buff).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.duration).HasColumnType("bigint(20)");
            entity.Property(e => e.effect_1).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.effect_2).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.effect_3).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.flags).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.value_1).HasColumnType("int(11)");
            entity.Property(e => e.value_2).HasColumnType("int(11)");
            entity.Property(e => e.value_3).HasColumnType("int(11)");
        });

        modelBuilder.Entity<account_cash_shop_gift>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("account_cash_shop_gift")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
            entity.Property(e => e.option).HasColumnType("int(10) unsigned");
            entity.Property(e => e.product).HasColumnType("int(10) unsigned");
            entity.Property(e => e.serial).HasColumnType("int(10) unsigned");
            entity.Property(e => e.serial_cash_shop).HasColumnType("int(10) unsigned");
            entity.Property(e => e.server).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<account_cash_shop_item>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("account_cash_shop_item")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
            entity.Property(e => e.gift).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.option).HasColumnType("int(10) unsigned");
            entity.Property(e => e.product).HasColumnType("int(10) unsigned");
            entity.Property(e => e.serial).HasColumnType("int(10) unsigned");
            entity.Property(e => e.serial_cash_shop).HasColumnType("int(10) unsigned");
            entity.Property(e => e.server).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<account_datum>(entity =>
        {
            entity.HasKey(e => e.account_id).HasName("PRIMARY");

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.cash_shop_discount_date).HasColumnType("bigint(20)");
            entity.Property(e => e.cash_shop_discount_gp).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.cash_shop_discount_wc).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.credits).HasColumnType("int(10) unsigned");
            entity.Property(e => e.current_character).HasColumnType("int(10) unsigned");
            entity.Property(e => e.current_diskserial).HasColumnType("int(10) unsigned");
            entity.Property(e => e.current_ip).HasMaxLength(16);
            entity.Property(e => e.current_mac).HasMaxLength(50);
            entity.Property(e => e.current_server).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.current_type).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.expanded_warehouse).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.expanded_warehouse_time).HasColumnType("bigint(20)");
            entity.Property(e => e.goblin_points).HasColumnType("int(11)");
            entity.Property(e => e.special_character).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.vip_duration).HasColumnType("bigint(20)");
            entity.Property(e => e.vip_status)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.web_credits).HasColumnType("int(10) unsigned");
        });

        modelBuilder.Entity<account_warehouse>(entity =>
        {
            entity.HasKey(e => e.account_id).HasName("PRIMARY");

            entity
                .ToTable("account_warehouse")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.gremory_case_acc).HasColumnType("varbinary(10000)");
            entity.Property(e => e.inventory).HasColumnType("varbinary(55000)");
            entity.Property(e => e.money).HasColumnType("int(10) unsigned");
            entity.Property(e => e.password).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.wingcoreinventory).HasColumnType("text");
        });

        modelBuilder.Entity<accounts_allowed>(entity =>
        {
            entity.HasKey(e => e.account_id).HasName("PRIMARY");

            entity
                .ToTable("accounts_allowed")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.guid).HasColumnType("int(10) unsigned");
            entity.Property(e => e.server).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<accounts_banned>(entity =>
        {
            entity.HasKey(e => e.account_id).HasName("PRIMARY");

            entity
                .ToTable("accounts_banned")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.guid).HasColumnType("int(10) unsigned");
            entity.Property(e => e.unban_date).HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<accounts_disconnect>(entity =>
        {
            entity.HasKey(e => e.account_id).HasName("PRIMARY");

            entity
                .ToTable("accounts_disconnect")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.masive).HasColumnType("tinyint(4)");
            entity.Property(e => e.server).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<accounts_security>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("accounts_security")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account).HasMaxLength(255);
            entity.Property(e => e.account_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.disk_serial).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ip).HasMaxLength(16);
            entity.Property(e => e.mac).HasMaxLength(50);
        });

        modelBuilder.Entity<accounts_status>(entity =>
        {
            entity.HasKey(e => e.account_id).HasName("PRIMARY");

            entity
                .ToTable("accounts_status")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.current_server).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.dest_server).HasColumnType("smallint(6)");
            entity.Property(e => e.dest_world).HasColumnType("smallint(6)");
            entity.Property(e => e.dest_x).HasColumnType("smallint(6)");
            entity.Property(e => e.dest_y).HasColumnType("smallint(6)");
            entity.Property(e => e.disk_serial).HasColumnType("int(10) unsigned");
            entity.Property(e => e.last_ip).HasMaxLength(16);
            entity.Property(e => e.last_mac).HasMaxLength(50);
            entity.Property(e => e.last_online).HasMaxLength(255);
            entity.Property(e => e.online).HasColumnType("tinyint(4)");
            entity.Property(e => e.server_group).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.start_server).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.warp_auth_1).HasColumnType("int(10) unsigned");
            entity.Property(e => e.warp_auth_2).HasColumnType("int(10) unsigned");
            entity.Property(e => e.warp_auth_3).HasColumnType("int(10) unsigned");
            entity.Property(e => e.warp_auth_4).HasColumnType("int(10) unsigned");
            entity.Property(e => e.warp_time).HasColumnType("int(10) unsigned");
        });

        modelBuilder.Entity<accounts_validation>(entity =>
        {
            entity.HasKey(e => e.account_id).HasName("PRIMARY");

            entity
                .ToTable("accounts_validation")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.disk_serial).HasColumnType("int(10) unsigned");
        });

        modelBuilder.Entity<accounts_warning>(entity =>
        {
            entity.HasKey(e => e.account_id).HasName("PRIMARY");

            entity
                .ToTable("accounts_warning")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.block_date).HasColumnType("bigint(20)");
            entity.Property(e => e.disk_serial).HasColumnType("int(10) unsigned");
        });

        modelBuilder.Entity<arka_war_datum>(entity =>
        {
            entity.HasKey(e => new { e.id, e.guild })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.id).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.guild).HasColumnType("int(10) unsigned");
            entity.Property(e => e.attribute).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<block_diskserial>(entity =>
        {
            entity.HasKey(e => e.disk_serial).HasName("PRIMARY");

            entity
                .ToTable("block_diskserial")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.disk_serial)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.comment).HasMaxLength(255);
        });

        modelBuilder.Entity<block_ip>(entity =>
        {
            entity.HasKey(e => e.ip).HasName("PRIMARY");

            entity
                .ToTable("block_ip")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.ip).HasMaxLength(16);
            entity.Property(e => e.comment).HasMaxLength(255);
        });

        modelBuilder.Entity<block_mac>(entity =>
        {
            entity.HasKey(e => e.mac).HasName("PRIMARY");

            entity
                .ToTable("block_mac")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.mac).HasMaxLength(50);
            entity.Property(e => e.comment).HasMaxLength(255);
        });

        modelBuilder.Entity<castle_siege_datum>(entity =>
        {
            entity.HasKey(e => e.owner).HasName("PRIMARY");

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.owner)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.hunt_allowed).HasColumnType("tinyint(4)");
            entity.Property(e => e.money).HasColumnType("bigint(20) unsigned");
            entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.tax_chaos).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.tax_hunt).HasColumnType("int(11)");
            entity.Property(e => e.tax_store).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<castle_siege_guild>(entity =>
        {
            entity.HasKey(e => new { e.guild, e.side })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("castle_siege_guild")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guild).HasColumnType("int(10) unsigned");
            entity.Property(e => e.side).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.score).HasColumnType("int(11)");
        });

        modelBuilder.Entity<castle_siege_npc>(entity =>
        {
            entity.HasKey(e => e.uid).HasName("PRIMARY");

            entity
                .ToTable("castle_siege_npc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.uid).HasColumnType("bigint(20)");
            entity.Property(e => e.defense_level).HasColumnType("smallint(6)");
            entity.Property(e => e.id).HasColumnType("smallint(6)");
            entity.Property(e => e.life).HasColumnType("int(11)");
            entity.Property(e => e.life_level).HasColumnType("smallint(6)");
            entity.Property(e => e.npc).HasColumnType("smallint(6)");
            entity.Property(e => e.regen_level).HasColumnType("smallint(6)");
        });

        modelBuilder.Entity<castle_siege_registered_guild>(entity =>
        {
            entity.HasKey(e => e.guild).HasName("PRIMARY");

            entity
                .ToTable("castle_siege_registered_guild")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guild)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.level).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.level_master).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.marks).HasColumnType("int(10) unsigned");
            entity.Property(e => e.register_id).HasColumnType("int(10) unsigned");
        });

        modelBuilder.Entity<chaos_castle_survival_hall_of_fame>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("chaos_castle_survival_hall_of_fame")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.char_name).HasMaxLength(255);
            entity.Property(e => e.score).HasColumnType("int(11)");
        });

        modelBuilder.Entity<chaos_castle_survival_ranking>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("chaos_castle_survival_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.score).HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<character_add_stat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("character_add_stat")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Agility).HasColumnType("int(11)");
            entity.Property(e => e.Energy).HasColumnType("int(11)");
            entity.Property(e => e.GUID).HasColumnType("int(11)");
            entity.Property(e => e.Leadership).HasColumnType("int(11)");
            entity.Property(e => e.Strenght).HasColumnType("int(11)");
            entity.Property(e => e.Vitality).HasColumnType("int(11)");
        });

        modelBuilder.Entity<character_buff>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.buff })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("character_buff")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.buff).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.duration).HasColumnType("bigint(20)");
            entity.Property(e => e.effect_1).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.effect_2).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.effect_3).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.flags).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.value_1).HasColumnType("int(11)");
            entity.Property(e => e.value_2).HasColumnType("int(11)");
            entity.Property(e => e.value_3).HasColumnType("int(11)");
        });

        modelBuilder.Entity<character_chat_block>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_chat_block")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.blocked).HasMaxLength(255);
        });

        modelBuilder.Entity<character_date>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("character_date")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<character_deleted>(entity =>
        {
            entity.HasKey(e => new { e.account_id, e.char_id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("character_deleted")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.name).HasMaxLength(255);
        });

        modelBuilder.Entity<character_event_count>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.event_id, e.day })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("character_event_count")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.event_id).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.day).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.count).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_friend>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.friend_name })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("character_friend")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
        });

        modelBuilder.Entity<character_gameoption>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_gameoption")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.additional_options).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.button_bind_1).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.button_bind_2).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.button_bind_3).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.button_bind_4).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.button_bind_5).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.change_skin).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.chat_window).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.e_key).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.extra_data).HasColumnType("bigint(20) unsigned");
            entity.Property(e => e.game_option).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.q_key).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.qwer_level).HasColumnType("int(11)");
            entity.Property(e => e.r_key).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.skill_bind_0).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.skill_bind_1).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.skill_bind_2).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.skill_bind_3).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.skill_bind_4).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.skill_bind_5).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.skill_bind_6).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.skill_bind_7).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.skill_bind_8).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.skill_bind_9).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.w_key).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_gen>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.family })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.family).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.contribution).HasColumnType("int(11)");
            entity.Property(e => e.join_date).HasColumnType("bigint(20)");
            entity.Property(e => e.left_date).HasColumnType("bigint(20)");
            entity.Property(e => e.level).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.reward_date).HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<character_gens_kill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("character_gens_kill")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.count).HasColumnType("int(10) unsigned");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
            entity.Property(e => e.killed_id).HasColumnType("int(10) unsigned");
        });

        modelBuilder.Entity<character_gremory_case>(entity =>
        {
            entity.HasKey(e => e.guid).HasName("PRIMARY");

            entity
                .ToTable("character_gremory_case")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guid)
                .ValueGeneratedNever()
                .HasColumnType("int(11)");
            entity.Property(e => e.gremory_case_char).HasColumnType("varbinary(20000)");
            entity.Property(e => e.gremory_case_mobile).HasColumnType("varbinary(20000)");
            entity.Property(e => e.gremory_case_ps).HasColumnType("varbinary(20000)");
        });

        modelBuilder.Entity<character_helper>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_helper")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.attack_sec_delay_1).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.attack_sec_delay_2).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.attack_sec_skill_1).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.attack_sec_skill_2).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.attack_skill_1).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.buff_item_1).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.buff_item_2).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.buff_item_3).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.buff_skill_1).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.buff_skill_2).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.buff_skill_3).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.buff_skill_4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.buff_skill_5)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.buff_skill_6)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.distance).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.hunting_range).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.item_list).HasMaxLength(255);
            entity.Property(e => e.item_pick_flag).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.item_pick_range).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.option_flag_1).HasColumnType("int(10) unsigned");
            entity.Property(e => e.option_flag_2).HasColumnType("int(10) unsigned");
            entity.Property(e => e.percent_autoheal).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.percent_autopot).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.percent_drainlife).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.percent_partyheal).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.time_space_casting).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<character_hunting_record>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.world })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("character_hunting_record")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.world).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.damage).HasColumnType("bigint(20) unsigned");
            entity.Property(e => e.day).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.duration).HasColumnType("int(10) unsigned");
            entity.Property(e => e.earned_experience).HasColumnType("bigint(20) unsigned");
            entity.Property(e => e.elemental_damage).HasColumnType("bigint(20) unsigned");
            entity.Property(e => e.healing).HasColumnType("int(10) unsigned");
            entity.Property(e => e.killed_count).HasColumnType("int(10) unsigned");
            entity.Property(e => e.level).HasColumnType("int(10) unsigned");
            entity.Property(e => e.month).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.year).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<character_info>(entity =>
        {
            entity.HasKey(e => e.guid).HasName("PRIMARY");

            entity
                .ToTable("character_info")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guid).HasColumnType("int(10) unsigned");
            entity.Property(e => e.account_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.add_fruit_points)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.admin_flags)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.agility)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.authority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.create_date)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)");
            entity.Property(e => e.dec_fruit_points)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.direction)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.energy)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.expanded_inventory)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.experience)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)");
            entity.Property(e => e.experience_majestic)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)");
            entity.Property(e => e.experience_master)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)");
            entity.Property(e => e.first_time)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.hunting_log_visible)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.kick_time)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)");
            entity.Property(e => e.last_use)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)");
            entity.Property(e => e.lastserver)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.leadership)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.level)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.level_majestic)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.level_master)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.life)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.mana)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.money)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.monster_soul_purchase)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.mute_time)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)");
            entity.Property(e => e.name).HasMaxLength(255);
            entity.Property(e => e.online)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.personal_store_name)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.personal_store_open)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.pk_count)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.pk_level)
                .HasDefaultValueSql("'3'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.pk_points)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.points)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.points_majestic)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.points_master)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.post_count)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.post_day)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.post_month)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.race).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.reset)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.ruud_money)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.santa_claus_gift)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)");
            entity.Property(e => e.server_code)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.shield)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.slot)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.stamina)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.strength)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.vitality)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.world)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.world_x)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.world_y)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
        });

        modelBuilder.Entity<character_item_delay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("character_item_delay")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
            entity.Property(e => e.item).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<character_item_inventory>(entity =>
        {
            entity.HasKey(e => e.GUID).HasName("PRIMARY");

            entity
                .ToTable("character_item_inventory")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.GUID)
                .ValueGeneratedNever()
                .HasColumnType("int(11)");
            entity.Property(e => e.InventoryData).HasColumnType("varbinary(65525)");
        });

        modelBuilder.Entity<character_item_pentagram>(entity =>
        {
            entity.HasKey(e => new { e.GUID, e.INV_TYPE })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("character_item_pentagram")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.GUID).HasColumnType("int(11)");
            entity.Property(e => e.INV_TYPE).HasColumnType("smallint(6)");
            entity.Property(e => e.PentagramInventoryData).HasColumnType("varbinary(65525)");
        });

        modelBuilder.Entity<character_jewel_bingo>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_jewel_bingo")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.box).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.count).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
            entity.Property(e => e.jewel).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.score1).HasColumnType("int(11)");
            entity.Property(e => e.score2).HasColumnType("int(11)");
            entity.Property(e => e.score3).HasColumnType("int(11)");
            entity.Property(e => e.state).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_jewel_bingo_grid>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_jewel_bingo_grid")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.slot).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.value).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_kick>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_kick")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.character_name).HasMaxLength(255);
        });

        modelBuilder.Entity<character_labyrinth>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_labyrinth")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.completed_missions).HasColumnType("int(11)");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
            entity.Property(e => e.day_first).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.earned_experience).HasColumnType("bigint(20)");
            entity.Property(e => e.goblin_state).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.id).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.killed_monsters).HasColumnType("int(11)");
            entity.Property(e => e.level).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.stage).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_labyrinth_level>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_labyrinth_level")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.amount).HasColumnType("int(11)");
            entity.Property(e => e.level).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<character_labyrinth_zone>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.idx, e.subidx })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("character_labyrinth_zone")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.idx).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.subidx).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.mission_count_1).HasColumnType("int(11)");
            entity.Property(e => e.mission_count_2).HasColumnType("int(11)");
            entity.Property(e => e.mission_count_3).HasColumnType("int(11)");
            entity.Property(e => e.mission_count_4).HasColumnType("int(11)");
            entity.Property(e => e.mission_count_5).HasColumnType("int(11)");
            entity.Property(e => e.mission_id_1).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.mission_id_2).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.mission_id_3).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.mission_id_4).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.mission_id_5).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_mail>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .ToTable("character_mail")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.action).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
            entity.Property(e => e.direction).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.from_id).HasMaxLength(255);
            entity.Property(e => e.message).HasMaxLength(255);
            entity.Property(e => e.opened).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.photo).HasMaxLength(255);
            entity.Property(e => e.subject).HasMaxLength(255);
            entity.Property(e => e.window_guid).HasColumnType("int(10) unsigned");
        });

        modelBuilder.Entity<character_majestic_stat>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.id).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.level).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<character_majestic_tree>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("character_majestic_tree")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.id).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.level).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.section).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_mini_bomb>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_mini_bomb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.cdate).HasColumnType("bigint(20)");
            entity.Property(e => e.score).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.state).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.total_score).HasColumnType("int(11)");
        });

        modelBuilder.Entity<character_mini_bomb_grid>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_mini_bomb_grid")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.cell).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.value).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_monster_soul>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("character_monster_soul")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.amount).HasColumnType("int(11)");
            entity.Property(e => e.type).HasColumnType("int(10) unsigned");
        });

        modelBuilder.Entity<character_mu_roomy>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_mu_roomy")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.card_count).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
            entity.Property(e => e.playing).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.score).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.special_card_count).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_mu_roomy_deck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("character_mu_roomy_deck")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.color).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.number).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.play_slot).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.slot).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.state).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_mupass>(entity =>
        {
            entity.HasKey(e => e.guid).HasName("PRIMARY");

            entity
                .ToTable("character_mupass")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guid).HasColumnType("bigint(20)");
            entity.Property(e => e.TodayMuPassExp).HasColumnType("int(11)");
            entity.Property(e => e.character_id).HasColumnType("bigint(20)");
            entity.Property(e => e.pass_data).HasColumnType("varbinary(30000)");
            entity.Property(e => e.pass_exp).HasColumnType("bigint(20)");
            entity.Property(e => e.pass_level).HasColumnType("int(11)");
            entity.Property(e => e.pass_reward_data).HasColumnType("varbinary(30000)");
            entity.Property(e => e.ticketCount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<character_notification>(entity =>
        {
            entity.HasKey(e => e.server_group).HasName("PRIMARY");

            entity
                .ToTable("character_notification")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.server_group)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.char_name).HasMaxLength(45);
            entity.Property(e => e.facebook_id).HasMaxLength(45);
            entity.Property(e => e.notification_data).HasMaxLength(45);
            entity.Property(e => e.notification_id).HasMaxLength(45);
        });

        modelBuilder.Entity<character_numeric_baseball>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_numeric_baseball")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.balls).HasMaxLength(255);
            entity.Property(e => e.number_1).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.number_2).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.number_3).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.numbers).HasMaxLength(255);
            entity.Property(e => e.score).HasColumnType("int(11)");
            entity.Property(e => e.state).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.strikes).HasMaxLength(255);
        });

        modelBuilder.Entity<character_quest_evo>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("character_quest_evo")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.id).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.kill_count_1).HasColumnType("int(11)");
            entity.Property(e => e.kill_count_2).HasColumnType("int(11)");
            entity.Property(e => e.kill_count_3).HasColumnType("int(11)");
            entity.Property(e => e.kill_count_4).HasColumnType("int(11)");
            entity.Property(e => e.kill_count_5).HasColumnType("int(11)");
            entity.Property(e => e.state).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_quest_guided>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("character_quest_guided")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.quest).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.count).HasColumnType("int(11)");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
            entity.Property(e => e.state).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_quest_mu>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.quest_id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("character_quest_mu")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.quest_id).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
            entity.Property(e => e.objective).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.state).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_restriction>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_restriction")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.admin_name).HasMaxLength(255);
            entity.Property(e => e.reason).HasMaxLength(255);
            entity.Property(e => e.restriction).HasColumnType("int(10) unsigned");
            entity.Property(e => e.time).HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<character_score>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("character_score")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.level).HasColumnType("int(11)");
            entity.Property(e => e.score).HasColumnType("int(11)");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_skill>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.type, e.skill })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("character_skill")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.skill).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.skill_level).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<character_statistic>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.statistic_id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.statistic_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.count).HasColumnType("bigint(20) unsigned");
        });

        modelBuilder.Entity<character_warp_favorite_list>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("character_warp_favorite_list")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.data).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.slot).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.warp_id).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<crywolf_datum>(entity =>
        {
            entity.HasKey(e => e.state).HasName("PRIMARY");

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.state).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<event_arka_war_kill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("event_arka_war_kill")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.char_name).HasMaxLength(255);
            entity.Property(e => e.char_rank).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.guild_id_01).HasColumnType("int(10) unsigned");
            entity.Property(e => e.guild_id_02).HasColumnType("int(10) unsigned");
            entity.Property(e => e.guild_name_01).HasMaxLength(255);
            entity.Property(e => e.guild_name_02).HasMaxLength(255);
            entity.Property(e => e.killer_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.killer_name).HasMaxLength(255);
            entity.Property(e => e.killer_rank).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.player_data_01).HasMaxLength(255);
            entity.Property(e => e.player_data_02).HasMaxLength(255);
            entity.Property(e => e.world).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.world_x).HasColumnType("smallint(6)");
            entity.Property(e => e.world_y).HasColumnType("smallint(6)");
        });

        modelBuilder.Entity<event_arka_war_ranking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("event_arka_war_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.character_count).HasColumnType("int(11)");
            entity.Property(e => e.guild_id_01).HasColumnType("int(10) unsigned");
            entity.Property(e => e.guild_id_02).HasColumnType("int(10) unsigned");
            entity.Property(e => e.guild_name_01).HasMaxLength(255);
            entity.Property(e => e.guild_name_02).HasMaxLength(255);
        });

        modelBuilder.Entity<event_castle_siege_kill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("event_castle_siege_kill")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.char_name).HasMaxLength(255);
            entity.Property(e => e.char_rank).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.guild_id_01).HasColumnType("int(10) unsigned");
            entity.Property(e => e.guild_id_02).HasColumnType("int(10) unsigned");
            entity.Property(e => e.guild_name_01).HasMaxLength(255);
            entity.Property(e => e.guild_name_02).HasMaxLength(255);
            entity.Property(e => e.killer_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.killer_name).HasMaxLength(255);
            entity.Property(e => e.killer_rank).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.player_data_01).HasMaxLength(255);
            entity.Property(e => e.player_data_02).HasMaxLength(255);
            entity.Property(e => e.state).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.world).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.world_x).HasColumnType("smallint(6)");
            entity.Property(e => e.world_y).HasColumnType("smallint(6)");
        });

        modelBuilder.Entity<event_castle_siege_ranking>(entity =>
        {
            entity.HasKey(e => e.guild_id).HasName("PRIMARY");

            entity
                .ToTable("event_castle_siege_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guild_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.character_count).HasColumnType("int(11)");
            entity.Property(e => e.guild_name).HasMaxLength(255);
        });

        modelBuilder.Entity<event_castle_siege_time>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("event_castle_siege_time")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.char_name).HasMaxLength(255);
            entity.Property(e => e.char_rank).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.guild_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.guild_name).HasMaxLength(255);
            entity.Property(e => e.player_data).HasMaxLength(255);
            entity.Property(e => e.time).HasColumnType("int(10) unsigned");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<event_dungeon_instance>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("event_dungeon_instance")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.id).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.time).HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<event_jewel_bingo_ranking>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("event_jewel_bingo_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.score1).HasColumnType("int(11)");
            entity.Property(e => e.score2).HasColumnType("int(11)");
            entity.Property(e => e.score3).HasColumnType("int(11)");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<event_labyrinth_league>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.category })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("event_labyrinth_league")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.category).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.char_class).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.char_name).HasMaxLength(255);
            entity.Property(e => e.league_score).HasColumnType("int(11)");
            entity.Property(e => e.score).HasColumnType("int(11)");
            entity.Property(e => e.time).HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<event_labyrinth_schedule>(entity =>
        {
            entity.HasKey(e => e.server).HasName("PRIMARY");

            entity
                .ToTable("event_labyrinth_schedule")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.server)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.start_date).HasColumnType("bigint(20)");
            entity.Property(e => e.state).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<event_mini_bomb_ranking>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("event_mini_bomb_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.bombs_failed).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.bombs_founded).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.score).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.state).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<event_mu_roomy_ranking>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("event_mu_roomy_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.remain_card).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.remain_special_card).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.score).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<event_numeric_baseball_ranking>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("event_numeric_baseball_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.score).HasColumnType("int(11)");
        });

        modelBuilder.Entity<event_race_ranking>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.race })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("event_race_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.start).HasMaxLength(255);
        });

        modelBuilder.Entity<event_ranking>(entity =>
        {
            entity.HasKey(e => new { e.event_id, e.char_id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("event_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.event_id).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.event_ground).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.score).HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<event_ranking_labyrinth>(entity =>
        {
            entity.HasKey(e => e.char_id).HasName("PRIMARY");

            entity
                .ToTable("event_ranking_labyrinth")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.completed_missions).HasColumnType("int(11)");
            entity.Property(e => e.earned_experience).HasColumnType("bigint(20)");
            entity.Property(e => e.index).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.killed_monsters).HasColumnType("int(11)");
            entity.Property(e => e.level).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.score).HasColumnType("int(11)");
            entity.Property(e => e.stage).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<event_scramble_ranking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("event_scramble_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.shuffle_word).HasMaxLength(255);
            entity.Property(e => e.word).HasMaxLength(255);
        });

        modelBuilder.Entity<event_stage>(entity =>
        {
            entity.HasKey(e => e.event_id).HasName("PRIMARY");

            entity
                .ToTable("event_stage")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.event_id).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.stage).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<gen_ranking>(entity =>
        {
            entity.HasKey(e => new { e.family, e.char_id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("gen_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.family).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.level).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.ranking).HasColumnType("int(11)");
            entity.Property(e => e.score).HasColumnType("int(11)");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<giant_mount_setting>(entity =>
        {
            entity.HasKey(e => e.character_id).HasName("PRIMARY");

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.character_id)
                .ValueGeneratedNever()
                .HasColumnType("bigint(20)");
            entity.Property(e => e.giant_model).HasColumnType("smallint(6)");
            entity.Property(e => e.giant_status).HasColumnType("smallint(6)");
        });

        modelBuilder.Entity<guild_list>(entity =>
        {
            entity.HasKey(e => e.guid).HasName("PRIMARY");

            entity
                .ToTable("guild_list")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.alliance).HasColumnType("int(10) unsigned");
            entity.Property(e => e.emblem).HasMaxLength(255);
            entity.Property(e => e.hostil).HasColumnType("int(10) unsigned");
            entity.Property(e => e.name).HasMaxLength(255);
            entity.Property(e => e.notice).HasMaxLength(255);
            entity.Property(e => e.score).HasColumnType("int(11)");
        });

        modelBuilder.Entity<guild_matching>(entity =>
        {
            entity.HasKey(e => e.guild_id).HasName("PRIMARY");

            entity
                .ToTable("guild_matching")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guild_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.MaxLevel).HasColumnType("int(11)");
            entity.Property(e => e.MinLevel).HasColumnType("int(11)");
            entity.Property(e => e.board_number).HasColumnType("int(10) unsigned");
            entity.Property(e => e.class_type).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.interest_type).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.introduction_text).HasMaxLength(255);
            entity.Property(e => e.level_range).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.text).HasMaxLength(255);
        });

        modelBuilder.Entity<guild_member>(entity =>
        {
            entity.HasKey(e => new { e.guild_id, e.char_id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guild_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.id).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.ranking).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<guild_score>(entity =>
        {
            entity.HasKey(e => e.guild_id).HasName("PRIMARY");

            entity
                .ToTable("guild_score")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guild_id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.score).HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<item_recovery>(entity =>
        {
            entity.HasKey(e => new { e.char_id, e.item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("item_recovery")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.item).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.ancient).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.data_1).HasColumnType("int(11)");
            entity.Property(e => e.data_2).HasColumnType("int(11)");
            entity.Property(e => e.data_3).HasColumnType("int(11)");
            entity.Property(e => e.durability).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.excellent).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.flags).HasColumnType("int(10) unsigned");
            entity.Property(e => e.harmony).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.level).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.luck).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.option).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.option_380).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.serial).HasColumnType("int(10) unsigned");
            entity.Property(e => e.serial_cash_shop).HasColumnType("int(10) unsigned");
            entity.Property(e => e.serial_server).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.skill).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.socket_1).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.socket_2).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.socket_3).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.socket_4).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.socket_5).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.socket_bonus).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<item_serial>(entity =>
        {
            entity.HasKey(e => e.server).HasName("PRIMARY");

            entity
                .ToTable("item_serial")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.server)
                .ValueGeneratedNever()
                .HasColumnType("int(11)");
            entity.Property(e => e.serial).HasColumnType("bigint(20)");
            entity.Property(e => e.serial_shop).HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<lo_de>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .ToTable("lo_de")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.account_id).HasColumnType("int(11)");
            entity.Property(e => e.bet_item).HasColumnType("int(11)");
            entity.Property(e => e.bet_number).HasColumnType("int(11)");
            entity.Property(e => e.bet_time).HasMaxLength(6);
            entity.Property(e => e.bet_type).HasColumnType("int(11)");
            entity.Property(e => e.bet_value).HasColumnType("int(11)");
            entity.Property(e => e.char_id).HasColumnType("int(11)");
            entity.Property(e => e.reward_status).HasColumnType("int(11)");
            entity.Property(e => e.reward_value_x).HasColumnType("int(11)");
        });

        modelBuilder.Entity<master_pc>(entity =>
        {
            entity.HasKey(e => e.disk_serial).HasName("PRIMARY");

            entity
                .ToTable("master_pc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.disk_serial)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.mac).HasMaxLength(50);
        });

        modelBuilder.Entity<migration>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.batch).HasColumnType("int(11)");
            entity.Property(e => e.migration1)
                .HasMaxLength(255)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<monster_respawn>(entity =>
        {
            entity.HasKey(e => new { e.server, e.guid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("monster_respawn")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.server).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.guid).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.date).HasColumnType("bigint(20)");
        });

        modelBuilder.Entity<party>(entity =>
        {
            entity.HasKey(e => e.guid).HasName("PRIMARY");

            entity
                .ToTable("party")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.server).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<party_member>(entity =>
        {
            entity.HasKey(e => e.member).HasName("PRIMARY");

            entity
                .ToTable("party_member")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.member)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.party).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.position).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.server).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<personal_access_token>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.token, "personal_access_tokens_token_unique").IsUnique();

            entity.HasIndex(e => new { e.tokenable_type, e.tokenable_id }, "personal_access_tokens_tokenable_type_tokenable_id_index");

            entity.Property(e => e.id).HasColumnType("bigint(20) unsigned");
            entity.Property(e => e.abilities).HasColumnType("text");
            entity.Property(e => e.created_at).HasColumnType("timestamp");
            entity.Property(e => e.last_used_at).HasColumnType("timestamp");
            entity.Property(e => e.name).HasMaxLength(255);
            entity.Property(e => e.token).HasMaxLength(64);
            entity.Property(e => e.tokenable_id).HasColumnType("bigint(20) unsigned");
            entity.Property(e => e.updated_at).HasColumnType("timestamp");
        });

        modelBuilder.Entity<serial_check>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("serial_check")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.account_id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.disk_serial).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ip).HasMaxLength(16);
            entity.Property(e => e.mac).HasMaxLength(50);
            entity.Property(e => e.serial).HasColumnType("int(10) unsigned");
            entity.Property(e => e.server).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<server_monster_soul_reset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("server_monster_soul_reset")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.monster_soul_reset)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
        });

        modelBuilder.Entity<server_ranking>(entity =>
        {
            entity.HasKey(e => e.guid).HasName("PRIMARY");

            entity
                .ToTable("server_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.guid)
                .ValueGeneratedNever()
                .HasColumnType("int(11)");
            entity.Property(e => e.level_majestic).HasColumnType("int(11)");
            entity.Property(e => e.level_master).HasColumnType("int(11)");
            entity.Property(e => e.level_normal).HasColumnType("int(11)");
            entity.Property(e => e.race).HasColumnType("int(11)");
            entity.Property(e => e.reset).HasColumnType("int(11)");
            entity.Property(e => e.update_time).HasMaxLength(6);
        });

        modelBuilder.Entity<server_signal>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .ToTable("server_signal")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.data_1).HasColumnType("int(11)");
            entity.Property(e => e.data_2).HasColumnType("int(11)");
            entity.Property(e => e.data_3).HasColumnType("int(11)");
            entity.Property(e => e.server).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.signal).HasColumnType("smallint(5) unsigned");
        });

        modelBuilder.Entity<tormented_square_survival_hall_of_fame>(entity =>
        {
            entity.HasKey(e => e.char_id_1).HasName("PRIMARY");

            entity
                .ToTable("tormented_square_survival_hall_of_fame")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id_1)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.char_id_2).HasColumnType("int(10) unsigned");
            entity.Property(e => e.char_name_1).HasMaxLength(255);
            entity.Property(e => e.char_name_2).HasMaxLength(255);
            entity.Property(e => e.score).HasColumnType("int(11)");
        });

        modelBuilder.Entity<tormented_square_survival_ranking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tormented_square_survival_ranking")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id_1).HasColumnType("int(10) unsigned");
            entity.Property(e => e.char_id_2).HasColumnType("int(10) unsigned");
            entity.Property(e => e.char_name_1).HasMaxLength(255);
            entity.Property(e => e.char_name_2).HasMaxLength(255);
            entity.Property(e => e.ranking).HasColumnType("int(11)");
            entity.Property(e => e.score).HasColumnType("int(11)");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<tormented_square_survival_team>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tormented_square_survival_team")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.char_id_1).HasColumnType("int(10) unsigned");
            entity.Property(e => e.char_id_2).HasColumnType("int(10) unsigned");
            entity.Property(e => e.enter_count).HasColumnType("int(11)");
            entity.Property(e => e.score).HasColumnType("int(11)");
            entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
