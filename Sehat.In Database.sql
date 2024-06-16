PGDMP      *                |            DB_PBO    16.3    16.3 \    J           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            K           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            L           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            M           1262    172185    DB_PBO    DATABASE     �   CREATE DATABASE "DB_PBO" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Indonesian_Indonesia.1252';
    DROP DATABASE "DB_PBO";
                postgres    false            �            1259    196784    artikel    TABLE     �   CREATE TABLE public.artikel (
    id_artikel integer NOT NULL,
    judul character varying(256) NOT NULL,
    sumber character varying(256) NOT NULL,
    id_penyakit integer NOT NULL
);
    DROP TABLE public.artikel;
       public         heap    postgres    false            �            1259    196782    artikel_id_artikel_seq    SEQUENCE     �   CREATE SEQUENCE public.artikel_id_artikel_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.artikel_id_artikel_seq;
       public          postgres    false    233            N           0    0    artikel_id_artikel_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.artikel_id_artikel_seq OWNED BY public.artikel.id_artikel;
          public          postgres    false    231            �            1259    196783    artikel_id_penyakit_seq    SEQUENCE     �   CREATE SEQUENCE public.artikel_id_penyakit_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.artikel_id_penyakit_seq;
       public          postgres    false    233            O           0    0    artikel_id_penyakit_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.artikel_id_penyakit_seq OWNED BY public.artikel.id_penyakit;
          public          postgres    false    232            �            1259    172193    faskes    TABLE       CREATE TABLE public.faskes (
    id_faskes integer NOT NULL,
    nama_faskes character varying(256),
    alamat character varying(256),
    kota character varying(256),
    no_telfon numeric,
    website character varying(256),
    jam_operasional character varying(256)
);
    DROP TABLE public.faskes;
       public         heap    postgres    false            �            1259    172198    faskes_id_faskes_seq    SEQUENCE     �   CREATE SEQUENCE public.faskes_id_faskes_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.faskes_id_faskes_seq;
       public          postgres    false    215            P           0    0    faskes_id_faskes_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.faskes_id_faskes_seq OWNED BY public.faskes.id_faskes;
          public          postgres    false    216            �            1259    172199 
   jenis_obat    TABLE     d   CREATE TABLE public.jenis_obat (
    id_jenis integer NOT NULL,
    jenis character varying(256)
);
    DROP TABLE public.jenis_obat;
       public         heap    postgres    false            �            1259    172202    jenis_obat_id_jenis_seq    SEQUENCE     �   CREATE SEQUENCE public.jenis_obat_id_jenis_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.jenis_obat_id_jenis_seq;
       public          postgres    false    217            Q           0    0    jenis_obat_id_jenis_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.jenis_obat_id_jenis_seq OWNED BY public.jenis_obat.id_jenis;
          public          postgres    false    218            �            1259    172203    jenis_profil    TABLE     g   CREATE TABLE public.jenis_profil (
    id_jenis_profil integer NOT NULL,
    nama_jenis_profil text
);
     DROP TABLE public.jenis_profil;
       public         heap    postgres    false            �            1259    172208     jenis_profil_id_jenis_profil_seq    SEQUENCE     �   CREATE SEQUENCE public.jenis_profil_id_jenis_profil_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public.jenis_profil_id_jenis_profil_seq;
       public          postgres    false    219            R           0    0     jenis_profil_id_jenis_profil_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public.jenis_profil_id_jenis_profil_seq OWNED BY public.jenis_profil.id_jenis_profil;
          public          postgres    false    220            �            1259    172209    kalori_makanan    TABLE     �   CREATE TABLE public.kalori_makanan (
    id_makanan integer NOT NULL,
    nama_makanan character varying(256),
    kategori character varying(256),
    kandungan integer
);
 "   DROP TABLE public.kalori_makanan;
       public         heap    postgres    false            �            1259    172214    kalori_makanan_id_makanan_seq    SEQUENCE     �   CREATE SEQUENCE public.kalori_makanan_id_makanan_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public.kalori_makanan_id_makanan_seq;
       public          postgres    false    221            S           0    0    kalori_makanan_id_makanan_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public.kalori_makanan_id_makanan_seq OWNED BY public.kalori_makanan.id_makanan;
          public          postgres    false    222            �            1259    172296    keluhan    TABLE     �   CREATE TABLE public.keluhan (
    id_keluhan integer NOT NULL,
    detail_kritik character varying(255) NOT NULL,
    detail_saran character varying(255) NOT NULL,
    id_pelanggan integer NOT NULL
);
    DROP TABLE public.keluhan;
       public         heap    postgres    false            �            1259    172294    keluhan_id_keluhan_seq    SEQUENCE     �   CREATE SEQUENCE public.keluhan_id_keluhan_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.keluhan_id_keluhan_seq;
       public          postgres    false    230            T           0    0    keluhan_id_keluhan_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.keluhan_id_keluhan_seq OWNED BY public.keluhan.id_keluhan;
          public          postgres    false    228            �            1259    172295    keluhan_id_pelanggan_seq    SEQUENCE     �   CREATE SEQUENCE public.keluhan_id_pelanggan_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.keluhan_id_pelanggan_seq;
       public          postgres    false    230            U           0    0    keluhan_id_pelanggan_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.keluhan_id_pelanggan_seq OWNED BY public.keluhan.id_pelanggan;
          public          postgres    false    229            �            1259    196801    obat    TABLE     �   CREATE TABLE public.obat (
    id_obat integer NOT NULL,
    nama_obat character varying(64),
    fungsi character varying(256),
    dosis character varying(256),
    id_penyakit integer NOT NULL,
    id_jenis integer NOT NULL
);
    DROP TABLE public.obat;
       public         heap    postgres    false            �            1259    196800    obat_id_jenis_seq    SEQUENCE     �   CREATE SEQUENCE public.obat_id_jenis_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.obat_id_jenis_seq;
       public          postgres    false    237            V           0    0    obat_id_jenis_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.obat_id_jenis_seq OWNED BY public.obat.id_jenis;
          public          postgres    false    236            �            1259    196798    obat_id_obat_seq    SEQUENCE     �   CREATE SEQUENCE public.obat_id_obat_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.obat_id_obat_seq;
       public          postgres    false    237            W           0    0    obat_id_obat_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.obat_id_obat_seq OWNED BY public.obat.id_obat;
          public          postgres    false    234            �            1259    196799    obat_id_penyakit_seq    SEQUENCE     �   CREATE SEQUENCE public.obat_id_penyakit_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.obat_id_penyakit_seq;
       public          postgres    false    237            X           0    0    obat_id_penyakit_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.obat_id_penyakit_seq OWNED BY public.obat.id_penyakit;
          public          postgres    false    235            �            1259    172223    penyakit    TABLE     m   CREATE TABLE public.penyakit (
    id_penyakit integer NOT NULL,
    nama_penyakit character varying(256)
);
    DROP TABLE public.penyakit;
       public         heap    postgres    false            �            1259    172226    penyakit_id_penyakit_seq    SEQUENCE     �   CREATE SEQUENCE public.penyakit_id_penyakit_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.penyakit_id_penyakit_seq;
       public          postgres    false    223            Y           0    0    penyakit_id_penyakit_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.penyakit_id_penyakit_seq OWNED BY public.penyakit.id_penyakit;
          public          postgres    false    224            �            1259    172227    profil    TABLE     9  CREATE TABLE public.profil (
    id_profil integer NOT NULL,
    nama text,
    email character varying(256),
    password character varying(256),
    alamat character varying(256),
    kota character varying(256),
    negara character varying(256),
    no_telfon numeric,
    id_jenis_profil integer NOT NULL
);
    DROP TABLE public.profil;
       public         heap    postgres    false            �            1259    172232    profil_id_jenis_profil_seq    SEQUENCE     �   CREATE SEQUENCE public.profil_id_jenis_profil_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.profil_id_jenis_profil_seq;
       public          postgres    false    225            Z           0    0    profil_id_jenis_profil_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.profil_id_jenis_profil_seq OWNED BY public.profil.id_jenis_profil;
          public          postgres    false    226            �            1259    172233    profil_id_profil_seq    SEQUENCE     �   CREATE SEQUENCE public.profil_id_profil_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.profil_id_profil_seq;
       public          postgres    false    225            [           0    0    profil_id_profil_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.profil_id_profil_seq OWNED BY public.profil.id_profil;
          public          postgres    false    227            �           2604    196787    artikel id_artikel    DEFAULT     x   ALTER TABLE ONLY public.artikel ALTER COLUMN id_artikel SET DEFAULT nextval('public.artikel_id_artikel_seq'::regclass);
 A   ALTER TABLE public.artikel ALTER COLUMN id_artikel DROP DEFAULT;
       public          postgres    false    231    233    233            �           2604    196788    artikel id_penyakit    DEFAULT     z   ALTER TABLE ONLY public.artikel ALTER COLUMN id_penyakit SET DEFAULT nextval('public.artikel_id_penyakit_seq'::regclass);
 B   ALTER TABLE public.artikel ALTER COLUMN id_penyakit DROP DEFAULT;
       public          postgres    false    233    232    233            }           2604    172236    faskes id_faskes    DEFAULT     t   ALTER TABLE ONLY public.faskes ALTER COLUMN id_faskes SET DEFAULT nextval('public.faskes_id_faskes_seq'::regclass);
 ?   ALTER TABLE public.faskes ALTER COLUMN id_faskes DROP DEFAULT;
       public          postgres    false    216    215            ~           2604    172237    jenis_obat id_jenis    DEFAULT     z   ALTER TABLE ONLY public.jenis_obat ALTER COLUMN id_jenis SET DEFAULT nextval('public.jenis_obat_id_jenis_seq'::regclass);
 B   ALTER TABLE public.jenis_obat ALTER COLUMN id_jenis DROP DEFAULT;
       public          postgres    false    218    217                       2604    172238    jenis_profil id_jenis_profil    DEFAULT     �   ALTER TABLE ONLY public.jenis_profil ALTER COLUMN id_jenis_profil SET DEFAULT nextval('public.jenis_profil_id_jenis_profil_seq'::regclass);
 K   ALTER TABLE public.jenis_profil ALTER COLUMN id_jenis_profil DROP DEFAULT;
       public          postgres    false    220    219            �           2604    172239    kalori_makanan id_makanan    DEFAULT     �   ALTER TABLE ONLY public.kalori_makanan ALTER COLUMN id_makanan SET DEFAULT nextval('public.kalori_makanan_id_makanan_seq'::regclass);
 H   ALTER TABLE public.kalori_makanan ALTER COLUMN id_makanan DROP DEFAULT;
       public          postgres    false    222    221            �           2604    172299    keluhan id_keluhan    DEFAULT     x   ALTER TABLE ONLY public.keluhan ALTER COLUMN id_keluhan SET DEFAULT nextval('public.keluhan_id_keluhan_seq'::regclass);
 A   ALTER TABLE public.keluhan ALTER COLUMN id_keluhan DROP DEFAULT;
       public          postgres    false    230    228    230            �           2604    172300    keluhan id_pelanggan    DEFAULT     |   ALTER TABLE ONLY public.keluhan ALTER COLUMN id_pelanggan SET DEFAULT nextval('public.keluhan_id_pelanggan_seq'::regclass);
 C   ALTER TABLE public.keluhan ALTER COLUMN id_pelanggan DROP DEFAULT;
       public          postgres    false    229    230    230            �           2604    196804    obat id_obat    DEFAULT     l   ALTER TABLE ONLY public.obat ALTER COLUMN id_obat SET DEFAULT nextval('public.obat_id_obat_seq'::regclass);
 ;   ALTER TABLE public.obat ALTER COLUMN id_obat DROP DEFAULT;
       public          postgres    false    234    237    237            �           2604    196805    obat id_penyakit    DEFAULT     t   ALTER TABLE ONLY public.obat ALTER COLUMN id_penyakit SET DEFAULT nextval('public.obat_id_penyakit_seq'::regclass);
 ?   ALTER TABLE public.obat ALTER COLUMN id_penyakit DROP DEFAULT;
       public          postgres    false    237    235    237            �           2604    196806    obat id_jenis    DEFAULT     n   ALTER TABLE ONLY public.obat ALTER COLUMN id_jenis SET DEFAULT nextval('public.obat_id_jenis_seq'::regclass);
 <   ALTER TABLE public.obat ALTER COLUMN id_jenis DROP DEFAULT;
       public          postgres    false    236    237    237            �           2604    172243    penyakit id_penyakit    DEFAULT     |   ALTER TABLE ONLY public.penyakit ALTER COLUMN id_penyakit SET DEFAULT nextval('public.penyakit_id_penyakit_seq'::regclass);
 C   ALTER TABLE public.penyakit ALTER COLUMN id_penyakit DROP DEFAULT;
       public          postgres    false    224    223            �           2604    172244    profil id_profil    DEFAULT     t   ALTER TABLE ONLY public.profil ALTER COLUMN id_profil SET DEFAULT nextval('public.profil_id_profil_seq'::regclass);
 ?   ALTER TABLE public.profil ALTER COLUMN id_profil DROP DEFAULT;
       public          postgres    false    227    225            �           2604    172245    profil id_jenis_profil    DEFAULT     �   ALTER TABLE ONLY public.profil ALTER COLUMN id_jenis_profil SET DEFAULT nextval('public.profil_id_jenis_profil_seq'::regclass);
 E   ALTER TABLE public.profil ALTER COLUMN id_jenis_profil DROP DEFAULT;
       public          postgres    false    226    225            C          0    196784    artikel 
   TABLE DATA           I   COPY public.artikel (id_artikel, judul, sumber, id_penyakit) FROM stdin;
    public          postgres    false    233   di       1          0    172193    faskes 
   TABLE DATA           k   COPY public.faskes (id_faskes, nama_faskes, alamat, kota, no_telfon, website, jam_operasional) FROM stdin;
    public          postgres    false    215   �m       3          0    172199 
   jenis_obat 
   TABLE DATA           5   COPY public.jenis_obat (id_jenis, jenis) FROM stdin;
    public          postgres    false    217   �q       5          0    172203    jenis_profil 
   TABLE DATA           J   COPY public.jenis_profil (id_jenis_profil, nama_jenis_profil) FROM stdin;
    public          postgres    false    219   lr       7          0    172209    kalori_makanan 
   TABLE DATA           W   COPY public.kalori_makanan (id_makanan, nama_makanan, kategori, kandungan) FROM stdin;
    public          postgres    false    221   �r       @          0    172296    keluhan 
   TABLE DATA           X   COPY public.keluhan (id_keluhan, detail_kritik, detail_saran, id_pelanggan) FROM stdin;
    public          postgres    false    230   dt       G          0    196801    obat 
   TABLE DATA           X   COPY public.obat (id_obat, nama_obat, fungsi, dosis, id_penyakit, id_jenis) FROM stdin;
    public          postgres    false    237   u       9          0    172223    penyakit 
   TABLE DATA           >   COPY public.penyakit (id_penyakit, nama_penyakit) FROM stdin;
    public          postgres    false    223   y       ;          0    172227    profil 
   TABLE DATA           t   COPY public.profil (id_profil, nama, email, password, alamat, kota, negara, no_telfon, id_jenis_profil) FROM stdin;
    public          postgres    false    225   �y       \           0    0    artikel_id_artikel_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.artikel_id_artikel_seq', 15, true);
          public          postgres    false    231            ]           0    0    artikel_id_penyakit_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.artikel_id_penyakit_seq', 1, false);
          public          postgres    false    232            ^           0    0    faskes_id_faskes_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.faskes_id_faskes_seq', 17, true);
          public          postgres    false    216            _           0    0    jenis_obat_id_jenis_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.jenis_obat_id_jenis_seq', 7, true);
          public          postgres    false    218            `           0    0     jenis_profil_id_jenis_profil_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public.jenis_profil_id_jenis_profil_seq', 2, true);
          public          postgres    false    220            a           0    0    kalori_makanan_id_makanan_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public.kalori_makanan_id_makanan_seq', 42, true);
          public          postgres    false    222            b           0    0    keluhan_id_keluhan_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.keluhan_id_keluhan_seq', 2, true);
          public          postgres    false    228            c           0    0    keluhan_id_pelanggan_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.keluhan_id_pelanggan_seq', 1, false);
          public          postgres    false    229            d           0    0    obat_id_jenis_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.obat_id_jenis_seq', 1, false);
          public          postgres    false    236            e           0    0    obat_id_obat_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.obat_id_obat_seq', 20, true);
          public          postgres    false    234            f           0    0    obat_id_penyakit_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.obat_id_penyakit_seq', 1, false);
          public          postgres    false    235            g           0    0    penyakit_id_penyakit_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.penyakit_id_penyakit_seq', 20, true);
          public          postgres    false    224            h           0    0    profil_id_jenis_profil_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.profil_id_jenis_profil_seq', 1, false);
          public          postgres    false    226            i           0    0    profil_id_profil_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.profil_id_profil_seq', 13, true);
          public          postgres    false    227            �           2606    196790    artikel artikel_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.artikel
    ADD CONSTRAINT artikel_pkey PRIMARY KEY (id_artikel);
 >   ALTER TABLE ONLY public.artikel DROP CONSTRAINT artikel_pkey;
       public            postgres    false    233            �           2606    172249    faskes faskes_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.faskes
    ADD CONSTRAINT faskes_pkey PRIMARY KEY (id_faskes);
 <   ALTER TABLE ONLY public.faskes DROP CONSTRAINT faskes_pkey;
       public            postgres    false    215            �           2606    172251    jenis_obat jenis_obat_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.jenis_obat
    ADD CONSTRAINT jenis_obat_pkey PRIMARY KEY (id_jenis);
 D   ALTER TABLE ONLY public.jenis_obat DROP CONSTRAINT jenis_obat_pkey;
       public            postgres    false    217            �           2606    172253    jenis_profil jenis_profil_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.jenis_profil
    ADD CONSTRAINT jenis_profil_pkey PRIMARY KEY (id_jenis_profil);
 H   ALTER TABLE ONLY public.jenis_profil DROP CONSTRAINT jenis_profil_pkey;
       public            postgres    false    219            �           2606    172255 "   kalori_makanan kalori_makanan_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.kalori_makanan
    ADD CONSTRAINT kalori_makanan_pkey PRIMARY KEY (id_makanan);
 L   ALTER TABLE ONLY public.kalori_makanan DROP CONSTRAINT kalori_makanan_pkey;
       public            postgres    false    221            �           2606    172304    keluhan keluhan_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.keluhan
    ADD CONSTRAINT keluhan_pkey PRIMARY KEY (id_keluhan);
 >   ALTER TABLE ONLY public.keluhan DROP CONSTRAINT keluhan_pkey;
       public            postgres    false    230            �           2606    196810    obat obat_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.obat
    ADD CONSTRAINT obat_pkey PRIMARY KEY (id_obat);
 8   ALTER TABLE ONLY public.obat DROP CONSTRAINT obat_pkey;
       public            postgres    false    237            �           2606    172259    penyakit penyakit_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.penyakit
    ADD CONSTRAINT penyakit_pkey PRIMARY KEY (id_penyakit);
 @   ALTER TABLE ONLY public.penyakit DROP CONSTRAINT penyakit_pkey;
       public            postgres    false    223            �           2606    172261    profil profil_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.profil
    ADD CONSTRAINT profil_pkey PRIMARY KEY (id_profil);
 <   ALTER TABLE ONLY public.profil DROP CONSTRAINT profil_pkey;
       public            postgres    false    225            �           2606    196816    obat fk_jenis_obat    FK CONSTRAINT     �   ALTER TABLE ONLY public.obat
    ADD CONSTRAINT fk_jenis_obat FOREIGN KEY (id_jenis) REFERENCES public.jenis_obat(id_jenis) ON DELETE CASCADE;
 <   ALTER TABLE ONLY public.obat DROP CONSTRAINT fk_jenis_obat;
       public          postgres    false    217    4750    237            �           2606    172267    profil fk_jenis_profil    FK CONSTRAINT     �   ALTER TABLE ONLY public.profil
    ADD CONSTRAINT fk_jenis_profil FOREIGN KEY (id_jenis_profil) REFERENCES public.jenis_profil(id_jenis_profil) ON DELETE CASCADE;
 @   ALTER TABLE ONLY public.profil DROP CONSTRAINT fk_jenis_profil;
       public          postgres    false    225    4752    219            �           2606    196791    artikel fk_penyakit    FK CONSTRAINT     �   ALTER TABLE ONLY public.artikel
    ADD CONSTRAINT fk_penyakit FOREIGN KEY (id_penyakit) REFERENCES public.penyakit(id_penyakit) ON DELETE CASCADE;
 =   ALTER TABLE ONLY public.artikel DROP CONSTRAINT fk_penyakit;
       public          postgres    false    233    4756    223            �           2606    196811    obat fk_penyakit    FK CONSTRAINT     �   ALTER TABLE ONLY public.obat
    ADD CONSTRAINT fk_penyakit FOREIGN KEY (id_penyakit) REFERENCES public.penyakit(id_penyakit) ON DELETE CASCADE;
 :   ALTER TABLE ONLY public.obat DROP CONSTRAINT fk_penyakit;
       public          postgres    false    237    4756    223            �           2606    172305    keluhan fk_profil    FK CONSTRAINT     �   ALTER TABLE ONLY public.keluhan
    ADD CONSTRAINT fk_profil FOREIGN KEY (id_pelanggan) REFERENCES public.profil(id_profil) ON DELETE CASCADE;
 ;   ALTER TABLE ONLY public.keluhan DROP CONSTRAINT fk_profil;
       public          postgres    false    225    230    4758            C   {  x����n�6����`���ǎ�H6�d��(�A�
#��hQ� Rv�W�3��l�$=�d�FQt� �%r��9�$���_��
a�a�j֑.I��`$�;v�7Ԑf��;�-IfD3�Ia頲�3wQt<����4]o�&�C��R�S���Y�΢�jI������vg�l���4��	��O�Ap���=��0^�RhR�g��EA��B���Ytd��ff%Y�ײ�*A�V�z+7J�����n�˫�ިȬ�,\�\dQ({#�8V�A�~��࣒��n�+�����Vўz����:�i�@J^�x���m$u�j"�jq<QDi�㌧q���A�[B�MEJ9o5����(϶�����{��M���m��tpJ��p07�2x!3������}:�0+���,�����^�{G�C Q�E�� B��3���5;��y��/�-��o�s��l��69��T���f�ڴY^�����
|\ɚ����� �!	{w_a�A�#W��v�z���]���6X���^�~'Y�2�J_1�%K��d�LC�#�i�3��s�J(�Q��Y!�ِ�ܶs��_Ar�'e�'jB�^4݀"}m���X��A�B�?�2����r���!H���򆜊��i'q���m� ��v�s�E��ڹg� �|���7�;9}~$�0`'Ӳ=\9 ߘ��#z�a�A�K��J�e[��T��$�E>>�ϣaz$i�	����Y�a����{j�ί|�!�ΩL��K`������`�bҖ�	�O��0I��J���Ȝ��g۷���f́|�NH��^'�}�]#������P�a� R�\��\g-���]*�w�N�c"�����)Q�,�$�j��A:�A��8㿴0���g��G���q�zmَ-�,Y�c\8�=��>.wq�w<?;>H�0Y�[7#؏�E6~r�P��VBOmh��{�z��#2~;Wn�9�<mũ��2��GѠya��5�Ei���1K������*Ln���P��a!����Q
�#�ㅣ�O��?����%0�W�=I�c/p��G��~X⚃b��Eڴ����N�7A��­(���Q7Jn�=-V�2[��U>1�g��1�#c�|b�c>3�1�1w��̘���c����o:1�      1   �  x����r�HƯ�)�+*^&3�It�MiR������#-Нm`S����- ���+����w�`���OlC�|�ZTl-�Do]�쳤�=Ț
���������6E���~��"��k�a��|6�L��3Gw���K�G�H儃�=���Q�Z�)������nDJi���q6���M�@�! B櫀{g��ń�/Ӌ|h���R��HH�r���Yw݊x�����Wl�ij��1�H�,_���?�#o/M%��Ջ�|P�[:�[J���̇9F+�NY�f�x}���姚JbwMeö��K�}�Q(�o^���iFQ���T:ZE���JdNa����HEl/2�����DJȜs�ϡd��b��lP��<���~'�[ٰ���V�o�J�"uj^Czm��.�}U�
�le��U���R��F����0"�W/Z���89���}� ��O�����J���]g%��U�і�=bl�!�S�1��=H�~���u�:I3	�Rr����Vg>�ύ.ٳ�!Rq�S�[�[*	w,��p�+0ȟ�|�Wٗf�2�ky�č���c~[Uj#�H�=�0y�_�=�y`��Ȧ��e8��]c˰�\�6��y�޻�*կ���ұ��b� أNM��Tfd�n<��lL�+2��5�M�����"�T8��1o"a�#�,tK\z�ܼ��n=1�e�E����jK����گR��G�T�g�[ �E�%o.$���p`�Vb�V�2'��מ}�hح�y}�b�/RQ"0�7�7ݕ�O/|����?W���܇[4�`з��!;�I��&	�X�X=�V���o�;�g�\!�Q`���,�3��y�.��M�؟���3|N���-[:̛��Q&Jx�#rk�"vo\e���g����px�oX/�!_��H5�n1��R�_��:s�;������,��mS��m����";wƯ.7�ӨZ���>x���18�ko�����g���QG��������@�g -%�S���������n߷��d2��i�      3   _   x�M�K
�0��=���2n^�~�&�����M�33t�a��Dc΂f�v�6�0W������Q쉠���19��Z����-�d�J[h��^-|      5      x�3�tL����2�-N-����� 6��      7   �  x�eSˎ�0<wEn{�q�e/�bǼX���DfrA�����0�d-UYcC�7M�N��#L9m����1���zHW�K���([rIc�[�j�WJy��w�{��i�´��5|#iǜd�G�������Ԭ5u���Ʊ6TaNG�|ý��-UӐ�6�تr��o�C����ìўu	�U��V�+͡�Z O	!�� v\�h	�pB���`�&xz4��V�{|H>& Vc���@L���qh�)^�)��&��e�(��2���M	W-��0�c)i;dx�Fy6���7���f��{�,[E1��J�Ք�����/��e��1/�N��Nzl�T]�[J�_ֺ��/�:\�&P7P�X<�zolI��u�~qց[h�o�X�Y��$V�f{�9�y{=�rvjCS�qYv��;��$�_�U s�l��+�n��b��.��      @   �   x�]�=�0���>A����`edyQ��$��� ���L~���l��֦�HJ
�6�#y��V�	3M(�q�(��r�`ݭ�����	MUZ*�q���Ar���lO��D��MB��<�Tk�L�&�dTq�	y���C��y���#98=�yCX���>;k�.�W�      G   �  x�]U�r�8<��BGOD3��q�����؍��cN{)��Di�{�~S�v�4�PUfee���lc��t�iV�Mْ�5�0�"+��Z��ev�i%g��)Q�bW�/�=6J+�I��x�4xvj����G$�K���uv ���"�{Y;k�N�	���3w$�*Ϫ<�cw�@�� �_�{g�S��[����kd�GG����(��V~/'�a�F�@�s�{Q�n�#�Z�aS���I#K�aH��<ᅬم�d�����w� ��*{x��́Y�'>�� �m�ȁ3T� �1�S����j8N�����G~�g�v�ҳ�E���|A,�x+�MK���Xhp�D@��Me:��Ԡ��(�W�63P.���V=BR.fu�Qp��5�K%c��!�u�-��i�?!H�A�d|0�(����JQ��ģ��jm�XK�x�V,�4ʑ���X�y�Q�D�Y"�ZΜЏ>�F�g%4�/�[O���ޅ; �^�P��B�p;�ݨA���������L'�NaQ@�)v�:�i�?3��K5`�����ye�� ����l� �� �Y�I���SQ�lt֬`��E�\���Qu��ŀ^��Y�C.�b\� ���th��S��5�
Ѫ.� ̰Q�^��G�	���e����1e){��^aē3�D.�K�E���$S�!��R���fr_�>�/R�h��K����$�)X��7�+nē=��S�}��G��ay��Q������m�Pt�<\kL��7E�H���jţfF��]s>��HN��2o�_ʍ�����];孡��DGm�Vn@�t�����Py�[�|Q���Vi�ݿϙ�Ռ��zW��5�J�ZZq�t�t�� >�Itz������H�ގ�CƌM
�����~�~����_�le�1F�Ct�cCz#�������m�,-s�*��_������'!l9/_�Ɵ4��Z��!�����G�ϻ��?t|��      9   �   x�O�n�0�ɯ����G�b� A�.ʤ�eɠ��__��w�{��a���Z�w���Xkb
���̢Q\0��k�����`n�Ȗ�0n������d�/����ַ�pg'i�.�*�d�h�	E�������}{A"؍�ř5-�H%�ɶxg�{"��Տ����q�Y4'��ab�-4��*�vp
Q���0��v2�!T��<�r	����/���R�      ;   �  x��T�n�0}f�B?�·8�[�f�^4[�{al�fcK�bwH�~GN;8k�=���<$҃���3�@4^
�s]�Tg��;kͫ3u�{ܶg*�4�������0��(�g4��"���N�Vp�ռ� 0�o�|'Ar��.oJg��b�K6O��Okgi�m[ѵu��RWܰ�2��4�VY�f�jI�u>�q�B�8�S�tl����+�nD}��q�2ǫ@L�`H���%*+�h,9��D=��ID�ÁU�+5kmm�V*�~�puBj�t��fՅ>�SӶ�p�ӍX���ܻҠ�ō8H��h(�n��cHS�*14׮>!l�zF�7%�i�گ\ �n�%��;s����u �]�BԷ�`2���[�M[o[G����c���1ek��i#ĝ�D%폁��8�,F-�ӿ�*ŏ�I��N(��UV�\���^g�����9F�c?Z����\n����遌�W�L�ށ0�����~��=��P
��d4�����5+<����O�~�E��y�/z����Z�z5;��`�t{y,�Ew�	�)��5O-gx�t���Ū?�Z��I�s4na���)603nƮ�jʮ}�[��|⅞��n1$kQ׭3��n޴ɸ�;� mL�:dY��g�	�?��=P F�m�$�㏉z��J;Z��-4~�B9�< �e��     