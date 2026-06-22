### SC-1 — Policy and Procedures (Control)

This requirement is about making sure your organisation has clear, written rules for protecting its communications and systems, along with practical, step-by-step guidance for how people should follow those rules. Without this, different teams may work to different standards, important responsibilities may be missed, and the organisation may not meet legal and regulatory expectations—making it more exposed when something goes wrong, such as a serious incident, a failed audit, or a major system change.

To meet this expectation, the organisation must create, document, and share a system and communications protection policy. This policy must explain its purpose, what it applies to, who is responsible for what, how management supports it, how different parts of the organisation work together, and how the organisation will demonstrate compliance. It must also align with all relevant laws, directives, regulations, and internal guidance.

The Chief Information Security Officer must oversee producing, maintaining, and distributing the policy and the related procedures.

The policy must be reviewed and updated at least once every year, and also after major incidents, audit findings, legal changes, major changes to the organisation’s system design, or new regulatory requirements. The procedures must be reviewed and updated at least annually, and after specified changes such as changes in roles, changes to system settings, or changes to monitoring tools.

##### CISO-owned policy & procedures lifecycle with role-based dissemination

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define policy scope, structure, and SC-family mapping approach (baseline policy + optional mission/system supplements) | Compliance Manager | Enterprise | 16h | — |
| Draft organisation-level system & communications protection policy with approval-ready governance, roles, and explicit SC-family control coverage | Cyber Security Lead | Enterprise | 24h | — |
| Produce implementation-focused procedures for each SC-family control implemented (step-by-step, roles accountable, where procedures live) | Security Engineer | Enterprise | 56h | — |
| Establish joint security/privacy governance workflow (working group terms of reference, review/approval records, conflict resolution, sign-off gates) | Project Manager | Enterprise | 16h | — |
| Configure controlled document lifecycle in chosen repository (versioning, effective dates, approval records, auditable change log, retention) | Platform Engineer | Enterprise | 24h | £6,000 |
| Define dissemination targets and role-based distribution model (authoritative recipient lists for policy and procedures; ISSO/system owner coverage; IT ops recipients) | Operations Lead | Enterprise | 12h | — |
| Implement evidence capture for dissemination and annual/trigger-based updates (acknowledgements/access logs; review schedules; trigger event register) | Compliance Manager | Enterprise | 20h | — |
| Run initial annual review cycle setup and conduct first dissemination + training/awareness briefing for defined role groups | Service Delivery Manager | Enterprise | 20h | — |

| Total Estimated Effort | 188h | Total Estimated Cost | £6,000 |

###### Actions Required for Compliance

- [ ] Appoint the Chief Information Security Officer (CISO) as the official responsible for managing the system and communications security policy and procedures.
- [ ] Publish an organisation-wide policy for protecting systems and communications (and create system or mission add-ons only when required), mapped to the SC family controls that have been implemented.
- [ ] Draft implementation-focused procedures that explain how each policy or control is carried out, including the roles responsible for each procedure.
- [ ] Define and keep up to date the lists of people who should receive each type of document:  
- **Dissemination role lists** for policy recipients, including **information system security officers (ISSOs)** and **system owners**.  
- **Procedure role lists** for procedure recipients, including **security and privacy programme staff**, **ISSOs**, **system owners**, and relevant **information technology (IT) operations personnel**.
- [ ] Set governance for an annual review and update of the policy and procedures, and define what events will trigger updates, including: incidents or breaches, audit or assessment findings, legal or regulatory changes, major changes to the system architecture, changes to configurations or tools, and changes to roles and responsibilities.
- [ ] Set up controlled document lifecycle management, including version numbers, approval steps, effective dates, and an auditable record of all changes.
- [ ] Share the current policy and procedures with the assigned roles, and keep records showing they were shared and reviewed.


---

### SC-2 — Separation of System and User Functionality (Control)

This requirement is about keeping the features everyday users use—such as the screens and functions they access—clearly separate from the behind-the-scenes tools used to run and manage systems. This matters because if the same routes are used for both, a mistake or misuse by a user could potentially reach powerful management functions, which could result in unauthorised changes, service disruption, or exposure of sensitive information.

To meet this expectation, the organisation must decide and document how it will separate user functions from system management functions. This can be done through physical separation or logical separation, such as using different machines, separate operating environments, separate processing resources, separate network locations, or virtualised setups.

Where web-based administration is available, it must be separated from user pages. Administrators must use different ways of proving their identity than ordinary users, and additional access checks must be applied. Administrative interfaces should also be isolated so they are accessed from different domains or equivalent mechanisms.

The organisation must keep design documents, operating procedures, configuration records, a security plan describing the separation, and audit records showing the separation is implemented and maintained as intended.

##### Dual-plane user/admin architecture with isolated admin web access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define user-plane vs admin-plane partitioning model (components, endpoints, trust boundaries, data/control flows) and produce SC-2 mapping document | System Design Authority | Enterprise | 24h | — |
| Design and implement admin-plane infrastructure isolation (separate compute/OS instances or virtual environments) including baseline hardening and deployment topology | Infrastructure Lead | Enterprise | 40h | £18,000 |
| Implement network segmentation and deny-by-default routing/firewall rules (user-plane cannot reach admin-plane endpoints; explicit allow rules only) and validate with connectivity tests | DevOps Lead | Enterprise | 32h | £6,000 |
| Deploy admin web interfaces on isolated domains/subdomains with separate routing/WAF policies; update DNS, TLS, and ensure no shared session/cookie/auth endpoints with user web interfaces | Platform Engineer | Enterprise | 28h | £4,000 |
| Configure separate authentication and conditional access for admin vs user (distinct IdP app registrations/policies, phishing-resistant MFA for admins, step-up for sensitive actions) and implement admin session re-auth | IAM Engineer | Enterprise | 36h | £12,000 |
| Implement additional admin access controls (IP allowlisting/VPN/ZTNA integration, role-based authorisation restricted to privileged roles, and enforcement for sensitive admin actions) | Security Engineer | Enterprise | 24h | £5,000 |
| Produce audit-ready evidence pack and operational procedures (architecture diagrams, network rule exports, domain mapping, IdP policy evidence, admin access workflow, logging/retention checks) | Compliance Manager | Enterprise | 20h | — |
| Execute end-to-end validation and acceptance testing (reachability tests, auth separation tests, negative tests for user-to-admin access, and evidence sign-off against acceptance criteria) | Quality Assurance Lead | Enterprise | 16h | — |

**Total Estimated Effort:** 220h  
**Total Estimated Cost:** £45,000

###### Actions Required for Compliance

- [ ] Create a diagram showing how the user functions and the administrative functions are separated, and map all user and system management endpoints.
- [ ] Run administration (admin-plane) services on separate computer servers and operating systems (or in separate virtual environments) from the user services (user-plane).
- [ ] Set up “deny-by-default” network segmentation so that user network segments cannot access the management endpoints in the admin network segment.
- [ ] Run the host administration website on a separate domain (for example, `admin.example.com`) and apply separate routing and web application firewall (WAF) rules from the domains used for normal users.
- [ ] Set up identity and access management (IAM) so that admin web login pages use stronger, separate login rules—such as phishing-resistant multi-factor authentication (MFA), step-up authentication, and conditional access—different from the rules used for normal user access.
- [ ] Apply additional controls on administrator access (such as IP allowlisting, virtual private network (VPN), or zero trust network access (ZTNA), and role-based authorisation (RBAC)) and confirm they work as intended using test cases.
- [ ] Record and store evidence: architecture and design documents, exports of network and identity and access management (IAM) settings, and operational procedures for maintaining separation.


---

#### SC-2.1 — Interfaces for Non-privileged Users (Enhancement)

This requirement is about keeping the system’s administration functions out of sight and out of reach for ordinary users. In everyday terms, it stops someone without permission from accidentally finding, guessing, or clicking their way into settings that control users, permissions, or the system itself. Without this separation, a non-authorised person could change settings, manage other users, or perform maintenance tasks, which could lead to disruption, fraud, or long-lasting damage.

To meet this expectation, the organisation must set up the system so that any administrator functions or other privileged management options are not shown in the menus, screens, or buttons available to non-privileged users, including anything that might appear “greyed out” or hidden. The system must also only show management options after a user is genuinely signed in with administrator-level privileges, and it must block direct attempts to open administration pages even if someone knows the address.

##### Hide and gate admin UI and endpoints for non-privileged users

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define management privilege model (Admin/Config/Maintenance) and map to IdP claims/roles; produce an authorisation matrix for all management endpoints and UI areas | IAM Lead | Enterprise | 16h | — |
| Implement server-side authorisation gates for all management endpoints (controller/service layer), returning generic 403/Not authorised without resource-discovery detail | Security Engineer | Department | 40h | — |
| Implement privileged step-up mechanism for sensitive management areas (re-authentication/elevated token) and ensure UI/API only activates after step-up | Security Engineer | Department | 24h | — |
| Build UI composition rules to omit management navigation/pages/components entirely for non-privileged users (no disabled/greyed-out leakage; not rendered in DOM) | Frontend Engineer | Department | 32h | — |
| Add client routing hardening (route guards) so management routes cannot render without required privileged claims; ensure redirects/denials occur before component mount | Software Lead | Department | 16h | — |
| Add audit-ready automated tests: UI negative tests (absence of management labels/links/focusable elements and routes) and API negative tests (direct calls return 403) integrated into CI | Quality Assurance Lead | Team | 32h | £3,000 |
| Produce evidence pack for SC-2(1) (test reports, authorisation matrix, step-up design notes, and sample 403 responses) suitable for audit and internal assurance | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 176h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Define management privilege roles and access rights (claims) and link them to the enterprise identity provider’s authorisation attributes.
- [ ] Implement conditional user interface (UI) composition so that management navigation and components are not included (not merely disabled) in non-privileged sessions.
- [ ] Add “privileged step-up” checks for sensitive management areas, so the admin user interface only appears after an elevated session has been set up.
- [ ] Carry out authorisation checks on the server for every management application programming interface (API) endpoint, controller, and service method, and return “403 Forbidden” for requests from users without the required privileges.
- [ ] Use route guards to strengthen client routing by blocking or redirecting non-privileged users before any management pages are shown
- [ ] Create automated tests to confirm that non-privileged users cannot see management interface elements, and that direct calls to management endpoints are blocked with a “403 Forbidden” response.


---

#### SC-2.2 — Disassociability (Enhancement)

This requirement is about keeping the software itself separate from the information it collects about how people use it. The main risk is that if a system is compromised, attackers could use stored details about user activity (such as session or activity information) to invade privacy, identify individuals, or reveal sensitive behaviour—especially if that information is stored together with the software files.

To meet this expectation, the organisation must set up its systems so that:
- the application and software code is stored in one location, and
- the “state” information that records users’ interactions is stored in a different location,

using separate storage locations and not mixing the two.

The organisation must also:
- document this separation in its security and privacy plans,
- keep clear procedures for how the separation is maintained during setup and updates,
- record the relevant design and configuration details, and
- keep audit records showing that separation is in place during day-to-day operation,

and assign responsibility to the people who build and run the systems.

##### Separate code artefacts from user-interaction state storage

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Perform current-state assessment of code artefact storage vs interaction/state storage (identify any co-mingling in filesystems, DB tables, object storage paths, caches, and session stores) | Compliance Manager | Enterprise | 16h | — |
| Define and document separation boundaries (data classification of “code/software” vs “interaction state”, approved state destinations, and mapping of application components to storage locations) | System Design Authority | Enterprise | 24h | — |
| Implement platform/infrastructure guardrails: mount code directories as read-only at runtime and ensure application runtime identities cannot write to code artefact locations | Infrastructure Lead | Enterprise | 32h | — |
| Provision dedicated state storage destinations (separate DB schemas/instances, dedicated Redis/session clusters, and/or dedicated object storage buckets/paths) and configure application to write interaction state only to these destinations | Platform Engineer | Enterprise | 40h | £12,000 |
| Implement access control separation (distinct IAM/DB roles/credentials for code read vs state read/write; least-privilege review and approval workflow) | Security Engineer | Enterprise | 24h | — |
| Add CI/CD policy-as-code validation to prevent misconfiguration (pipeline checks that state endpoints/paths match approved destinations; fail builds on drift) | DevOps Lead | Enterprise | 32h | £6,000 |
| Produce audit-ready evidence pack (architecture diagrams, configuration baselines, CI/CD check outputs, runtime configuration snapshots, and controlled test write/read evidence demonstrating non-co-mingling) | Data Protection Officer | Enterprise | 20h | — |

|  |  |  | **Total Estimated Effort** | **Total Estimated Cost** |
|---|---|---:|---:|---:|
|  |  |  | **208h** | **£18,000** |

###### Actions Required for Compliance

- [ ] Define and record which data items are treated as application or software code, rather than user-interaction state, for the target application.
- [ ] Configure the application so that it stores interaction information (such as session, workflow, and event state) in dedicated state services, rather than keeping this information in local code directories.
- [ ] Set up separate storage locations for **code** and **state**—use different registry and deployment paths for code, and different database/schema/bucket/volume locations for state.
- [ ] Prevent mixing by making code artefact locations read-only while the system is running, and by using separate credentials and role-based access control (RBAC) permissions for reading and writing state.
- [ ] Implement continuous integration and continuous delivery (CI/CD) checks that use automated rules to confirm that the system’s state endpoints or paths match the approved state destinations, and block any deployments that breach the required separation.
- [ ] Collect and store audit-ready proof showing that responsibilities are kept separate during day-to-day operation. This includes the system’s design and configuration baseline, saved snapshots of the live configuration, and results from pipeline checks.


---

### SC-3 — Security Function Isolation (Control)

This expectation is about keeping the parts of a system that protect security separate from the everyday parts that do normal work, so they cannot be interfered with. Without this separation, a mistake or malicious action in ordinary software could tamper with the security features that control who can access information, protect data, manage encryption keys, or record security events. This could allow unauthorised people to bypass protections or quietly change how the system behaves.

To meet this requirement, the organisation must clearly identify which security functions must be isolated, document how the separation is achieved, and follow written procedures to maintain it during design, building, configuration, day-to-day operation, and any changes. The system must enforce the separation using a clear isolation boundary and access restrictions, protect security components from being altered or replaced, and use only the minimum permissions needed.

The organisation must record the relevant configuration and keep audit records showing that separation is enforced, then review those records for any signs of failures or exceptions.

##### Isolate security functions using enforced host/VM boundary

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Create security-function inventory and component mapping (authz/authn enforcement, key management, security logging/monitoring agents, policy enforcement) with runtime locations and owners | Compliance Manager | Enterprise | 24h | — |
| Define target isolation boundary architecture (security domain/VM/tier, approved interfaces, least-privilege service identities, network allow-lists, exception model) and produce boundary design document | System Design Authority | Enterprise | 32h | — |
| Implement hosting-layer isolation (provision dedicated security execution domain/VM or hardened container/namespace; enforce separation from nonsecurity application tier) | Infrastructure Lead | Enterprise | 48h | £18,000 |
| Configure cross-boundary access controls (mTLS/allow-listed endpoints, explicit authorisation checks, separate service accounts/roles, deny-by-default rules) and validate with integration tests | Security Engineer | Enterprise | 40h | — |
| Harden security-function integrity and runtime protections (protected storage ACLs, restricted admin/debug capabilities, disable/limit interactive access, prevent unauthorised code/config modification; verify load/execute constraints) | Security Engineer | Enterprise | 40h | £6,000 |
| Implement audit-ready evidence and monitoring (enable boundary access denials, integrity/administrative change events, service identity usage; configure retention and SIEM forwarding; create review cadence runbook) | Operations Lead | Enterprise | 24h | £4,000 |
| Execute security validation and exception governance (test boundary enforcement, document any required inclusions of nonsecurity code within boundary, obtain sign-off, and update control evidence pack) | Cyber Security Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 232h  
**Total Estimated Cost:** £28,000

###### Actions Required for Compliance

- [ ] Create and get approval for a list of the application’s security functions, and link each one to the specific software and services that run during operation.
- [ ] Deploy security functions inside a dedicated isolation boundary—such as a separate virtual machine (VM) or instance, or a hardened container/namespace—separate from the non-security application tier.
- [ ] Set up service accounts with the minimum permissions needed, and only allow cross-system calls through approved (allow-listed) network and application programming interfaces (APIs).
- [ ] Secure the storage and the running environment for security-related code by limiting write access to the identities used for building and releasing, and by turning off debugging or code-injection routes that are not available to administrators.
- [ ] Set up and check operating system (OS) and host controls that separate “security” code from other code (including using privilege separation or the appropriate execution modes where these apply), so that non-security code cannot access the security functions’ operating environment.
- [ ] Enable audit logging for boundary enforcement and for administrative changes that affect security-function components, and set a regular review schedule.


---

#### SC-3.1 — Hardware Separation (Enhancement)

This requirement is about making sure the system’s “security parts” are kept physically and logically separate from everything else, so normal system functions cannot access them or interfere with them. Without this separation, a weakness or misuse in non-security software could potentially read or change sensitive security information—such as security settings, security logs, or secret keys—reducing the organisation’s ability to keep data and services safe.

To meet this expectation, the organisation must design, configure, and operate the system so that security functions run in an isolated environment enforced by hardware. This includes separating the storage used for security functions from the storage used for non-security functions, and ensuring the required security settings are enabled.

The organisation must also document how this separation works, keep the system’s security plan up to date with responsibilities and the isolation approach, and keep audit records showing that any changes affecting isolation were authorised and that the separation remains in place, so it can be verified.

##### Hardware-enforced secure execution for security functions

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select and document the hardware-enforced isolation mechanism (TEE/secure world/hardware rings/protected address spaces) and define the security functions to be isolated, including isolation boundaries and interface contracts | System Design Authority | Enterprise | 24h | — |
| Perform platform capability assessment and gap analysis (supported secure execution features, secure storage options, attestation/health-check availability, fallback/non-isolated execution risks) | Infrastructure Lead | Enterprise | 16h | — |
| Implement isolated security services with a narrow API (sign/verify/encrypt/decrypt/policy decisioning) and refactor callers so non-secure components cannot access isolated code/data directly | Software Lead | Department | 40h | — |
| Implement hardware-separated security storage objects (protected memory regions / secure storage) and enforce access attributes so non-security contexts cannot read/write security data | Security Engineer | Department | 32h | — |
| Configure and enforce runtime isolation (secure boot/secure execution enablement, disable fallback paths, validate isolation is active across lifecycle: dev/test/prod) | DevOps Lead | Business Unit | 24h | — |
| Build audit-ready evidence pipeline: capture attestation/secure-environment health checks, log isolation-related configuration changes via change management, and retain evidence for audits | Compliance Manager | Enterprise | 24h | £6,000 |
| Update system security documentation (system security plan content for isolation, responsibilities, verification/approval workflow, and boundary diagrams) and run a governance review for sign-off | Data Protection Officer | Enterprise | 16h | — |

**Total Estimated Effort:** 176h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Identify the hardware isolation method supported by the platform, and specify which security functions must be isolated.
- [ ] Set up the security services so they run only inside the isolated environment, and expose only a minimal interface to the non-secure operating system.
- [ ] Set up hardware-enforced protected memory and storage for security data, and confirm that non-secure systems or processes cannot read or write it.
- [ ] Set up and confirm the system’s live security controls (for example, secure boot/secure execution), and turn off any non-isolated fallback routes.
- [ ] Carry out attestation and secure-environment health checks, and send the results to central logging so they can be used as audit evidence.
- [ ] Update the system security documentation to explain the separation boundaries, who is responsible for what, and where audit evidence comes from.
- [ ] Ensure that any isolation-related configuration changes are approved through the authorised change management process and are kept for audit traceability.


---

#### SC-3.2 — Access and Flow Control Functions (Enhancement)

This expectation is about keeping the parts of your system that decide **who is allowed to do what** and the parts that control **how information is allowed to move** clearly separated from ordinary business features and from other protective tools. Without this separation, a mistake or weakness in non-essential features could accidentally interfere with, bypass, or confuse the protections that control access and information movement. That could leave your organisation exposed even if individual security tools are in place.

To meet this requirement, you must:

- First, identify and document the key functions that make access decisions and the key functions that control information movement.
- Then, describe in your system design how each of these functions is isolated from non-security functions and from other security functions.
- Implement this isolation in practice (not just in documentation), keep it consistent in your system configuration, and ensure the isolated functions can still be scanned and monitored.
- Record enough logging information to show that the isolated functions are working as intended.
- Keep your procedures and plans up to date so the live system matches the documented approach.

##### Isolate access & flow enforcement via dedicated PDP/guard gateways

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create and maintain enforcement-function inventory (PDP/access enforcement + information-flow/egress enforcement), including component boundaries, interfaces, and routing/decision ownership | System Design Authority | Enterprise | 16h | — |
| Define isolated runtime architecture for PDP and egress gateway (separate deployment units, service identities, network segmentation, deny-by-default routing model, bypass prevention controls) | Architect | Enterprise | 24h | — |
| Implement PDP/access-enforcement service (authorisation decision API, narrow mTLS/workload-identity interface, deterministic deny-by-default logic, decision logging schema) | Software Lead | Department | 56h | £12,000 |
| Implement information-flow enforcement gateway/egress proxy (sensitive-data routing controls, allow/deny flow policy enforcement, authenticated upstream/downstream interfaces, allow/deny event logging) | Platform Engineer | Department | 56h | £18,000 |
| Integrate business applications to enforce routing through PDP and egress gateway only (service discovery/routing updates, API gateway rules, network/service-level controls to prevent direct destination access) | DevOps Lead | Team | 40h | — |
| Establish monitoring, audit attribution, and vulnerability-scanner targetability for enforcement components (distinct logs/metrics, SIEM dashboards/alerts, scanner endpoints, configuration baselines) | Operations Lead | Enterprise | 24h | £6,000 |
| Update system design documentation and system security plan to reflect isolation boundaries and enforced routing paths; produce audit-ready evidence pack (manifests, network rules, interface contracts, monitoring screenshots/exports) | Compliance Manager | Enterprise | 20h | — |

**Total Estimated Effort:** 236h  
**Total Estimated Cost:** £36,000

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date list (inventory) of the components used to enforce access controls and information flow rules.
- [ ] Deploy the access-enforcement (policy decision point (PDP)) component inside its own protected runtime environment, using its own dedicated service identity.
- [ ] Set up the information-flow enforcement gateway (egress proxy) in its own protected runtime area, and send all sensitive data flows through it.
- [ ] Prevent users from bypassing the required route by blocking direct access to sensitive destinations, except when traffic goes through the enforcement gateway.
- [ ] Remove any reliance by enforcement components on auditing, intrusion detection system (IDS), or anti-malware agents, and ensure they do not run at the same time as those agents.
- [ ] Set up enforcement-specific logging and performance reporting so that decisions, and each allow or deny event, can be traced back to the specific enforcement components.
- [ ] Update the system design documentation and the system security plan to reflect the separation boundaries, and confirm that the live system configuration matches the documented baseline settings.


---

#### SC-3.3 — Minimize Nonsecurity Functionality (Enhancement)

This requirement is about keeping the parts of your systems that make security decisions as small and simple as possible, so there are fewer opportunities for errors. If non-essential functions are placed in the same protected area as the security features, mistakes or harmful software could interfere with the security decisions. This could allow unauthorised people to access information or systems.

To meet this expectation, the organisation must:
- clearly define the boundary around the security functions;
- identify and document any non-security functions inside that boundary; and
- design and configure the system so the number of non-security functions within the boundary is as small as possible.

Where full separation is not practical, the organisation must:
- record why separation is not practical; and
- reduce any non-security functions that could affect security to the minimum needed.

The organisation must also:
- keep the security-enforcing parts mainly to essential access decisions;
- configure systems to match the documented design; and
- keep the relevant design, configuration, audit, and security planning records, with named staff responsible for maintaining this approach.

##### Minimise nonsecurity code in security boundary via hardened security services

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Security-function-to-component inventory for access enforcement (authorisation decision, token validation, policy enforcement middleware) including runtime mapping | Security Engineering Lead | Enterprise | 24h | — |
| Define isolation boundary per security function (in/out of boundary, required libraries, secrets access paths, permitted network destinations, interface contracts) and produce boundary design documents | System Design Authority | Enterprise | 32h | — |
| Boundary minimisation plan: identify nonsecurity modules/features/plugins currently inside the security component runtime and produce a removal/disable backlog with rationale and risk notes | Compliance Manager | Enterprise | 20h | — |
| Implement hardened security service runtime: disable/remove optional features, restrict dynamic code loading/plugins, reduce dependencies, and enforce module allow-lists at build/runtime | Platform Engineer | Department | 40h | £6,000 |
| Constrain interfaces for imperfect separation: implement outbound allow-lists, timeouts, retry limits, and strict data handling for calls from security components to other services; add defensive coding patterns | Security Engineer | Department | 32h | — |
| Boundary configuration as code + deployment guardrails: locked feature flags, immutable/hardened images, CI/CD checks preventing enabling additional modules without change control; generate environment-specific configuration snapshots | DevOps Lead | Enterprise | 48h | £4,000 |
| Audit-ready evidence pack: versioned boundary definitions, module inventories, configuration snapshots per environment (prod/test/DR), and change history demonstrating minimisation and justifications | Data Protection Officer | Enterprise | 24h | — |

Total Estimated Effort: **220h**  
Total Estimated Cost: **£10,000**

###### Actions Required for Compliance

- [ ] Create an inventory that maps each security function to the application components that enforce access and make policy decisions.
- [ ] For each security component, define and document its isolation boundary, including what is in scope and out of scope, which software libraries it needs, what secrets it is allowed to access, and which network destinations it is permitted to connect to.
- [ ] Remove or turn off any non-essential modules, features, or plug-ins in the security system, and where possible, stop the system from loading new code while it is running.
- [ ] Set up an approved list of outbound connections and apply strict rules on which system interfaces can be used for any required calls made within the security boundary.
- [ ] Encode boundary configuration as hardened images, module allow-lists, and feature-flag locks, and enforce it through deployment controls (deployment guardrails).
- [ ] For each release and each environment, produce and keep versioned evidence, including the boundary definition, the list of enabled modules, the runtime versions, and saved configuration snapshots.


---

#### SC-3.4 — Module Coupling and Cohesiveness (Enhancement)

This requirement is about building security features like well-designed building blocks. Each block should be organised internally and should not rely heavily on other blocks. If security features are mixed together, a change in one area can accidentally break or weaken another. This makes the system harder to understand and maintain, and makes it easier for mistakes (or misuse) to spread.

To meet this expectation, the organisation must design and implement security functions as separate, mostly independent modules rather than one combined component. Each module’s responsibilities should be closely related, and the links (dependencies) between modules should be kept as small as possible. The organisation should reduce and simplify how modules interact, use a layered approach where appropriate, and document how modules are kept separate, including module boundaries, responsibilities, interfaces, and dependencies.

The organisation must also set up and record configurations that support this independence, keep audit records of changes that could affect how modules connect, include this approach in the system security plan, assign responsibility to system and network administrators or information security staff, and follow defined processes to keep the design cohesive and loosely connected. This should be supported by mechanisms such as clear interfaces and controlled communication.

##### Security modules with strict interfaces and dependency controls

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce security module decomposition and dependency graph (responsibilities, owned security functions, explicit dependencies, explicit outputs, data ownership) | System Design Authority | Enterprise | 24h | — |
| Define and document inter-module service contracts (schemas, request/response/event types, error semantics, allowed fields) and contract versioning strategy | Architect | Enterprise | 32h | — |
| Implement boundary enforcement layer (internal API gateway/middleware/service-mesh policy) to restrict approved callers per module and enforce schema validation at runtime | Platform Engineer | Business Unit | 48h | — |
| Implement shared-library/narrow public API surfaces for security modules (encapsulation of internals; prevent unauthorised cross-module imports) | Software Lead | Department | 32h | — |
| Add build-time dependency controls and architecture tests (dependency allow-lists, contract compliance checks, fail-fast CI gates) | DevOps Lead | Business Unit | 40h | £6,000 |
| Implement layered separation within security (decision vs enforcement; policy evaluation vs telemetry/audit emission) with module-level tests proving no hidden coupling | Security Engineer | Department | 40h | — |
| Integrate audit-ready evidence capture into CI/CD (deployment diffs, contract/policy version identifiers, module identifiers in release artefacts and logs) | Operations Lead | Enterprise | 24h | £3,000 |

**Total Estimated Effort:** 280h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Define a security module catalogue where each module has a single clear responsibility, is assigned to an owner for the security function it supports, and includes an explicit map of how modules depend on each other.
- [ ] Create and publish service agreements for every interaction between modules, including the interface details (application programming interface (API) and event formats), how errors are handled, and which fields are allowed.
- [ ] Put technical controls in place to enforce module boundaries, using an application programming interface (API) gateway and service mesh rules, and validating data formats at the points where modules connect.
- [ ] Add continuous integration and continuous delivery (CI/CD) architecture tests and dependency allow-lists to prevent unauthorised cross-module imports and calls.
- [ ] Separate the decision-making part of security from the part that enforces it, and separate the collection and recording of activity (telemetry and audit logs) from the part that evaluates security policy.
- [ ] Keep version-controlled documentation showing each module’s boundaries, how they connect (interfaces), and who owns each data set, and link this documentation to the release files.
- [ ] Capture and keep audit evidence for releases that change module interfaces, contracts, or dependency relationships.


---

#### SC-3.5 — Layered Structures (Enhancement)

This requirement is about building security in layers, so one security control does not quietly rely on another control working correctly. In everyday terms, it helps prevent a situation where, if one security feature fails or is temporarily unavailable, other protections also fail—creating gaps that attackers could exploit.

To meet this expectation, the organisation must design and implement its security controls as separate layers with as little interaction as possible between them. It must also ensure that lower layers do not depend on higher layers for their main protection, or for whether higher layers are correct.

The organisation must:
- document how the layers are arranged and how dependencies are avoided
- create and follow procedures to maintain this separation
- include this approach in its security plan
- set and record system settings that support the layered design
- keep audit records showing that layered protections are in place and are maintained

##### Non-dependent layered security with one-way interfaces

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define layered security model (layer responsibilities, enforcement vs observation/enrichment rules, and “no dependency” decision-path requirements) and publish in the Security Architecture document | System Design Authority | Enterprise | 24h | — |
| Specify one-way interface contracts between layers (event schemas, audit/log enrichment boundaries, and prohibition of lower→higher decision-path calls) and update architecture diagrams | Security Engineer | Enterprise | 16h | — |
| Implement enforcement boundary changes in lower layers to remove runtime dependencies on higher-layer decision/correctness services (e.g., local deterministic allow/deny logic, cached/static policy where applicable) | Software Lead | Department | 40h | — |
| Implement event emission from lower layers to higher layers (upward-only security-relevant events) and ensure higher layers consume events without impacting lower-layer allow/deny outcomes | Platform Engineer | Department | 24h | — |
| Create automated dependency checks and architecture guardrails (service dependency graph validation, code/config scanning for forbidden decision-path calls, CI/CD policy gates) | DevOps Lead | Enterprise | 32h | £6,000 |
| Execute controlled failure tests to prove lower-layer enforcement remains unchanged when higher-layer services are degraded/unavailable (test scripts, runbooks, and results evidence) | Quality Assurance Lead | Enterprise | 20h | — |
| Produce audit-ready evidence pack (architecture artefacts, interface contracts, dependency scan reports, failure test results, and configuration baseline references) and support change-control reviews | Compliance Manager | Enterprise | 16h | — |

| Total Estimated Effort | 172h | Total Estimated Cost | £6,000 |

###### Actions Required for Compliance

- [ ] Create a security-layer architecture diagram that shows where each layer starts and ends, what each layer is responsible for, and the explicit rules that prevent one layer from relying on another.
- [ ] Set up the lowest level of controls using fixed, local rules, and use “deny by default” where it applies.
- [ ] Remove or redesign any “decision-making” calls made during operation from lower-level enforcement components to higher-level security services.
- [ ] Define one-way interfaces so lower layers can only send events upward, and higher layers can only receive and use those events.
- [ ] Run automated checks on dependencies (service, configuration, and code) to confirm there are no cases where a lower level is enforced before a higher level.
- [ ] Run controlled tests that deliberately disable higher-level security services, and confirm that the lower-level allow and deny results do not change.
- [ ] Update the security plan and keep the proof needed for audits, including the system design, results of checks on software dependencies, results of failure tests, and agreed configuration settings (configuration baselines).


---

### SC-4 — Information in Shared System Resources (Control)

This requirement is about making sure that when shared parts of your systems are passed from one person or task to another, nothing from the previous user’s work is left behind for the next user to see. Without this, someone could accidentally or intentionally view leftover documents, messages, or other information that should have been cleared, including information stored in protected or encrypted form. This could lead to data leaks, privacy breaches, and loss of trust.

To meet this expectation, the organisation must set clear, written rules for how shared storage, shared work areas, and shared computing spaces are cleaned or reset when they are released for reuse. The organisation must also have documented procedures that staff follow every time.

The organisation must ensure the system design and settings actually enforce these protections for both people and automated tasks acting on their behalf. It must also keep audit records showing that the clean-up or reset was completed successfully.

##### Enforce shared-resource reuse cleanup with key destruction and audit logs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Map and classify all shared resource types in scope (workspaces, temp upload areas, scratch volumes, shared caches, job work directories, multi-tenant/shared storage) and define the “release event” + cleanup trigger per type | System Design Authority | Enterprise | 24h | — |
| Design the “release-to-reuse” state machine and gating logic (released-pending-cleanup → available only after cleanup success) including failure/timeout handling and idempotency requirements | Architect | Enterprise | 32h | — |
| Implement scoped encryption key strategy per tenant/job/session/workspace (key hierarchy, rotation/revocation semantics, and deterministic key-destruction workflow) | Security Engineer | Enterprise | 56h | — |
| Implement deterministic cleanup hooks in the workflow/job engine and orchestration layer (covers interactive and non-interactive paths: job completion, failure, cancellation, TTL expiry, container/VM termination) | Software Lead | Enterprise | 64h | — |
| Integrate audit evidence generation for each release/cleanup cycle (resource ID, tenant/job/workspace ID, cleanup method, start/end timestamps, outcome, key-destruction/secure-delete markers) and forward to the enterprise SIEM/logging platform | Compliance Manager | Enterprise | 40h | — |
| Configure underlying platform capabilities for secure deletion where key destruction is not feasible (storage lifecycle policies, secure-delete/overwrite mechanisms, and evidence markers for completion) | Infrastructure Lead | Enterprise | 40h | £25,000 |
| Execute residual information protection verification (User A then User B tests for plaintext + encrypted representations; rapid reuse; job fail/cancel scenarios) and produce an audit-ready test report with remediation actions | Quality Assurance Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 288h  
**Total Estimated Cost:** £25,000

###### Actions Required for Compliance

- [ ] List all shared system resources the application uses (workspaces, temporary areas, scratch volumes, shared caches, and job working directories) and define what release event applies to each one.
- [ ] Set up encryption keys so that each tenant, job, and session has its own keys when writing data to shared resources. This allows the release to be enforced by destroying or revoking the relevant keys.
- [ ] Add workflow and orchestration hooks so cleanup runs for both interactive users and background processes acting on their behalf, including when a task fails or is cancelled.
- [ ] Reuse the gate by temporarily marking the resources as unavailable until cleanup finishes successfully, then restore access only after confirmation.
- [ ] Record cleanup and key-destruction events in the central logging system (security information and event management (SIEM)), including the relevant resource identifiers, the time they happened, and the result/outcome.
- [ ] Run tests to check any remaining access rights by using User A first and then User B, for both plain text and encrypted versions. Include scenarios where the same data is reused quickly and where the job fails, and record the results.


---

#### SC-4.2 — Multilevel or Periods Processing (Enhancement)

This expectation is about preventing sensitive information from being “carried over” when systems move between different levels of confidentiality. In practice, the risk is that if a shared computer, storage area, printer service, or other shared component is reused without proper cleaning and checks, information from one confidentiality level could be accessed or moved at another level. It can also mean the organisation may no longer be able to prove what happened.

To meet this expectation, the organisation must follow multilevel processing procedures approved by the Department of Defense (DoD) whenever it explicitly changes between different confidentiality levels or security categories. This includes when shared hardware is reused. After any such change, before reusing a shared resource, the organisation must make sure it is properly cleared and then checked to confirm the information has been correctly reclassified for the new level.

Access to shared resources must be limited based on the information’s labels. Every time the organisation makes such a change, it must record it in audit logs with enough detail to verify the change, the access decision, and the required clearing and reclassification steps.

##### Label-aware shared-resource gate for multilevel processing switches

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define processing modes, explicit switch triggers, and acceptance criteria aligned to sc-04.02_odp (including DoD-approved sanitisation/reinitialisation procedure identifiers per resource type) | Security Architect | Enterprise | 24h | — |
| Produce label-to-mode policy mapping (attribute/label-based access rules) and policy-as-code specification for each shared resource class (storage/buckets, file shares, print services, images, shared workspaces, shared DB/cache) | Compliance Manager | Enterprise | 32h | — |
| Design and implement the “processing-mode gate” orchestration API/service (single release path for shared-resource reuse; revoke previous-mode access; enforce default deny; block on sanitisation/reclassification failure) | Software Lead | Enterprise | 56h | — |
| Implement sanitisation workflow integrations per resource type (clear/purge/cryptographic erase/reinitialisation hooks) and implement reclassification/verification checks (integrity/label-state verification) with signed/attested results | Platform Engineer | Enterprise | 72h | — |
| Enforce label-based access at point of use (authorisation middleware/sidecar/connector changes so requests are permitted only when request label/category matches current processing-mode policy) | Security Engineer | Enterprise | 48h | — |
| Implement tamper-evident audit logging for every switch and gate decision; integrate with SIEM ingestion, define retention and alerting rules for allow/deny and failure scenarios | Operations Lead | Enterprise | 40h | £6,000 |
| Execute end-to-end testing and evidence pack (normal and failure scenarios; sanitisation verification failure; regression across environments; produce audit-ready documentation and runbooks) | Quality Assurance Lead | Enterprise | 40h | — |

Total Estimated Effort: **352h**  
Total Estimated Cost: **£6,000**

###### Actions Required for Compliance

- [ ] Define the different processing modes and document the specific conditions that trigger the application or workflow orchestration to switch between them.
- [ ] Set up a rule that maps each label to the correct access mode for every shared resource type (storage, computing, printing, databases, and caching), using the organisation’s label system (taxonomy).
- [ ] Set up a shared-resource control that removes earlier access permissions, cleans and sanitises the data, and then reclassifies and verifies it before it is released.
- [ ] Set the gate to block any reuse by default if the sanitisation or reclassification checks fail (no manual bypass).
- [ ] Apply label-based access controls at the point where shared resources are used, based on the current processing mode and the request’s information labels.
- [ ] Set up tamper-evident audit logs for every change in processing mode and every gate decision, and send those logs to the security information and event management (SIEM) system with a defined retention period.
- [ ] Run integration tests and failure-mode tests to prove that cross-level reuse is blocked and that complete audit evidence is available.


---

### SC-5 — Denial-of-service Protection (Control)

This requirement is about keeping your online services running even when they are targeted with very large volumes of traffic intended to take them offline. Without these protections, attackers (or even poor capacity planning) could overwhelm your systems with harmful requests, leading to slow performance, outages, or customers being unable to access websites, apps, or important services such as name lookups.

To meet this expectation, the organisation must address four main types of denial-of-service events and focus on reducing their impact, not necessarily stopping every attempt. It must put protections in place at the network edge to block harmful traffic, slow down excessive requests, remove suspicious traffic before it reaches the services, run services with built-in resilience so one failure does not stop everything, and be able to increase bandwidth and processing capacity when needed.

The organisation must also document how these measures are implemented, keep records of relevant events, maintain lists of the threats and safeguards, ensure the right people are responsible for implementation and incident response, and include the approach in system plans and design documentation.

##### Layered edge DoS protection for defined DoS types

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce DoS coverage mapping and “limit” objectives in system design documentation (UDP flood, SYN/ACK flood, HTTP flood, DNS/NTP reflection/amplification → boundary filtering, rate limiting, traffic scrubbing, redundancy/capacity scaling) | System Design Authority | Enterprise | 16h | — |
| Implement boundary filtering at the edge (perimeter firewall/cloud edge/load balancer rules for UDP flood and SYN/ACK flood patterns; restrict inbound access paths to required application ports/protocols) | Security Engineer | Enterprise | 40h | — |
| Implement edge rate limiting (protocol-layer flow/connection limits; per-route/per-endpoint HTTP throttling; per-source and token/session-based limits where applicable; tuning against baseline traffic) | Security Engineer | Enterprise | 56h | — |
| Configure traffic scrubbing / protected upstream routing for volumetric and reflection/amplification traffic (UDP flood and DNS/NTP reflection/amplification), ensuring scrubbing occurs before application tier | Infrastructure Lead | Enterprise | 48h | £25,000 |
| Implement redundancy and capacity scaling for availability during DoS events (redundant load balancers, stateless tiers, failover, autoscaling policies for compute/network) | Platform Engineer | Enterprise | 64h | — |
| Establish operational evidence and traceability (logging of dropped/throttled/scrubbed/challenge triggers, failover and scaling events; version-controlled infrastructure rulesets; change records and retention alignment) | Compliance Manager | Enterprise | 40h | — |
| Validate controls via tabletop + technical testing (simulate each DoS type in a controlled environment; verify enforcement, tuning, and observability; produce evidence pack for audit) | Quality Assurance Lead | Enterprise | 32h | £5,000 |

**Total Estimated Effort:** 336h  
**Total Estimated Cost:** £30,000

###### Actions Required for Compliance

- [ ] Document how each denial-of-service (DoS) attack type maps to the corresponding safeguard for UDP flood, SYN/ACK flood, HTTP flood, and DNS/NTP reflection and amplification attacks, with the explicit objective of limiting the overall impact.
- [ ] Set up boundary filtering on perimeter firewalls, cloud edge systems, and load balancers to block and reject the identified UDP flood and SYN/ACK flood traffic patterns.
- [ ] Set up limits at the network “edge” to control the maximum number of connections and data flows, and add request throttling for each specific web address (endpoint/route) to prevent HTTP flooding.
- [ ] Send relevant incoming network traffic through an inline traffic “scrubbing” service to filter out large-volume and reflection/amplification attacks before the traffic reaches the application layer.
- [ ] Set up redundant load balancing and failover that does not rely on stored session data, and enable automatic capacity scaling for the application tiers.
- [ ] Turn on and keep audit logs for events that were dropped, limited (throttled), or filtered (scrubbed), as well as for failover actions and scaling events. Store the related configuration and thresholds in version control.


---

#### SC-5.1 — Restrict Ability to Attack Other Systems (Enhancement)

This expectation is about preventing anyone who has access to your systems from using them to overwhelm other organisations’ services with large volumes of traffic, such as UDP/TCP floods, SYN floods, web (HTTP/HTTPS) floods, and attacks that drain a service’s resources. Without these protections, a hostile insider or an external attacker who gains access to your environment could turn your network into a weapon. This could cause outages, slow performance, and reputational damage for other organisations, while also putting your own systems at risk.

To meet this expectation, your organisation must clearly state which denial-of-service attack types you will defend against, document how you will detect and respond to them, and keep records of any such activity you observe. You must put technical safeguards in place—especially at the points where traffic leaves your network or reaches key services—to block or strictly limit the most common ways these attacks are carried out. You must also restrict unauthorised or forged traffic, and limit excessive use of network and computing resources. Make sure these safeguards apply to all relevant users and systems, and keep audit evidence showing the protections were in place and acted when needed.

##### Boundary egress controls to block DoS attack traffic types

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Perform boundary egress architecture review and identify all outbound paths (including any SD-WAN/route/proxy bypasses) for in-scope subnets | Security Architect | Enterprise | 16h | — |
| Define enforceable traffic-pattern mappings and thresholds for each in-scope DoS type (UDP/TCP volumetric, SYN floods, HTTP(S) floods, application-layer resource exhaustion) with per-source/destination rate/connection limits | Cyber Security Lead | Enterprise | 24h | — |
| Implement centralised egress routing so all outbound traffic from relevant subnets traverses NGFW/egress gateway and/or secure web gateway (routing, policy enforcement points, and validation of no alternate egress) | Infrastructure Lead | Enterprise | 32h | — |
| Configure NGFW/egress gateway transport-layer protections: SYN/half-open protections, new-connection rate thresholds, UDP/TCP per-source+per-destination rate limiting (bps/pps with burst handling), and connection limiting | Security Engineer | Enterprise | 40h | — |
| Configure application-layer protections for HTTP(S) egress via reverse proxy/WAF (or managed DDoS/WAF service): request rate limiting, concurrent request limits, burst controls, and resource-exhaustion mitigations (timeouts/session caps) | Security Engineer | Enterprise | 40h | £25,000 |
| Implement logging, alerting, and SIEM evidence: ensure boundary devices emit required fields (source IP/identity, destination, protocol/port, action taken, counters) and create correlation rules/dashboards for enforcement events | Compliance Manager | Enterprise | 24h | — |
| Execute controlled DoS simulation and tuning: run lab/controlled tests per DoS type, measure reduction/prevention against thresholds, tune policies to minimise false positives, and produce acceptance evidence pack | Quality Assurance Lead | Enterprise | 24h | £5,000 |
| Deliver operational readiness: update runbooks, change management records, and monitoring/response procedures for boundary egress enforcement (including rollback approach) | Operations Lead | Enterprise | 16h | — |

**Total Estimated Effort:** 216h  
**Total Estimated Cost:** £30,000

###### Actions Required for Compliance

- [ ] For each in-scope denial-of-service (DoS) type (sc-05.01_odp), identify the specific network protocol, port, and application request patterns that will be used to enforce protection.
- [ ] Ensure that all outgoing network traffic from the relevant application subnets passes through the approved boundary control route (next-generation firewall (NGFW), software-defined wide area network (SD-WAN), proxy, or web application firewall (WAF)).
- [ ] Set up network firewall transport controls to protect against SYN and half-open connections, and limit TCP and UDP traffic rates and the number of connections separately for each source and each destination.
- [ ] Send all outbound web traffic using Hypertext Transfer Protocol (HTTP) and Hypertext Transfer Protocol Secure (HTTPS) through a reverse proxy and web application firewall (WAF), and turn on protections that limit how fast requests can be made, cap the number of simultaneous requests, and control short bursts of traffic.
- [ ] Set the alert thresholds using normal (baseline) traffic, and decide what to do when flood-like patterns are detected—either block/deny them or apply strict limits.
- [ ] Enable and send audit logs for all enforcement actions to the security information and event management (SIEM) system, including enough details to support incident investigation.


---

#### SC-5.2 — Capacity, Bandwidth, and Redundancy (Enhancement)

This requirement is about making sure your services have enough capacity and built-in resilience to keep working even if someone tries to overwhelm them with a large volume of requests. Without this planning, a busy website, app, or online service could become slow or completely unavailable, disrupting customers, day-to-day operations, and revenue.

To meet this expectation, the organisation must define, approve, and follow clear procedures for denial-of-service protection. It must also design and configure the system with practical safeguards, such as:
- giving priority to the most important functions  
- limiting how much any one user or service can consume  
- separating resources so an attack affects only part of the system  
- spreading traffic across multiple resources  
- maintaining redundancy so a failure does not cause a complete shutdown  

The organisation must keep evidence that these measures are in place and actively managed. This includes system design and configuration records, audit logs of relevant actions, and a security plan that brings these elements together.

##### DoS capacity controls: quotas, priority traffic, and partitioned pools

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce DoS capacity control design: define in-scope entry points, critical functions→traffic classes mapping, and measurable thresholds (rate limits, session/concurrency caps, circuit-breaker limits) with documented intended behaviour (e.g., 429/503, throttling order) | System Design Authority | Enterprise | 40h | — |
| Implement priority handling and partitioned traffic pools at edge (load balancer/reverse proxy/API gateway): configure traffic classes, priority queues, queue limits, and rejection/backpressure policies | Infrastructure Lead | Enterprise | 56h | £6,000 |
| Implement quota/rate/session enforcement in the data path: per-IP/per-tenant and per-route limits, connection/session caps for HTTP(S)/WebSocket/gRPC, and downstream circuit breakers (with safe defaults) | Security Engineer | Enterprise | 64h | £8,000 |
| Integrate observability and audit evidence: instrument throttle/quota exceeded, circuit-breaker trips, queue saturation/rejections; forward logs/metrics to SIEM with required fields (timestamps, component IDs, traffic class, action outcome) | Operations Lead | Enterprise | 40h | £3,000 |
| Create and maintain configuration evidence (IaC/config management): store approved thresholds/mappings, change history, and deployment records for audit traceability | Compliance Manager | Enterprise | 24h | — |
| Execute controlled flooding-like validation tests (non-prod/controlled window): run traffic patterns per traffic class, verify critical endpoint SLOs, confirm non-critical throttling, and capture evidence/lessons learned | Quality Assurance Lead | Enterprise | 32h | £2,500 |
| Operational runbook and tuning plan: define monitoring dashboards/alerts, incident response actions for quota/circuit-breaker events, and a periodic review cadence for thresholds | Service Delivery Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 280h  
**Total Estimated Cost:** £19,500

###### Actions Required for Compliance

- [ ] Identify the entry points that are in scope for incoming network traffic and define traffic categories mapped to critical business functions.
- [ ] Define and get approval for measurable limits on rates, connections, and sessions, and for the circuit-breaker response for each category.
- [ ] Set up priority queues and traffic categories at the edge (load balancer, reverse proxy, or application programming interface (API) gateway) so that critical functions are handled first.
- [ ] Divide available capacity into separate pools (or virtual services) for each type of traffic, so that during traffic surges no one type is left without resources.
- [ ] Set up and apply limits on how many requests can be made (quotas and rate limits), limit the number of simultaneous sessions (session caps), and add automatic “stop” controls (circuit breakers) for any dependent systems in the request path.
- [ ] Track and record events related to throttling, quotas, and circuit breakers, and send the relevant logs and performance data to the enterprise security information and event management (SIEM) system to provide audit evidence.
- [ ] Run controlled tests that mimic flooding and check that the most important system endpoints meet the agreed availability and response-time targets, while traffic that could be abusive is limited.


---

#### SC-5.3 — Detection and Monitoring (Enhancement)

This requirement is about spotting and responding early when someone tries to overwhelm your systems so they slow down or stop working. Without clear detection and ongoing checks, a denial-of-service attack could flood your services, use up key computing resources, and prevent customers from accessing what they need. It could also make it harder to understand and trace what happened.  

To meet this expectation, the organisation must use tools that can recognise suspicious attack patterns and connect related events recorded by systems. This includes dedicated tools to detect denial-of-service signs, systems that watch network traffic for unusual behaviour, automated linking of security log events, and monitoring of how well applications are performing.  

The organisation must also continuously check whether there is enough spare capacity to withstand attacks. This means monitoring processor load, memory use, network traffic volume and message rates, and available disk space and disk performance “headroom”.  

The approach, settings, and monitoring methods must be documented, supported by audit records, included in the system security plan, and assigned to responsible administrators. There must be clear procedures showing how monitoring results are used for denial-of-service protection.

##### DoS/DDoS detection and resource-capacity monitoring with SIEM correlation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define DoS/DDoS monitoring scope, resource-sufficiency metrics, and data-source mapping (sensors, IDS/IPS, APM, host/storage/network telemetry) including collection intervals and alerting objectives | Compliance Manager | Enterprise | 16h | — |
| Deploy/enable DoS/DDoS detection sensors at external-facing boundaries and validate end-to-end telemetry generation (test events, baseline traffic, and sensor health monitoring) | Infrastructure Lead | Business Unit | 24h | £25,000 |
| Deploy/configure network IDS/IPS at choke points and tune initial detection profiles for DoS/DDoS patterns (volumetric spikes, connection floods, protocol misuse) with change-controlled configuration | Security Engineer | Department | 32h | £18,000 |
| Implement SIEM detection-as-code correlation rules to (a) detect DoS/DDoS indicators, (b) correlate with application symptoms (latency/error-rate/throughput degradation), and (c) require resource pressure/headroom degradation to distinguish “attack in progress” vs “capacity exhausted” | Software Lead | Enterprise | 40h | £6,000 |
| Integrate APM signals into the SIEM/observability pipeline (APM-to-SIEM forwarding, field mapping, enrichment, and correlation-ready dashboards) | DevOps Lead | Enterprise | 24h | £4,000 |
| Implement continuous resource-capacity monitoring for CPU, memory, network bandwidth/packet rates, disk space, and IOPS headroom; configure threshold-based alerts for storage capacity and disk performance headroom | Platform Engineer | Enterprise | 40h | £12,000 |
| Document monitoring approach and configuration (routing, thresholds, correlation logic, rule lifecycle, evidence retention) and update system security plan with audit-ready records | Data Protection Officer | Department | 16h | — |
| Establish operational procedures for triage, tuning, and response (runbooks for SIEM-correlated DoS/DDoS alerts; ownership; escalation paths; periodic rule tuning cadence) | Service Delivery Manager | Business Unit | 24h | — |

**Total Estimated Effort:** 216h  
**Total Estimated Cost:** £65,000

###### Actions Required for Compliance

- [ ] Identify the data sources and the required measures for denial-of-service (DoS) and distributed denial-of-service (DDoS) monitoring for the system, including CPU use, memory use, network packet and bandwidth use, available disk space, and input/output operations per second (IOPS) capacity headroom.
- [ ] Install or activate distributed denial of service (DDoS) detection sensors at the system’s external entry and exit points, and confirm they can see both incoming and outgoing traffic.
- [ ] Set up a network intrusion detection and prevention system (IDS/IPS), or an equivalent tool, to spot traffic patterns that match denial-of-service (DoS) or distributed denial-of-service (DDoS) activity, and send those alerts to the security information and event management (SIEM) system.
- [ ] Implement security information and event management (SIEM) “detection-as-code” rules that connect network security alerts with signs of resource pressure and application or service performance problems.
- [ ] Integrate application performance monitoring (APM) signals into the security information and event management (SIEM) and observability pipeline, and include them in the event correlation logic.
- [ ] Set up automated alerts when storage capacity reaches set limits and when disk performance has less spare capacity than expected, and send these alerts to specific named administrators.
- [ ] Document the monitoring setup and procedures. Include this approach in the system security plan. Keep audit records showing any rule or configuration changes.


---

### SC-6 — Resource Availability (Control)

This requirement is about making sure your most important services keep working even during very busy periods. It does this by reserving and protecting the computer power, memory, and internet capacity those services need. Without this, heavy demand, a faulty application, or a large number of requests could take up shared resources, leading to slow responses, failed transactions, or downtime for services your business depends on.

To meet this expectation, the organisation must:
- Clearly identify which services are mission-critical.
- Set priority rules and fixed limits for computer processing power (CPU), memory, and network bandwidth, so lower-priority activity cannot affect higher-priority services.
- Ensure no user or process can use more than the agreed amounts.

The organisation must also:
- Document how these priorities and limits are set and kept up to date.
- Keep evidence of the system design and configuration showing that the controls are in place and being applied.
- Record who changes the priorities and limits and when.
- Assign named roles responsible for managing these controls.

##### Enforce priority and quotas for mission-critical workloads

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create mission-critical resource model: inventory mapping of mission-critical services to protected resources (CPU/memory/network) with organisation-defined priority and quota values | Compliance Manager | Enterprise | 24h | — |
| Define standard enforcement profiles: priority/quota templates for each hosting layer (Kubernetes PriorityClasses + requests/limits; VM CPU scheduling tiers/shares + memory reservations/caps; network bandwidth caps per service/namespace) | System Design Authority | Enterprise | 32h | — |
| Implement compute priority protection: configure admission/policy controls and workload settings so lower-priority workloads cannot starve mission-critical services | Platform Engineer | Department | 40h | — |
| Implement quota enforcement: apply hard/strict caps for CPU/memory and bandwidth shaping/throttling per service/namespace; ensure failure modes are safe and observable | Infrastructure Lead | Department | 48h | — |
| Build auditability & change control: implement infrastructure-as-code, configuration export, immutable change logs, and evidence collection for current priority/quota state | DevOps Lead | Enterprise | 32h | — |
| Integrate monitoring/alerting for quota and contention: dashboards and alerts for throttling/limit hits, scheduling delays, and bandwidth saturation for mission-critical services | Operations Lead | Department | 24h | — |
| Execute contention and quota-exceed validation: run controlled load tests, capture results, and produce an audit-ready test report demonstrating priority protection and quota enforcement | Quality Assurance Lead | Business Unit | 40h | £8,000 |
| Total Estimated Effort |  |  | **240h** | — |
| Total Estimated Cost |  |  | — | **£8,000** |

###### Actions Required for Compliance

- [ ] Set up a mission-critical mapping between services and the resources they use—covering central processing unit (CPU), memory, and network bandwidth—so each service has a defined priority and a quota (limit) for those resources.
- [ ] Set higher execution priority for mission-critical workloads (for example, using Kubernetes priority classes or the hypervisor’s scheduling tiers).
- [ ] Set CPU and memory requests and limits (also called reservations and caps) to control how much of the quota each workload profile can use.
- [ ] Set network bandwidth limits for each service and namespace using built-in platform tools or traffic shaping, for both incoming (ingress) and outgoing (egress) traffic where applicable.
- [ ] Use approved priority and quota settings by applying them through infrastructure-as-code and/or platform admission and policy controls.
- [ ] Enable and keep verifiable records of priority and quota settings, including any changes (configuration exports and change logs).
- [ ] Run tests for service access conflicts and quota limits to confirm that mission-critical services keep priority access and that quota limits are enforced.


---

### SC-7 — Boundary Protection (Control)

This requirement is about putting clear, managed “front door and back door” controls around your systems, and closely monitoring what enters and leaves. Without these controls, unwanted visitors could get in without being noticed, harmful traffic could reach important services, and internal systems could be exposed through accidental or unauthorised connections.

To meet this expectation, the organisation must identify the main connection points where the system connects to the outside world, and where important internal traffic moves between major areas. It must then monitor these points and apply rules so that only approved communications are allowed.

Any parts of the system that are visible to the public must be placed in a separate, isolated network area, so they are not treated as part of the internal environment.

Finally, every connection to external networks or partners must go through approved boundary protection devices. These devices must be configured to match the organisation’s security and privacy design, with no hidden routes that allow traffic to bypass these protections.

##### Managed boundary protection with DMZ isolation and anti-spoofing

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce authoritative boundary inventory & topology (external managed interfaces + key internal managed interfaces) mapped to application tiers/environments (prod/test/DR) | Security Architecture Lead | Enterprise | 24h | — |
| Design DMZ-style logical separation for public-facing components (network segmentation model, routing approach, zone definitions, allowed DMZ↔internal flow matrix) | System Design Authority | Enterprise | 32h | — |
| Implement managed boundary rule sets (default-deny + explicit allow) per zone-to-zone/service on each managed interface, aligned to multi-tier architecture and least-privilege principals where feasible | Security Engineer | Enterprise | 56h | — |
| Configure anti-spoofing/source address validation on boundary devices and tunnel endpoints (ingress/egress filtering, strict route/source validation, disable bypass-capable paths) | Security Engineer | Enterprise | 40h | — |
| Enable continuous monitoring & audit logging for boundary devices/tunnel endpoints (log fields: src/dst/service, action, rule identifier, timestamps) and forward to SIEM with correlation use-cases for boundary anomalies | SOC / SIEM Engineer | Enterprise | 32h | £8,000 |
| Validate and evidence “no bypass” connectivity (routing/path verification, default gateway checks, configuration snapshots, and test cases proving all external connectivity traverses managed boundary devices) | Infrastructure Lead | Enterprise | 24h | — |
| Operationalise change control for boundary rules (policy-as-code/config management, peer review workflow, automated linting/validation, drift detection, and evidence packaging for audits) | Project Manager | Enterprise | 40h | £6,000 |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £14,000

###### Actions Required for Compliance

- [ ] Create and get approval for an official record of the application’s network boundaries and connections, covering all externally managed interfaces and the main internally managed interfaces.
- [ ] Set up demilitarised zone (DMZ)-style logically separated subnetworks for every component that is publicly accessible, and configure only explicit allow rules for traffic from the DMZ to internal networks and from internal networks back to the DMZ.
- [ ] Configure each boundary device and tunnel endpoint to block everything by default, and then add only the specific “allow” rules needed for the application’s required zone-to-zone services.
- [ ] Set up and check source address validation and anti-spoofing protections on boundary devices to block traffic that tries to pretend it is coming from internal or external addresses.
- [ ] Turn on complete logging for network boundaries and tunnels (including the rule and action identifiers), and send the logs to the security information and event management (SIEM) system with retention that is suitable for audits.
- [ ] Check that network routing and paths are set up correctly so that all external connections go through the approved, managed network interfaces, and record proof that there are no alternative “bypass” routes.
- [ ] Use configuration management and policy-as-code to manage changes to boundary rules, with peer review, automated checks to confirm changes are valid, and monitoring to detect any drift from the approved configuration.


---

#### SC-7.3 — Access Points (Enhancement)

This requirement is about keeping the number of “entry and exit points” between your organisation and the outside world to a sensible maximum, so the system cannot be reached through too many external connections at the same time. If too many external connections are allowed, it becomes harder to spot suspicious activity, harder to control what traffic is allowed in and out, and easier for attackers to find an unexpected way into your systems.

To meet this expectation, the organisation must set a clear maximum number of external inbound (incoming) and outbound (outgoing) connections the system may use at any time. The system must be configured so it cannot exceed that limit, and it must be able to show how many connections are currently active. It must monitor traffic using only the permitted connections.

The organisation must also keep records and documentation showing how the boundary protection is implemented, how the system is designed and configured to enforce the limit, and how this is covered in the security plan. This must continue during technology changes, such as using older and newer network protocols at the same time. During such transitions, the limit must be reviewed and updated when the transition changes.

##### Enforce a connection budget at the network edge for the system

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the connection budget for the application system (max concurrent external connections) including a clear definition of what counts as an inbound/outbound connection instance, VPN/tunnel sessions, and IPv4/IPv6 transition accounting (combined or per-family with a documented total) | Compliance Manager | Enterprise | 16h | — |
| Produce boundary enforcement design and rule model for the edge (NGFW / edge firewall / load balancer / secure gateway): default-deny, allow-list scope, and selection of the appropriate concurrent session/connection limiting mechanism(s) per protocol/tunnel type | System Design Authority | Enterprise | 24h | — |
| Implement boundary configuration to enforce the budget (concurrent session/connection caps, per-policy concurrency limits, and equivalent controls for protocols that multiply sessions), including deny logging for attempts to exceed limits | Security Engineer | Enterprise | 40h | £3,000 |
| Configure boundary telemetry and log retention for audit-ready evidence: session/tunnel start/stop, denied attempts, and correlation identifiers to support “active external connections for system X” derivation | Operations Lead | Enterprise | 24h | £2,500 |
| Build SIEM-derived metric and dashboards for “active external connections for system X” and “budget pressure” (allowed vs blocked/denied), ensuring only permitted connections are included in the active-connection calculation | DevOps Lead | Enterprise | 32h | £5,000 |
| Implement monitoring and alerting for sustained and sudden budget pressure (thresholds, alert routing, runbook links, and escalation rules), plus validation in a controlled test window | Service Delivery Manager | Enterprise | 16h | — |
| Create and execute an audit evidence pack and test script: boundary configuration snapshots/rule sets, logging configuration, sample audit logs demonstrating enforcement, and transition-period (IPv4/IPv6) verification results | Compliance Manager | Enterprise | 20h | — |

**Total Estimated Effort**: 172h  
**Total Estimated Cost**: £10,500

###### Actions Required for Compliance

- [ ] Create a documented “connection budget” for the application system, including what is counted as an external connection—such as inbound traffic, outbound traffic, network tunnels, and protocol-family counting during the transition period.
- [ ] Set up edge, next-generation firewall (NGFW), and load balancer rules so that everything is blocked by default (“default deny”), and only explicitly approved external sources, destinations, ports, and network protocols are allowed (“allow-lists”).
- [ ] Set up and adjust controls for how many sessions or connections can run at the same time (or an equivalent boundary mechanism) to enforce the maximum number of external connection instances.
- [ ] Configure boundary devices to record when sessions or tunnels start and stop for the application system, and to record any denied access attempts.
- [ ] Set up security information and event management (SIEM) to calculate and show how many active external connections the system currently has, and to produce reports comparing allowed versus blocked connections.
- [ ] Set up alerts when budget pressure lasts or crosses a set limit, and confirm that any further attempts to exceed the limit are blocked or denied.
- [ ] Update the connection budget and boundary rules through change management whenever endpoints, partners, or Internet Protocol version 4 (IPv4) / Internet Protocol version 6 (IPv6) transition settings change.


---

#### SC-7.4 — External Telecommunications Services (Enhancement)

This requirement is about tightly controlling how your organisation’s external communication links connect to the outside world. The goal is to ensure only the right information can pass, and that it cannot be secretly read, changed, or misused. Without this, an attacker could try to reach your internal management and routing functions from the internet, or trick other networks into accepting unauthorised instructions. This could disrupt services or allow unauthorised control.

To meet this expectation, you must set up a clearly controlled connection for every external communications service you use. For each connection, you must have written rules that state what traffic is allowed and what is blocked. You must also protect information while it is being sent, so it stays confidential and cannot be altered.

Any temporary exceptions to these rules must be formally recorded, including the specific business reason and the exact time period. These exceptions must be reviewed every quarter and removed when they are no longer justified.

You must also publish information that helps other networks identify unauthorised management traffic coming from you, and filter unauthorised management traffic coming in from external networks.

##### Managed boundary for external telecom services with time-bounded exceptions

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create External Telecommunications Services Register (service → managed interface mapping, scope, owners, protocols, environments) | Compliance Manager | Enterprise | 16h | — |
| Define traffic-flow policy per managed interface (default-deny for management/control-plane; explicit allow rules; rule rationale) and produce auditable policy documents | Security Engineer | Enterprise | 24h | — |
| Implement/confirm confidentiality & integrity in transit requirements for each interface (e.g., TLS 1.2+/mTLS for management APIs; IPsec/VPN for site-to-site/remote links) with test evidence | Network Security Lead | Enterprise | 32h | £2,500 |
| Implement control-plane protection at the boundary (filtering/ACLs for unauthorised BGP/management protocol traffic; allow only authenticated/validated control-plane interactions) and provide scan/test evidence | Security Engineer | Enterprise | 24h | £1,500 |
| Publish/maintain detection information where applicable (e.g., routing security artefacts such as RPKI-related configuration/validation checks; boundary monitoring hooks) with validation evidence | Cyber Security Lead | Enterprise | 16h | £1,000 |
| Establish exceptions governance with expiry (exceptions register template capturing exact rule delta, mission/business need, start/end dates, approver, rollback plan; quarterly review workflow) | Data Protection Officer | Enterprise | 20h | — |
| Operationalise quarterly review pack and attestation (generate evidence pack from policy/config + exceptions register; remove expired/no-longer-needed exceptions via change records) | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 156h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Create and keep an External Telecommunications Services register that lists each external service and links it to a named managed interface.
- [ ] Create a documented rule set that allows or blocks network traffic for each managed interface, with a “deny by default” approach for management and control-plane traffic.
- [ ] For each interface, set up and check the protections that keep data confidential and unaltered while it is being sent (for example, Transport Layer Security (TLS) / mutual Transport Layer Security (mTLS) or Internet Protocol Security (IPsec) / virtual private network (VPN)). Keep records as evidence of the configuration.
- [ ] Set up boundary filtering to block unauthorised control-plane traffic coming from external networks, and confirm it works using focused tests.
- [ ] Create an exceptions register that records: what rules have changed, the mission or business reason, the start and end dates, who approved it, and the plan to undo the change (rollback).
- [ ] Carry out a quarterly review of all currently active exceptions, record the evidence that confirms they are still approved, and remove any exceptions that are no longer justified.
- [ ] Publish and test detection materials that are relevant to the service type (for example, RPKI-related information for Border Gateway Protocol (BGP)) to support remote detection.


---

#### SC-7.5 — Deny by Default — Allow by Exception (Enhancement)

This expectation is about blocking all network traffic by default, and then allowing through only the specific connections you have explicitly approved. Without this, unwanted or harmful connections could get in or out, putting systems at risk of unauthorised access, data theft, or disruption—especially when your systems connect to outside services or partners.

To meet this requirement, the organisation must set up the managed connection points (such as network boundary devices) so that both incoming and outgoing traffic is blocked unless it matches a clearly defined, documented exception. The organisation must:

- define the permitted exceptions for each direction (incoming and outgoing)
- apply the same approach to connections with external systems
- keep clear records showing the approved exceptions and the settings that were implemented

It must also have written procedures, documented plans and designs, and evidence from configuration and audit records showing that the traffic blocking and approved exceptions are actually enforced.

##### Default-deny firewall policy with exception catalogue at managed interfaces

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce managed interface inventory (boundary firewalls, cloud security gateways, ZTNA egress points, SD-WAN edge, router boundary interfaces) with environment tagging (prod/test/DR), ownership, and interface identifiers | Infrastructure Lead | Enterprise | 24h | — |
| Define exception catalogue schema and governance workflow (direction-specific inbound/outbound, source/destination fields incl. IP/CIDR/FQDN/zone, protocol/ports, application/service context, traceable approval reference) | Compliance Manager | Enterprise | 20h | — |
| Create initial exception catalogue entries for all required approved flows (including external system destinations) and ensure each entry maps to a traceable change/authorisation ID | Compliance Manager | Enterprise | 32h | — |
| Implement default-deny (catch-all deny) for inbound and outbound on every managed interface, and remove/identify any broad allow rules that would override deny posture | Security Engineer | Enterprise | 56h | — |
| Configure allow rules strictly from the exception catalogue (tight scoping; no wildcard ports/CIDRs unless explicitly justified and approved) and ensure each deployed rule references the corresponding exception/approval ID | Network Security Lead | Enterprise | 72h | — |
| Enable evidence capture and configuration management (device config snapshots, IaC commit IDs where applicable, change record linkage) and implement automated checks to validate default-deny and exception-only rule sets | DevOps Lead | Enterprise | 48h | £6,000 |
| Execute validation and periodic enforcement testing (synthetic probes from controlled test hosts for approved flows; negative tests for non-approved flows; produce audit-ready test evidence and runbook) | Quality Assurance Lead | Enterprise | 40h | — |

| Total Estimated Effort |  |  | **292h** |  |
| Total Estimated Cost |  |  |  | **£6,000** |

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date list of all managed interfaces where “deny by default, allow only when specifically approved” must be enforced.
- [ ] Create an exceptions register that lists, for every allowed data flow, the reason for the exception, the source and destination, the network method and port(s) used, and a reference to the approval that can be traced back.
- [ ] Set a “default deny” rule (a catch-all block) for both incoming and outgoing network traffic on every managed network interface.
- [ ] Implement “allow” rules strictly based on the approved exception catalogue only (do not use broad “allow all” wildcard rules).
- [ ] Set up configuration management and produce audit-ready evidence showing which deployed rules are linked to approved exceptions and the related change records.
- [ ] Run regular “synthetic” connectivity tests to confirm that approved exceptions are permitted and that traffic that is not approved is blocked, including connections to external system destinations.


---

#### SC-7.7 — Split Tunneling for Remote Devices (Enhancement)

This requirement is about preventing remote workers’ devices from using a “workaround” that allows some internet traffic to avoid the organisation’s secure connection while the device is accessing internal systems. If this is not prevented, a device could be tricked into connecting to the wider internet or other places that have not been approved at the same time as it connects to organisational services. This increases the risk of unauthorised access and the theft or leakage of organisational information.

To meet this requirement, the organisation must block split tunnelling by default for any remote device connecting to organisational systems. Split tunnelling must only be allowed when the connection is set up using the organisation’s centrally managed virtual private network (VPN) approach. This approach must use pre-defined, named connection profiles that route traffic only to pre-approved Department of Defense (DoD) networks and only to a fixed list of approved destinations. Users must not be able to change routing or destination choices.

The organisation must also detect any attempt to enable split tunnelling (or any settings that would allow it) and refuse the connection if such an attempt is detected. The organisation must ensure users cannot change these settings.

##### Enforce no-split tunnelling via managed, locked VPN profiles

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define sc-07.07_odp-aligned named VPN profile set (per environment/DoD destination group), including exclusive routing rules and fixed destination allowlists; publish as an approved configuration specification | Compliance Manager | Enterprise | 24h | — |
| Implement VPN gateway enforcement: map each approved named profile to gateway policy; disable/ignore client-provided route injection/split-tunnel settings; terminate/quarantine sessions not using an approved named profile | Network/VPN engineering lead | Enterprise | 56h | — |
| Implement connection-time detection & enforcement: validate profile name at session establishment; detect split-tunnel-capable deviations and enforce refusal/quarantine; document enforcement logic and failure modes | Security Engineer | Enterprise | 40h | — |
| Build locked VPN client configuration package for endpoint management (MDM/UEM): immutable/signed profile, remove user permissions for routing/DNS/split-tunnel changes, enforce allowlist-only behaviour | Platform Engineer | Enterprise | 32h | — |
| Deploy and roll out managed VPN profiles to target device populations (pilot then phased rollout), including change management records and rollback plan | Project Manager | Enterprise | 24h | — |
| Configure audit logging and evidence generation per remote session (identity, device compliance state, VPN profile name, enforced routing/allowlist outcome); integrate with SIEM and define retention/alerting | Operations Lead | Enterprise | 28h | £6,000 |
| Run validation testing and acceptance assurance: test split-tunnel attempts, profile tampering resistance, and session refusal/quarantine; produce audit-ready test evidence pack | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Set up centrally managed, named virtual private network (VPN) split-tunnel profiles that meet requirement sc-07.07_odp by using exclusive routing and fixed destination allowlists, with no user control.
- [ ] Set up the virtual private network (VPN) gateway so it does not accept or follow any “split tunnelling” instructions provided by clients, and so connections use the secure tunnel only by default.
- [ ] Set up the virtual private network (VPN) client configuration through mobile device management (MDM) or unified endpoint management (UEM) as an unchangeable managed profile, and remove users’ ability to edit routing, domain name system (DNS), or split-tunnel settings.
- [ ] Set up checks when a connection starts to confirm the session uses an approved named profile. If it uses a different profile or shows split-tunnelling capable settings, immediately end the session and place it in quarantine.
- [ ] Link virtual private network (VPN) session records to security information and event management (SIEM) so that the system logs the user’s identity, whether the device meets compliance requirements, the selected profile name, and the final destination and routing result that was enforced.
- [ ] Run a test suite to confirm that users cannot enable split tunnelling, and that when using the approved profiles, devices can only reach destinations that have been approved under **sc-07.07_odp**.


---

#### SC-7.8 — Route Traffic to Authenticated Proxy Servers (Enhancement)

This requirement ensures that when staff or systems in your organisation need to reach the internet or other external networks, they do so through your approved and verified proxy servers at the locations you control, rather than connecting out directly. Without this, unauthorised access could go unnoticed, sensitive information could be sent without oversight, and it would be harder to detect and investigate misuse because external activity would not consistently pass through a controlled checkpoint.

To meet this requirement, the organisation must:
- Clearly identify which internal communications are intended for external networks.
- Configure systems so that this traffic is forced to go through the verified proxy at the managed connection points.
- Ensure only authorised users or systems can use the proxy.

The organisation must also:
- Document the boundary approach and how traffic is routed.
- Record which proxy components are used and where they are located.
- Keep evidence that the settings are in place.
- Retain audit records showing that external requests were handled by the proxy.
- Include this approach in the security plan, with named responsibilities for implementation and ongoing oversight.

##### Force external-destined traffic via authenticated proxy at egress

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define SC-7(8) egress policy mapping (covered traffic) including protocol scope, destination sets, and testable rules | Compliance Manager | Enterprise | 16h | — |
| Design proxy egress architecture and forced/proxy-only routing approach (transparent/forced proxy vs explicit enforcement), including managed interface placement and network flow diagrams | System Design Authority | Enterprise | 24h | — |
| Procure and deploy authenticated forward proxy infrastructure at managed egress interfaces (HA where required) and integrate with existing egress tier | Infrastructure Lead | Enterprise | 40h | £45,000 |
| Implement proxy enforcement controls: intercept/redirect or endpoint/network policy plus firewall/route rules to block direct outbound for covered destinations/protocols | Security Engineer | Enterprise | 32h | — |
| Integrate proxy authentication with enterprise IdP (SSO) and configure MFA for interactive users; configure workload/service identity for non-interactive traffic | Data Protection Officer | Enterprise | 24h | — |
| Configure proxy allow/deny destination controls aligned to external network sets and enable detailed logging (auth outcome, client/workload identity, destination, decision/action) | Security Engineer | Enterprise | 24h | — |
| SIEM integration, alerting, and evidence pack: forward logs, define detection for bypass attempts, and produce audit-ready configuration evidence and test results | Operations Lead | Enterprise | 24h | £8,000 |
| Execute validation and acceptance testing across environments (dev/test/prod as applicable), including negative tests for unauthenticated and bypass scenarios | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 208h  
**Total Estimated Cost:** £53,000

###### Actions Required for Compliance

- [ ] Define and publish the “covered egress” policy mapping from {{param:sc-07.08_odp.01}} to {{param:sc-07.08_odp.02}}, broken down by protocol and destination scope.
- [ ] Set up authenticated forward web proxy servers on organisation-controlled managed exit points (demilitarised zone (DMZ) / egress tier).
- [ ] Set up proxy enforcement that is mandatory and cannot be bypassed, so all covered traffic must use the proxy.
- [ ] Set up proxy authentication using the organisation’s identity provider (single sign-on (SSO) plus multi-factor authentication (MFA) for people using the system, and workload identity for services)
- [ ] Set proxy destination allow/deny controls in line with {{param:sc-07.08_odp.02}} and block any destinations that are not authorised.
- [ ] Enable and centrally record proxy session logs in security information and event management (SIEM), including the user identity, the destination, and the outcome of each access decision.
- [ ] Update the system and network security design and security plan, including route diagrams. Keep the configuration records and audit log evidence so they can be reviewed.


---

#### SC-7.9 — Restrict Threatening Outgoing Communications Traffic (Enhancement)

This requirement is about stopping suspicious messages from leaving your organisation and being able to identify exactly which person inside caused them. It helps prevent internal systems being used to attack or harm outside services—for example by overwhelming them with traffic, hiding where the traffic really comes from, or sending harmful code—which could cause service disruption, legal issues, and damage to your reputation.

To meet this expectation, your organisation must monitor outgoing communications at the points where your systems connect to the outside world. It must automatically detect activity that matches your agreed criteria for “threatening” behaviour and immediately block that traffic. For every blocked attempt, you must record which internal user account was responsible and keep those records available for review, so the cause can be audited.

You also need to define, document, and keep up to date the criteria used to spot these threats, along with the procedures, system design, configuration, and the tools involved. You must assign clear responsibility for running the checks and reviewing the results.

##### Identity-aware egress gateway blocks threatening extrusion traffic

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm managed egress coverage: inventory all outbound paths for production/test and document routing changes required to ensure all traffic traverses the egress gateway (including exceptions/approved bypasses) | Infrastructure Lead | Enterprise | 24h | — |
| Implement identity-aware flow tagging at the egress gateway: integrate with enterprise IdP/SSO and configure session/flow metadata enrichment (internal user principal/ID, internal host, device/session identifiers, destination, protocol/port) | Security Engineer | Enterprise | 40h | £25,000 |
| Develop extrusion detection rule set (detection-as-code): implement DoS/excessive-rate, spoofing indicators, and malicious-code indicators using approved threat indicators; include rule identifiers, thresholds, and tuning parameters | Cyber Security Lead | Enterprise | 56h | — |
| Configure enforcement behaviour: set egress gateway to deny/stop transmission only on positive detection match; ensure safe handling for partial matches and allow-list/exception logic with auditability | System Design Authority | Enterprise | 24h | — |
| Build audit record schema and event generation: ensure denied-event logs include required contextual fields (timestamp, internal host, internal user principal/ID, device/session ID, destination, protocol/port, rule ID, action) and are consistent across environments | Compliance Manager | Enterprise | 24h | — |
| SIEM integration and detections: forward egress denial/audit logs to SIEM, create queries/detections for “denied extrusion events by user”, and configure alerting for repeated offenders and high-impact destinations | DevOps Lead | Enterprise | 32h | £8,000 |
| Controlled criteria lifecycle: implement versioned repository for detection rules, enforce review/approval workflow, run non-production test cases, deploy with rollback plan, and produce deployment evidence pack for audit | Project Manager | Enterprise | 40h | £3,000 |
| Operational readiness: update SOC triage runbooks, define escalation/response workflow for denied extrusion events, and conduct acceptance testing with agreed test cases and evidence capture | Service Delivery Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 264h  
**Total Estimated Cost:** £36,000

###### Actions Required for Compliance

- [ ] Define and document the organisation’s approved “managed exit” and boundary points for the application, so that all outgoing (outbound) network traffic is checked at those interfaces.
- [ ] Connect the egress gateway to the organisation’s identity provider (IdP) so that every outgoing connection is labelled with the internal user’s name or ID and the details of the user’s session.
- [ ] Set up rules at the point where traffic leaves the system (the egress layer) to detect denial-of-service (DoS)-like behaviour, signs of spoofing (fake identity), and approved indicators of malicious code.
- [ ] Configure the egress gateway to block outgoing traffic only after a positive extrusion detection decision, and then to stop the flow or session.
- [ ] Set up audit logging so that every denied event records: the internal user identity, the internal host, the destination, the protocol and port, the rule identifier, and the action that was taken.
- [ ] Send outbound traffic denial and audit logs to the security information and event management (SIEM) system, and create alerts and searches for denied data-exfiltration events by user.
- [ ] Set up “detection-as-code” and “policy-as-code” governance for extrusion criteria, including version control, review and approval, testing, deployment, and proof that changes can be rolled back.


---

#### SC-7.10 — Prevent Exfiltration (Enhancement)

This expectation is about preventing sensitive information from leaving your organisation unnoticed—whether someone tries to steal it on purpose or it leaks by accident—and then demonstrating that the protections still work. Without this, confidential data could be sent to unauthorised destinations, which could lead to financial loss, legal issues, reputational damage, or harm to customers and staff.

To achieve this, the organisation must put safeguards in place to stop information being sent out from internal devices, through the organisation’s external connection points, or across managed connections. These safeguards must control the types of outgoing communication that are allowed and must detect unusual “check-in” activity or abnormal sending patterns.

The organisation must also run data-exfiltration tests at least once every quarter to verify both prevention and detection, and keep clear records of what was tested, what the results were, and any fixes required.

##### Quarterly exfiltration prevention tests with egress/DLP enforcement

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define quarterly exfiltration test scope, scenarios (intentional/accidental/beaconing), dataset classifications, approved/blocked destinations, and evidence requirements (test plan template + acceptance criteria mapping to SC-7(10)) | Compliance Manager | Enterprise | 24h | — |
| Implement endpoint/server-side DLP enforcement for supported data types (policy rules, destination restrictions, logging, and block/restrict actions) for the application’s internal endpoints | Security Engineer | Department | 56h | £18,000 |
| Implement egress allowlisting for sensitive workflows (approved domains/IPs/protocols; service account and user-context handling; deny-by-default for unauthorised destinations) | Infrastructure Lead | Department | 48h | £6,000 |
| Add application-layer outbound protocol/format compliance controls (strict schema validation for JSON/XML payloads; reject malformed/unexpected fields; ensure enforcement is applied to all relevant outbound paths) | Software Lead | Team | 40h | — |
| Configure boundary/managed-interface enforcement (e.g., deep packet inspection / XML gateway where applicable) and traffic profile controls to detect volume/type deviations for outbound flows | Security Engineer | Department | 48h | £12,000 |
| Develop SOC detection rules and correlation logic for beaconing, out-of-profile outbound behaviour, and protocol/format anomalies (including identity/session context enrichment and alert triage runbook updates) | Cyber Security Lead | Enterprise | 64h | £10,000 |
| Execute first quarterly exfiltration test cycle in test/staging and production (as approved), capture audit evidence, perform remediation tracking, and produce the evidence pack for compliance sign-off | Project Manager | Enterprise | 72h | — |
| Establish quarterly operating cadence (automation where possible), including test scheduling, regression coverage, evidence retention workflow, and lessons-learned updates to rules/policies | Service Delivery Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 376h  
**Total Estimated Cost:** £46,000

###### Actions Required for Compliance

- [ ] Set up data loss prevention (DLP) rules for the application’s sensitive data on endpoints and servers, and either block unauthorised copying or exporting, or require approval for those destinations.
- [ ] Set up rules that only allow sensitive workflows to send data to approved destinations (specific domain names, Internet Protocol (IP) addresses, and network protocols).
- [ ] Enable checks on outgoing application messages to ensure they follow the required format (for example, strict JSON or XML structure rules), and reject any outgoing messages that do not meet those requirements.
- [ ] Adjust the boundary and managed-interface controls (for example, deep packet inspection firewall rules and XML gateway policies) to ensure traffic follows the correct protocol and to block any traffic that does not comply.
- [ ] Set up security operations centre (SOC) alerts to detect “beaconing” or regular check-in behaviour and unusual outbound network traffic (by volume, type, and frequency, and any new destination addresses).
- [ ] Run quarterly data-exfiltration tests that cover intentional attempts, accidental data leaks, and “beaconing”-like behaviour. Use test data sets and record the results.
- [ ] Review the test results, fix any control weaknesses, and keep the audit evidence for each quarterly testing cycle.


---

#### SC-7.11 — Restrict Incoming Communications Traffic (Enhancement)

This expectation is about putting a strict “who can enter and where they can go” control on your network. It means only approved external partner addresses and your on-premises management subnets are allowed to reach your public-facing services in the demilitarised zone (DMZ) and the specific internal application endpoints you have chosen.

Without this control, unauthorised outsiders could try to access your systems, test for weaknesses, or reach services they were never meant to use. This could lead to data theft, service disruption, or unauthorised changes.

To meet this requirement, the organisation must clearly define and document:
- the approved incoming source address ranges, and
- the approved destination services and endpoints.

The organisation must then configure the boundary protection devices so network traffic is allowed only when the source and destination match the approved combinations. All other traffic must be blocked, including traffic that could be allowed through any forwarding or mapping rules.

The organisation must also keep the relevant records—configuration, design, policy and procedures, security plan, and audit evidence—showing that the “allow” and “block” decisions are enforced and can be reviewed.

##### Default-deny inbound allowlist by source/destination pairs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm authoritative allowlist matrix for (authorised source ranges sc-07.11_odp.01) → (authorised destination endpoints sc-07.11_odp.02), including protocol/port and environment scope (prod/test/DR) | Security Architect | Enterprise | 16h | — |
| Inventory all relevant boundary devices, inbound interfaces/zones, and existing firewall/router rules for the authorised destinations; identify and document any legacy broad permits to be removed/disabled | Cyber Security Lead | Enterprise | 24h | — |
| Implement default-deny inbound policy for authorised destination endpoints with explicit permit rules matching source range + destination endpoint + protocol/port; ensure correct rule ordering and no shadowing | Security Engineer | Enterprise | 40h | — |
| Implement NAT/port-forwarding/external-to-internal routing source restrictions to prevent bypass (mirror source restrictions on forwarding/NAT rules, not only post-NAT firewall rules) | Network Security Engineer | Enterprise | 24h | — |
| Enable source address validation (anti-spoofing/bogon/invalid source rejection) on the relevant inbound interfaces/zones used for partner ingress | Security Engineer | Enterprise | 16h | — |
| Configure audit-grade logging for both allow and deny decisions (source/destination IP, destination port, protocol, action) and forward to SIEM with required fields and retention alignment | SOC / SIEM Administrator | Enterprise | 24h | £3,000 |
| Implement policy-as-code / configuration-as-code for the allowlist ruleset with peer review workflow; produce deployment evidence linking deployed config to the documented matrix | DevOps Lead | Enterprise | 32h | £6,000 |
| Execute change validation: rule hit testing, negative testing (non-authorised sources denied), NAT bypass testing, and evidence pack for audit acceptance criteria | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort**: **220h**  
**Total Estimated Cost**: **£9,000**

###### Actions Required for Compliance

- [ ] Create and maintain an allowlist matrix showing which authorised source Internet Protocol (IP) address ranges are permitted to access which destination endpoints, including the network protocol and port.
- [ ] Set up boundary firewall and router rules so that all incoming traffic is blocked by default, and only allow traffic that matches approved source and destination address pairs.
- [ ] Remove or turn off any wide-ranging inbound rules that would allow network traffic from outside the approved source and destination pairs.
- [ ] Update network address translation (NAT), port forwarding, and forwarding rules to apply the same approved source restrictions from start to finish.
- [ ] Enable boundary checks for incoming traffic on inbound interfaces or zones, including protection against spoofed addresses, rejection of “bogon” (non-routable) addresses, and rejection of invalid source addresses.
- [ ] Set up and centralise logging of both allowed and blocked (deny) decisions, and confirm that the security information and event management (SIEM) system is receiving the logs, so there is audit evidence.
- [ ] Set up the rules using configuration-as-code, with peer review and controlled deployments that follow the change-management process.


---

#### SC-7.12 — Host-based Protection (Enhancement)

This requirement is about putting a protective “gatekeeper” on every device your organisation uses, so unwanted connections are blocked before they can reach your systems. If host-based firewalls are not switched on and correctly set, attackers could test servers, workstations, notebook computers, and phones/tablets and potentially gain access, disrupt services, or steal information.

To meet this expectation, the organisation must install and keep host-based firewall software running on all servers, workstations, notebook computers, and mobile devices, and ensure it remains enabled during normal day-to-day use. The organisation must also document, in clear internal records, which firewall rules and settings are required, how they are configured and kept up to date, and which firewall products are used.

The organisation must be able to demonstrate, using system design records, security plans, configuration records, and audit logs, that the required firewall settings are actually applied on each type of device, including mobile devices. It must also identify any gaps or devices that do not meet the requirements, and provide evidence to support those findings.

##### Enforce host-based firewall baselines on all endpoints

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define authoritative host-based firewall baselines per device type and OS (servers, workstations, notebooks, mobile) including default deny/block, required inbound allow rules, and firewall logging requirements | Security Engineer | Enterprise | 40h | — |
| Create baseline policy artefacts and versioning scheme (e.g., Windows Defender Firewall/Intune profiles, macOS application firewall profiles, Linux host firewall rule sets) with documented change control and rollback approach | Security Engineer | Enterprise | 32h | — |
| Implement central deployment for managed endpoints (Intune/Jamf/Workspace ONE) to install/enable firewall and apply the correct baseline per device type/OS, recording baseline policy version | Platform Engineer | Enterprise | 56h | — |
| Implement EDR policy alignment where available (ensure firewall service state and rule/logging posture are enforced via EDR policy or equivalent) | Cyber Security Lead | Enterprise | 24h | £8,000 |
| Implement mobile device coverage and compensating controls for platforms with limited firewall enforcement (UEM compliance gating, conditional access to applications, and documented exceptions process) | Operations Lead | Enterprise | 24h | — |
| Build drift detection and remediation workflow (continuous checks for firewall enabled/running, expected rule set presence, and logging enabled; auto-remediate or ticket within SLA) | DevOps Lead | Enterprise | 48h | £6,000 |
| Generate audit-ready evidence and integrate with SIEM/log retention (management-plane compliance reports + host firewall enablement/rule-change events; evidence retention mapping) | Compliance Manager | Enterprise | 32h | — |
| Update system design/security documentation to reference enforcement mechanism (management/EDR/UEM), baseline per device type/OS, and evidence locations for auditors | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 272h  
**Total Estimated Cost:** £14,000

###### Actions Required for Compliance

- [ ] Create and get approval for standard host-based firewall settings for each device type and operating system (servers, workstations, notebooks, and mobile devices). This should include a default “deny/block” rule, the specific “allow” rules that are required, and logging.
- [ ] Deploy the approved firewall settings to all managed servers and devices using endpoint management (mobile device management (MDM) / unified endpoint management (UEM)) and/or endpoint detection and response (EDR) policy.
- [ ] Set up mobile device firewall rules using unified endpoint management (UEM) profiles where this is supported, and block access for devices that are not compliant or not managed.
- [ ] Set up ongoing compliance checks to spot when a firewall is turned off and when configurations drift from the agreed baseline, and put in place automated fixes or raise a ticket for follow-up.
- [ ] Store and centralise evidence that firewalls have been enabled and that firewall rules have been changed in the security information and event management (SIEM) or log repository, using device identifiers.
- [ ] Update the system design and security plan documents to name the enforcement method and the baseline configuration for each device.


---

#### SC-7.13 — Isolation of Security Tools, Mechanisms, and Support Components (Enhancement)

This requirement is about keeping the tools your organisation uses to detect threats, check for weaknesses, and support investigations in a separate, tightly controlled part of your internal computer network. The risk it addresses is that if these tools are placed too close to everyday business systems, an attacker could potentially reach them, understand how your investigations work, or use them to move further into your environment.

To meet this requirement, the organisation must:
- identify the specific security monitoring and log analysis tools, vulnerability scanners, and forensic support components that need to be isolated;
- place them into physically separate network sections; and
- connect those sections to the rest of the organisation only through managed, rule-based network connections.

The organisation must also:
- document the design;
- record the network settings that enforce the separation;
- ensure the supporting hardware and software can maintain the separation;
- generate audit records for these isolated tools; and
- include this approach in its security plans and boundary-protection procedures.

Any changes to the setup must be properly approved and evidenced.

##### Physically isolated security tools zone with managed interfaces

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create and maintain the authoritative **sc-07.13_odp register** (hosts/services, interfaces, owners, required inbound/outbound flows, and connectivity rationale) | Compliance Manager | Enterprise | 24h | — |
| Produce the **segmentation architecture** for the physically separate “Security Services Zone” (network diagrams, addressing plan, routing/VRF/switching fabric approach, and physical separation rationale) | System Design Authority | Enterprise | 32h | — |
| Design and implement **managed interface boundary enforcement** (firewall/secure gateway/controlled router ruleset: default deny + explicit allow-list for required flows; interface ownership and logging) | Security Engineer | Enterprise | 48h | £12,000 |
| Implement **network build-out** for the isolated zone (dedicated subnets/VRFs, VLAN/port mapping, uplink/switch configuration, and removal/disablement of any bypass paths such as flat routing, unmanaged peering, or direct tunnels) | Infrastructure Lead | Enterprise | 40h | £25,000 |
| Execute **connectivity and bypass-path validation** (network path testing, rule verification, packet captures where required, and documented test results mapped to sc-07.13_odp flows) | Operations Lead | Enterprise | 24h | — |
| Establish **evidence and change-control operationalisation** (exported firewall/routing configs, architecture pack, change-control templates/approvals for membership/rule changes, and periodic re-validation schedule) | Project Manager | Enterprise | 24h | — |
| Ensure **isolated tools self-audit** (configure/verify that each tool in the zone generates its own audit logs and forwards them via the managed interfaces to approved logging destinations) | Cyber Security Lead | Enterprise | 16h | £3,000 |

| Total Estimated Effort | 208h |  |
|---|---:|---:|
| Total Estimated Cost | — | £40,000 |

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date master list of all security tools and components covered by **SC-07.13 ODP**, including the systems they run on (hosts and services), who is responsible for them (owners), their internet addresses (IP addresses), and the connections they must have.
- [ ] Set up a dedicated, physically separate network zone for the registered tools, with documented rules for IP addressing and routing boundaries.
- [ ] Set up managed network boundary devices between the isolated zone and other internal networks. Use a “deny by default” approach and only permit the specific, required traffic flows using an explicit allow-list.
- [ ] Remove or disable any possible ways to bypass the network controls (for example, direct network routing, unmanaged network switching, direct connections between networks, or temporary ad-hoc tunnels), and document the measures that prevent bypass.
- [ ] Create and keep audit-ready proof (network diagrams, exported firewall and routing settings, details of who owns each network interface, and records of change approvals).
- [ ] Run and record connection and route checks to confirm that only approved managed network interface communications are possible.


---

#### SC-7.14 — Protect Against Unauthorized Physical Connections (Enhancement)

This requirement is about preventing unauthorised people from physically connecting to, or interfering with, the network connection points hidden in equipment rooms and wiring closets. Without clear protection, someone could quietly redirect or intercept communications by plugging cables into the wrong place. This could disrupt services or expose information.

To meet this requirement, the organisation must keep a documented list of the specific patch panels, fibre and copper cable routes, and managed connection ports that are in scope. These must be clearly labelled and physically separated for each managed connection, so cables and connections for different connections are not mixed.

Access to these areas and connection points must be limited to authorised personnel only. This should be done using locked doors, controlled entry, and locked or covered patch panel and connection frames where needed.

The approach must be written down, kept up to date, and aligned with the site wiring diagrams. The organisation must also keep records showing the protections are in place and that access is granted and removed appropriately.

##### Segregate and lock managed-interface patching and cable routes

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce authoritative in-scope managed-interface physical inventory (per equipment room/wiring closet) with unique IDs for patch panels, tray sections/routes, and managed interface ports; align to site wiring diagrams and confirm ownership boundaries | Infrastructure Lead | Enterprise | 40h | — |
| Perform physical site survey and segregation gap assessment for each managed interface (identify co-mingling risks, missing barriers/partitions, non-unique patch areas, and uncontrolled access points) | Security Engineer | Enterprise | 24h | — |
| Design and implement physical segregation of cable pathways per managed interface (dedicated/partitioned tray sections, tray barriers/partitions, and route separation) and update as-built documentation | Infrastructure Lead | Enterprise | 48h | £18,000 |
| Design and implement patching infrastructure separation per managed interface (distinct patch panel areas or locked/partitioned patch frames/cabinets; protective covers over unused ports where applicable) | Operations Lead | Enterprise | 56h | £22,000 |
| Install durable point-of-use identification (labels at tray entry/exit where practical and at connection frames/patch panel port blocks) and define label standards (font/format/material) to ensure legibility during inspections | Compliance Manager | Enterprise | 16h | £2,500 |
| Implement and verify limited authorised physical access controls (locked doors for rooms/closets; lock management process; locked patch panel/cabinet doors or covered frames; maintain authorised access list) | Facilities/Physical Security Manager | Enterprise | 32h | £6,000 |
| Establish audit-ready evidence pack and inspection routine (quarterly inspection checklist, evidence storage process, reconciliation to inventory, and remediation workflow for label/lock/partition findings) | Compliance Manager | Enterprise | 24h | — |
| Conduct initial inspection cycle and remediate findings until acceptance criteria are met for 100% of in-scope managed interfaces | Operations Lead | Enterprise | 24h | £3,000 |

**Total Estimated Effort:** 264h  
**Total Estimated Cost:** £51,500

###### Actions Required for Compliance

- [ ] Define and get approval for the list of managed interfaces that are in scope (patch panels, tray sections/routes, and managed interface ports), and assign each one a unique identifier for every equipment room and wiring closet.
- [ ] Redesign the cable routing so that each managed network connection uses its own dedicated (or separated) cable tray sections or routes, with physical barriers to stop cables being accidentally connected to the wrong place.
- [ ] Set up patching infrastructure in physically separate, clearly labelled patch panel areas, or use locked and partitioned patch frames for each managed network connection.
- [ ] Fit locked doors to patch panels or cabinets, and/or use locked or covered patch frames. Where possible, also add protective covers over any unused managed network interface ports.
- [ ] Apply long-lasting labels at each patch panel port block and connection frame (and, where practical, at the tray entry and exit points). Each label should reference the managed interface ID.
- [ ] Ensure only authorised people can physically access equipment rooms and wiring closets, and the protected patching infrastructure, using an approved access list and lock and key management.
- [ ] Carry out and record regular inspections to confirm that separation barriers are intact, labels are readable, and locks or covers are in good condition, based on the managed interface inventory that is in scope.


---

#### SC-7.15 — Networked Privileged Accesses (Enhancement)

This requirement is about ensuring that any remote access to important systems with high privileges goes through one controlled entry point, rather than connecting directly to the target system. Without this, if an attacker gains remote administrative access, they could more easily misuse powerful functions, steal sensitive information, or disrupt critical services. It would also be harder for the organisation to show what happened.

To meet this expectation, the organisation must clearly define what counts as privileged access and what counts as network-based access. It must then route all remote privileged requests through a dedicated managed access point that controls who can connect and to which systems.

This same entry point must also keep a reliable record (log) of every attempt, whether it succeeds or fails, with enough detail to review later. The organisation must be able to retrieve these records for the required period and follow a defined process to regularly review them.

##### Broker all networked privileged access via managed PAM interface

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm SC-7(15) scope: define “network-based privileged access” and “privileged targets” inventory (incl. protocol list, environments, exclusions for local console) | Compliance Manager | Enterprise | 24h | — |
| Design target routing architecture: define dedicated PAM management network segment, gateway placement, session flow diagrams, and required connectivity matrix (gateway→target only) | System Design Authority | Enterprise | 32h | — |
| Procure/enable managed PAM gateway capability (licenses/subscriptions and any required hardened jump host appliances/VMs) | Project Manager | Enterprise | 8h | £120,000 |
| Build PAM gateway environment: deploy/configure hardened gateway/jump interface, integrate with IdP/SSO, set up role/least-privilege templates, and implement session brokering for SSH/RDP/remote console/web admin | Security Engineer | Enterprise | 56h | £20,000 |
| Enforce no-bypass connectivity: implement firewall/ACL/security group rules to block privileged protocol/ports from user subnets to in-scope targets; allow only gateway-to-target flows; validate with connectivity testing | Infrastructure Lead | Enterprise | 40h | £15,000 |
| Configure audit logging and SIEM forwarding: enable success/failure audit events with required fields (user, source, target, session type/action, timestamp, outcome, denial reason), ensure log integrity, and implement alerting for denied attempts | Operations Lead | Enterprise | 32h | £10,000 |
| Establish retention, evidence packs, and review workflow: set log retention, create SOC review dashboards/runbooks, and define ticket-linked evidence retrieval process for investigations and audits | Data Protection Officer | Enterprise | 24h | — |

**Total Estimated Effort:** 216h  
**Total Estimated Cost:** £165,000

###### Actions Required for Compliance

- [ ] Define and document what counts as privileged access and what counts as network-based access for this environment.
- [ ] Set up and secure a dedicated privileged access management (PAM) gateway/jump interface, and register all systems and accounts that privileged users can access.
- [ ] Set up network firewall and access control list (ACL) rules to block privileged network protocols from reaching the target systems, except when the traffic comes through the privileged access management (PAM) interface.
- [ ] Set up privileged access management (PAM) rules for identity-based authorisation, approved target allow-listing, and restrictions on where requests can come from
- [ ] Enable privileged access management (PAM) session brokering so privileged sessions are set up only through the managed interface.
- [ ] Connect privileged access management (PAM) audit events to the organisation’s security information and event management (SIEM) system, and make sure the logs record both successful and failed access attempts.
- [ ] Set up a regular review schedule for audit records of privileged access, including capturing supporting evidence.


---

#### SC-7.16 — Prevent Discovery of System Components (Enhancement)

This requirement is about protecting the “front door” systems that let staff connect in a controlled way from being easily found by outsiders. If an attacker can learn the exact network locations of these managed interface components, they can target them directly using common scanning and device-finding tools. This increases the risk of unauthorised access or disruption.

To meet this expectation, the organisation must first identify which specific components act as managed interfaces. It must then decide what information must not be discoverable—especially their network locations—and ensure those locations are not published in public places, not listed in public naming records, and not directly reachable in a way that reveals internal details.

Where appropriate, the organisation should hide internal locations behind translated addresses and ensure direct routing to the internal locations is not possible. It must also periodically change the relevant addresses, implement these protections using real technical settings, keep clear records of what was done and when, and test from outside to confirm that outsiders cannot discover or reach the managed interfaces.

##### Hide managed-interface endpoints via NAT, controlled routing and external tests

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce managed-interface inventory and external translation mapping (internal IP/port, required external endpoints, NAT/translation method, owning service, and access justification) | Compliance Manager | Enterprise | 24h | — |
| Design boundary NAT / DNAT-SNAT and routing approach for managed interfaces (including firewall/security-group rule model and redirect/error-handling constraints to avoid internal addressing leakage) | System Design Authority | Enterprise | 32h | — |
| Implement boundary NAT and controlled routing (edge firewall/load balancer/reverse proxy configuration) for each managed-interface translation endpoint | Infrastructure Lead | Enterprise | 56h | £8,000 |
| Validate and harden inbound allow-listing (deny-by-default, explicit port/service exposure only, ensure no internal IPs/ports appear in banners, headers, redirects, error pages, or logs exposed externally) | Security Engineer | Enterprise | 24h | — |
| Control DNS exposure and naming indirection (ensure external DNS resolves only to translation endpoints; remove/avoid any internal managed-interface addresses in public DNS, external docs, and external config repos) | Cyber Security Lead | Enterprise | 20h | — |
| (Optional where feasible) Implement internal address rotation/ephemeral strategy for managed interfaces and update inventory/automation to maintain authorised access without breaking translation endpoints | Platform Engineer | Enterprise | 24h | £3,500 |
| Execute external discovery testing and produce audit-ready evidence pack (approved scanning/discovery from non-authorised network perspective; capture date/time, tool/source, findings, and remediation outcomes) | Quality Assurance Lead | Enterprise | 28h | £2,500 |

Total Estimated Effort: **208h**  
Total Estimated Cost: **£14,000**

###### Actions Required for Compliance

- [ ] Identify and record each managed network interface component and how its internal Internet Protocol (IP) address and port are mapped to an external translation endpoint.
- [ ] Set up boundary network address translation (NAT) so that outside users can reach only the translated endpoints. Ensure the internal managed-interface Internet Protocol (IP) addresses are not directly reachable from outside.
- [ ] Set inbound firewall and security-group rules to “deny by default” and allow only the required translated services and ports to the managed-interface translation endpoints.
- [ ] Remove any internal managed network interface Internet Protocol (IP) addresses and port numbers from all public-facing documentation, dashboards, and external configuration files.
- [ ] Make sure public Domain Name System (DNS) records for managed interfaces point only to the boundary translation endpoints (and not to internal addresses).
- [ ] Set up and carry out a regular internal process to change network addresses where possible (for example, using temporary systems or planned address changes), while ensuring that authorised access is not disrupted.
- [ ] Carry out external discovery tests and keep the results to show that internal managed interface addresses and ports cannot be found or reached from a non-authorised network.


---

#### SC-7.17 — Automated Enforcement of Protocol Formats (Enhancement)

This requirement is about making sure every message your systems receive has the exact expected structure and follows the required rules before the message is allowed to be used. Without this, attackers or faulty partners could send incorrect or unexpected messages that get through, which could expose weaknesses or cause systems to work incorrectly.

To meet this expectation, the organisation must set up and run automated checks at the application level (for example, through an XML or message gateway) that review all relevant messages between users and between systems. The checks must reject or flag anything that does not match the required format, including problems that lower-level network checks might not catch.

The organisation must document how these checks are built into the system design, define the required message rules, configure the system so the checks are clearly active, and keep audit records showing what was blocked or flagged and why, for the required retention period. It must also ensure named roles and developers are able to support running these checks, and be able to show they work using evidence from configuration and audit logs.

##### Schema-enforcing API/XML gateway for protocol format validation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Confirm in-scope boundary routes and message types (API endpoints, XML services, partner/vendor integrations, alternate paths) and produce an enforcement coverage matrix | Project Manager | Enterprise | 16h | — |
| Define and maintain authoritative protocol contracts: OpenAPI schemas for REST/JSON and XSD/Schematron rules for XML (including required fields, enums, cardinality, and structural/business constraints) | Security Engineer | Department | 56h | — |
| Configure gateway strict validation behaviour and deterministic handling (reject/flag outcomes, HTTP/XML error mapping, consistent error body rules that avoid sensitive detail leakage) | Infrastructure Lead | Business Unit | 40h | — |
| Implement auditable logging and SIEM forwarding (enforcement component identifier, endpoint/service, message type, blocked/flagged outcome, reason category; access controls and retention alignment) | Operations Lead | Enterprise | 32h | — |
| Build version-controlled ruleset/schema deployment pipeline with CI/CD and automated regression tests (valid and intentionally malformed payloads; peer review gates) | DevOps Lead | Enterprise | 48h | — |
| Run evidence generation and operational validation (test execution in test/stage, periodic malformed-payload checks, confirm audit records are generated and accessible in SIEM) | Compliance Manager | Enterprise | 24h | — |
| Produce operational runbooks and change management artefacts (configuration management, rollback approach, alerting thresholds, exception/waiver process for non-conformant partners) | Service Delivery Manager | Business Unit | 24h | — |

**Total Estimated Effort:** 240h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Identify all in-scope user and system-to-system communication protocols, and map each one to the gateway boundary enforcement point.
- [ ] Create or update the official protocol definitions (schemas/contracts) for every in-scope message type: use **OpenAPI** for **JSON/representational state transfer (REST)** messages, and **XML schema definition (XSD)** and **XML schema language for validation (Schematron)** for **XML** messages.
- [ ] Set up the application programming interface (API) gateway and the XML gateway to check that incoming requests strictly match the required format and agreement (schema/contract) before the request is sent for processing by the backend systems.
- [ ] Use consistent, predictable handling for rule violations (either reject them or flag them) and standardise error messages so they do not reveal sensitive information.
- [ ] Set up and centralise audit logs for enforcement outcomes, including the reason categories. Then check that security information and event management (SIEM) forwarding is working correctly and that the logs are kept for the required retention period.
- [ ] Set up version-controlled gateway rule sets and data schema files, and deploy them using continuous integration and continuous delivery (CI/CD) with automated tests that check for incorrectly formed (malformed) data payloads.


---

#### SC-7.18 — Fail Secure (Enhancement)

This requirement is about making sure that if a key security control (such as a router, firewall, or application gateway) fails or stops working, the systems behind it do not suddenly become exposed or act in an unsafe way. Without this, a failure could accidentally allow outsiders to gain access, or could cause unauthorised information to be released, weakening the protections the organisation relies on to keep data and services safe.

To meet this expectation, the organisation must clearly define what “safe on failure” means for each protected network boundary, document what staff should do when the device fails, and specify which network connections are covered. The organisation must design and configure its systems so that, during the device failure, the intended protections still work—external access is blocked and unauthorised release is prevented. It must also keep evidence by recording and reviewing failure events, ensuring the approach is included in the security plan, assigned to named roles, and tested so that the logs show the secure outcome during and after the failure.

##### Fail-secure boundary enforcement with fail-closed defaults and HA

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define fail-secure semantics per boundary type/zone (Internet→DMZ, DMZ→internal, inter-zone) including prohibited “unsecure states” and required deny/drop behaviours | System Design Authority | Enterprise | 16h | — |
| Produce boundary device configuration baseline for fail-closed defaults (deny/drop inbound & inter-zone, remove/disable permit-on-error/bypass-on-failure, validate policy enforcement cannot degrade to allow-by-default) | Security Engineer | Department | 24h | — |
| Implement HA for boundary enforcement (active/standby or equivalent), configure health checks and failover conditions to ensure policy enforcement remains active; document failover behaviour and timing | Infrastructure Lead | Business Unit | 32h | £8,000 |
| Implement controlled routing/forwarding to prevent bypass during failure (static routes with change control or authenticated/directed dynamic routing; validate no unintended direct paths when boundary nodes fail) | Network Security Lead | Enterprise | 24h | — |
| Enable and standardise evidence collection (interface state changes, policy deny/drop events, session outcomes) and integrate with SIEM; create correlation rules for “boundary failure → blocked traffic / no unauthorised release” | Security Operations Lead | Department | 20h | £3,500 |
| Execute controlled failure drills per managed interface (service stop, interface down, HA failover) and verify authorised flows remain constrained while unauthorised flows are denied/timeout; record results for audit readiness | Project Manager | Business Unit | 24h | — |
| Produce compliance pack (design decisions, configuration evidence, SIEM rule outputs, drill results, residual risk and operational runbook updates) | Compliance Manager | Enterprise | 16h | — |

Total Estimated Effort: **156h**  
Total Estimated Cost: **£11,500**

###### Actions Required for Compliance

- [ ] For each managed interface or zone in scope (including the demilitarised zone (DMZ) boundaries and protected subnetworks), define: (1) what “fail-secure” means, and (2) which unsafe states are not allowed.
- [ ] Configure boundary devices to block all traffic by default (deny/drop), and remove or disable any settings that allow traffic when errors occur or that bypass controls when failures happen.
- [ ] Set up high availability (HA) for boundary enforcement and configure health checks so that failover happens only when policy enforcement is active.
- [ ] Confirm that routing and forwarding cannot get around the security boundary during a failure, so there are no unintended direct paths to protected subnetworks.
- [ ] Keep and use logs for boundary failure events, changes in interface status, and cases where policies block or drop traffic; send these logs to a security information and event management (SIEM) system for correlation.
- [ ] Run controlled failure tests (stop the service, take the interface offline, and switch over using high availability) and record the results to confirm that unauthorised access and unauthorised release of information do not happen.


---

#### SC-7.19 — Block Communication from Non-organizationally Configured Hosts (Enhancement)

This requirement is about preventing instant messaging and video-calling software that individual users or outside service providers install from connecting to your organisation’s network, unless your organisation has explicitly approved that software for a specific, permitted purpose. Without this, someone could install an unapproved messaging or calling app and use it to leak information, receive unwanted messages, or connect to services your organisation has not checked—creating an easy route for data loss or unwanted access.

To meet this expectation, your organisation must maintain an up-to-date list showing which instant messaging and video conferencing clients are independently set up versus which ones are approved by the organisation for authorised uses. The organisation must then enforce rules that block both incoming and outgoing messages and calls for the independently configured clients.

Your organisation must also document how this protection is applied, keep evidence that the blocking took place, and include this approach in its system plans so it can be demonstrated and applied consistently.

##### Default-deny IM/video traffic for non-approved clients (inbound/outbound)

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define SC-7(19) enforcement scope for IM/video (inbound + outbound), including parameter mapping to `sc-07.19_odp`, traffic types (signalling/media), and enforcement boundaries | Compliance Manager | Enterprise | 8h | — |
| Create and version the authoritative allowlist of organisation-approved IM/video clients and managed configuration profiles (approved app builds, managed tenant/account, approved destination patterns) with change-control workflow | Compliance Manager | Enterprise | 16h | — |
| Implement endpoint/client classification logic at the boundary using available enterprise signals (device posture, user group, application identity from secure gateway/proxy telemetry) and default to “independently configured” when not matching allowlist | Security Engineer | Enterprise | 32h | — |
| Configure edge enforcement (application-aware firewall / secure web gateway / cloud firewall / ZTNA) with bidirectional default-deny rules for non-approved IM/video clients, plus explicit allow rules for approved clients and approved destinations | Network/Security Lead | Enterprise | 40h | £25,000 |
| Configure audit logging for both denied inbound and denied outbound attempts (timestamp, source/destination, client/app identity signal used, rule matched, action=deny) and integrate with SIEM with required retention tagging | Security Engineer | Enterprise | 24h | £6,000 |
| Build test plan and run validation (approved client connectivity succeeds within allowed destinations; non-approved clients have inbound/outbound blocked; verify log fields and rule-match evidence) across representative environments | Quality Assurance Lead | Enterprise | 24h | — |
| Operationalise governance: update runbooks, monitoring/alerting for deny spikes, and establish periodic allowlist review cadence with evidence pack generation for audits | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 160h  
**Total Estimated Cost:** £31,000

###### Actions Required for Compliance

- [ ] Define and publish an organisation-approved list of allowed internet messaging and video clients, along with the managed configuration profiles for each client.
- [ ] Set up device and user classification at the network edge using device status, user group, and the available application identity information.
- [ ] Set up edge enforcement (application-aware firewall, secure gateway, and zero trust network access (ZTNA)) to block by default (default-deny) any instant messaging (IM) and video traffic that is not approved, for both incoming and outgoing connections.
- [ ] Where possible, create clear “allow” rules only for IM and video clients that the organisation has approved, and for approved destinations or tenants.
- [ ] Turn on and centralise logging for blocked incoming and blocked outgoing instant messaging and video connection attempts, including the rule-matching details needed for audit evidence.
- [ ] Set up a change control process so that when new authorised clients or destinations are approved, the allowlists, enforcement rules, and test cases are updated.


---

#### SC-7.20 — Dynamic Isolation and Segregation (Enhancement)

This requirement is about being able to quickly and selectively stop specific outside services and supplier connections from reaching the rest of your systems when you need to, without shutting everything down.

In real life, the risk is that an external service of uncertain origin—or one that becomes compromised or malfunctions—could connect back into your internal systems and cause wider damage. This increases the chance of data loss or service disruption.

To meet this expectation, the organisation must:
- Keep a clear, up-to-date list of the exact third-party services and other externally sourced components that must be isolated.
- Document how isolation will work in practice, including which connections or data exchanges are blocked.
- Ensure the system can apply and remove this separation as needed during normal operations.
- Have written procedures that match its boundary protection approach.
- Configure and document the relevant settings.
- Include this information in its security planning and architecture records.
- Keep audit evidence showing when isolation actions (and any reversals) are carried out by authorised people or systems.

##### Dynamic quarantine of third-party integrations via policy enforcement

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish authoritative third-party integration isolation inventory (per integration: identity, endpoints, protocols/ports, enforcement points, quarantine scope) | Security Architect | Enterprise | 40h | — |
| Define quarantine state model and policy profiles (default deny + scoped exceptions, including health-check/monitoring allowances) with safe rollback semantics | System Design Authority | Enterprise | 32h | — |
| Design and implement enforcement integration with centrally managed policy (ZTNA/SASE and/or firewall/egress gateway; optional service mesh/app gateway layer where applicable) | Infrastructure Lead | Enterprise | 56h | — |
| Build dynamic quarantine control plane (runtime toggle, incident trigger interface, automated rollback to last known-good approved policy) | Platform Engineer | Enterprise | 72h | — |
| Implement auditability and SIEM event forwarding (enable/disable events with integration identifier, affected scope, timestamp, actor identity; correlation with change records) | Compliance Manager | Enterprise | 32h | — |
| Develop operational runbooks and governance artefacts (security planning/architecture documentation, approval workflow for exceptions, testing/verification steps) | Project Manager | Enterprise | 24h | — |
| Execute integration testing and evidence capture for acceptance criteria (quarantine enable/disable validation across environments; produce audit-ready evidence pack) | Quality Assurance Lead | Enterprise | 40h | — |

**Total Estimated Effort:** 296h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create an isolation inventory that maps each `{{ param, sc-07.20_odp }}` integration to the identities involved, the devices (endpoints) used, the communication methods (protocols and ports), and the places where controls are enforced.
- [ ] Set up a separate quarantine state for each integration (block everything by default, with only explicitly approved exceptions) and document how the isolation works.
- [ ] Set up centrally managed, run-time switchable policy controls for each integration (for example, zero trust network access (ZTNA) / secure access service edge (SASE) and outbound traffic firewall and DNS controls).
- [ ] Automate turning isolation on and off, with a safe rollback to the last approved policy profile
- [ ] Set up security information and event management (SIEM) audit logs for every time an isolation feature is turned on or off, recording the integration identity, scope, time of the event, and the identity of the person or system that caused it.
- [ ] Publish and keep up-to-date operational runbooks, and update security planning and architecture records to reflect the isolation capability.


---

#### SC-7.21 — Isolation of System Components (Enhancement)

This expectation is about placing the organisation’s most important computer systems into separate, protected areas so they cannot freely communicate with each other. It matters because if mission systems, the databases they depend on, and the tools used to manage and monitor them can all be reached from the same places, an attacker—or a serious mistake—could move from one area to another, spread harm, or access sensitive information more easily.

To meet this requirement, the organisation must clearly identify and document which mission application servers, database servers, and management or administrative access points need to be separated, and explain that the aim is to prevent unauthorised information moving between them while still allowing stronger protection for the most critical systems. It must then use suitable boundary protection—such as firewalls, gateways, or equivalent network separation—to limit the allowed communication routes so that only authorised connections are possible. The organisation must also record how this separation is designed, set up, and managed in its security plans and procedures.

Finally, it must keep evidence that the separation is actually enforced and regularly reviewed, including audit records showing activity related to boundary protection.

##### Zone-based boundary protection for mission, database, and admin

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce zone/component isolation design: map mission app servers, database servers, and management/admin interfaces to dedicated zones (subnets/VLANs) and define the required information-flow matrix per mission/business function | System Design Authority | Enterprise | 24h | — |
| Define boundary protection architecture and choke-point placement (routers/gateways/firewalls or equivalent cross-domain devices), including routing/segmentation approach for production and non-production where applicable | Infrastructure Lead | Enterprise | 20h | — |
| Implement firewall/gateway rule sets with deny-by-default and explicit allow rules for required cross-zone flows (Mission→Database; Management→Operational endpoints), including protocol/port/service scoping and source/destination restrictions | Security Engineer | Enterprise | 40h | £12,000 |
| Harden management zone controls: restrict management access to dedicated admin subnet/jump host, limit protocols, and enforce only required management agents/services to operational components | Security Engineer | Enterprise | 16h | £6,000 |
| Validate enforcement via technical testing and evidence capture: confirm blocked lateral paths, verify allowed flows, perform rule review against the traffic matrix, and produce test results suitable for audit | Quality Assurance Lead | Enterprise | 24h | — |
| Establish operational governance for boundary rules: versioned change process, periodic review schedule, and ownership model for zone mappings and rule maintenance (including change records templates) | Compliance Manager | Enterprise | 16h | — |
| Create audit-ready documentation pack: zone/component mapping, boundary design diagrams, current firewall/gateway rule exports, approvals, and periodic review evidence | Project Manager | Enterprise | 12h | — |

Total Estimated Effort: **152h**  
Total Estimated Cost: **£18,000**

###### Actions Required for Compliance

- [ ] Document which mission application servers, database servers, and management or administrative interfaces are located where on the network, and what each one is responsible for.
- [ ] Set up security zones for (1) mission processing, (2) storing and retrieving data, and (3) system administration and monitoring.
- [ ] Set up boundary protection (firewalls, gateways, and cross-domain devices) at every zone boundary, so that all traffic moving between zones must pass through that boundary.
- [ ] Set “deny by default” rules and add explicit “allow” rules only for the required ports and network protocols between each zone.
- [ ] Limit access to the management zone to only approved source computers (for example, jump servers, bastion hosts, or administrative collectors) and only the management and monitoring endpoints that are required.
- [ ] Publish and keep the current firewall and gateway rule sets, the required traffic matrix, and approved change records (with versions) as audit evidence.
- [ ] Carry out an initial and regular review (with supporting evidence) to confirm that the boundary rules still match the defined missions or business functions and the required data flows.


---

#### SC-7.22 — Separate Subnets for Connecting to Different Security Domains (Enhancement)

This requirement is about keeping different types of information in separate “network areas” so they cannot be mixed up by accident. In everyday terms, it means systems that handle different security levels—such as more sensitive information versus less sensitive information—must not use the same network space. Instead, each security level must have its own separate network segment.

Without this separation, a device that handles sensitive information could become reachable from the wrong part of the organisation. This increases the risk of unauthorised access, data being leaked, or mistakes spreading from one area to another.

To meet this expectation, the organisation must:
- identify which systems belong to each security domain,
- set up separate subnets for each domain, and
- ensure systems use the correct subnet.

The organisation must also document the network design, how protection is applied at the boundaries between these areas, the relevant system architecture and configuration settings, and keep records showing the separation is in place and remains correct over time. These documents must be available for review.

##### Separate subnets per security domain with enforced routing

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm security domain model and produce domain-to-system mapping (incl. presentation/application/data/admin/integration/vendor access points) | Compliance Manager | Enterprise | 16h | — |
| Create authoritative non-overlapping IP/subnet plan per security domain (CIDR allocation, gateways, routing boundaries, VRF/VLAN/VPC mapping where applicable) | System Design Authority | Enterprise | 24h | — |
| Design and implement L3 boundary enforcement (default-deny inter-domain; explicit allow rules using source/destination subnet ranges; include load balancer/L7 pass-through constraints where relevant) | Security Engineer | Enterprise | 40h | £12,000 |
| Configure system network placement to domain subnets (NIC/interface IPs, subnet masks, gateways; validate VRF/VLAN/VPC attachment and prevent unintended cross-domain adjacency) | Infrastructure Lead | Enterprise | 32h | — |
| Produce audit-ready documentation pack (network diagrams, IP plan, domain-to-subnet mapping, approved traffic flows, boundary enforcement point descriptions) | Compliance Manager | Enterprise | 16h | — |
| Establish evidence capture and drift detection (automated exports of boundary rule sets and network baselines; scheduled checks for subnet assignment/rule reference drift; link to change records) | DevOps Lead | Enterprise | 24h | £8,000 |
| Run implementation validation and acceptance testing (connectivity tests per approved flows; negative tests for default-deny; evidence of test results and remediation actions) | Quality Assurance Lead | Enterprise | 16h | — |

**Total Estimated Effort:** 168h  
**Total Estimated Cost:** £20,000

###### Actions Required for Compliance

- [ ] Identify and record the security responsibilities for each part of every application (the user interface, application logic, data, administration, integrations, and access for vendors).
- [ ] Create a non-overlapping Internet Protocol (IP) address plan that maps each security domain to its own dedicated subnets.
- [ ] Set up Layer 3 boundary controls (firewalls, routers, and virtual routing and forwarding instances) to block all traffic by default and only permit traffic that matches clearly defined source and destination subnet ranges.
- [ ] Update the system’s network settings so that each component connects only to the network range (subnet) for its own domain, using the correct interface and gateway.
- [ ] Create an audit-ready network diagram and IP address plan that show which domain maps to which subnet, and list the approved traffic routes between domains.
- [ ] Carry out checks for configuration drift (unexpected changes) and keep evidence exports—such as boundary rules, virtual routing and forwarding (VRF) and virtual local area network (VLAN) mappings, and system network baselines—linked to the relevant change records.


---

#### SC-7.23 — Disable Sender Feedback on Protocol Validation Failure (Enhancement)

This requirement is about keeping your system from giving information back when it receives a badly formed message. If an incoming message does not follow the expected format, the organisation must not send any reply or explanation back to the sender about why it was rejected.

This matters because detailed rejection messages can help attackers understand how your message checks work, making it easier for them to create messages that get through.

To meet this requirement, the organisation should put in place entry-point protections and related procedures so that “no feedback” is given for message format problems only, not for other types of errors. This behaviour must be built into the relevant software or hardware at the system boundary.

The organisation should also clearly document this approach in its security policy, boundary protection procedures, system design and architecture, and record the exact configuration settings.

Finally, it must keep audit records showing that malformed messages are handled without validation-specific feedback, while correctly formed messages still receive the normal outcome.

##### Silent reject protocol-format failures at boundary

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Inventory and map all externally reachable boundary entry points (HTTP(S), webhooks, reverse proxy/LB/WAF, any SMTP/IMAP ingestion) and document current failure/response behaviours | Project Manager | Enterprise | 24h | — |
| Define “protocol format/structure validation failure” classification and scope rules (what is suppressed vs what is preserved) and produce an implementation-ready boundary handling specification | Compliance Manager | Enterprise | 16h | — |
| Configure boundary components to suppress validation feedback for protocol-format failures (e.g., generic/empty HTTP responses, connection close for framing issues, disable schema/parse diagnostics leakage) and ensure enforcement occurs before application-layer error handling | Infrastructure Lead | Enterprise | 40h | £6,000 |
| Implement boundary-level audit logging for suppressed protocol-format failures (source IP, endpoint, timestamp, protocol, coarse classification) and integrate with SIEM/observability with appropriate retention and access controls | Security Engineer | Enterprise | 24h | £3,000 |
| Update/verify error-handling paths to prevent validation-specific redirect/error-page rendering and confirm no validation hints are emitted by downstream components (including any API management layers) | Operations Lead | Enterprise | 16h | — |
| Execute automated negative/positive tests across environments (malformed JSON, invalid content-type, missing structural elements, invalid framing) and produce evidence pack (test reports + configuration exports/screenshots) | Quality Assurance Lead | Enterprise | 32h | — |
| Run go-live readiness review and change management sign-off (including rollback plan) to ensure behaviour is consistent across production and disaster recovery | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 168h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Identify and list every external entry point the application can be reached through, including the protocols used.
- [ ] Configure the API gateway, web application firewall (WAF), and reverse proxy to detect protocol format and structure validation failures at the edge (before requests reach internal systems).
- [ ] For failures during format or structure checks at the edge, either silently reject the request or return a fixed, generic rejection message with an empty or non-descriptive response body.
- [ ] Remove or disable any validation-specific error messages, redirects, or improved error templates that could be triggered by malformed inputs.
- [ ] Set up internal audit logging to record protocol format validation failures, while not revealing the specific validation rules to the sender.
- [ ] Run both negative and positive test cases to confirm that no validation-specific messages are returned, and that valid requests still complete successfully.


---

#### SC-7.24 — Personally Identifiable Information (Enhancement)

This expectation is about making sure that any system that handles people’s personal information is used in a controlled, approved way, and that the information is protected from misuse. Without these rules, personal data could be collected for the wrong reasons, accessed by the wrong people, sent or stored insecurely, kept longer than necessary, or shared in ways that breach privacy commitments—causing real harm to individuals and creating legal and reputational risk for the organisation.

The organisation must apply approved handling rules to every type of personal information it processes: collect, use, store and share it only for authorised purposes; protect it by encrypting it both while it is being transferred and while it is stored; allow access only to the minimum permissions needed; record and review every access; keep it only for the time set out in policy; and delete it when it is no longer needed.

It must also monitor that only permitted processing happens at the system’s entry and exit points and at key internal handover points, document any exceptions, and regularly review and remove exceptions that are no longer supported.

##### Enforce approved PII processing rules with monitored exceptions

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce and maintain PII inventory and data-flow map (PII types, collection/storage/processing/disclosure, interfaces/flows) with traceability to application components | Data Protection Officer | Enterprise | 40h | — |
| Define machine-enforceable “PII processing rules” (authorised purpose mapping, TLS/at-rest encryption requirements, least-privilege constraints, audit logging requirements, retention/deletion windows) and publish as version-controlled policy artefacts | Compliance Manager | Enterprise | 32h | — |
| Implement technical enforcement at system boundaries (API gateway/WAF rules for TLS-only, block weak/non-TLS, detect unauthorised PII destinations/operations; generate auditable allow/deny events) | Security Engineer | Department | 56h | £18,000 |
| Implement technical enforcement for internal handover points (instrument message bus/queues, ETL/replication/export services; enforce/validate permitted PII flows against the authorised-purpose mapping; produce evidence logs) | Platform Engineer | Department | 48h | £10,000 |
| Implement encryption-at-rest and key management controls for PII stores (database/object storage encryption configuration, enterprise KMS integration, validation across environments) | Infrastructure Lead | Department | 40h | £12,000 |
| Implement least-privilege access controls for PII processing paths (RBAC/ABAC mapping to enterprise identity, service account scoping, privileged action controls with just-in-time/conditional access where supported) | Security Engineer | Department | 48h | £6,000 |
| Implement retention/deletion/anonymisation automation with verifiable evidence (TTL/partitioning, object lifecycle policies, scheduled deletion jobs, reconciliation reports) | Operations Lead | Department | 40h | £8,000 |
| Build exception workflow and cadence review mechanism (time-bound policy overrides/feature flags, approval record model, automated expiry, periodic review reports, closure evidence pack for audit) | Project Manager | Enterprise | 64h | £15,000 |

**Total Estimated Effort:** 368h  
**Total Estimated Cost:** £69,000

###### Actions Required for Compliance

- [ ] Create and keep up to date a record of all personal data (PII) used by the application, and a map showing how that data moves through the system, including every point where personal data enters or leaves the application and every internal handover point.
- [ ] Put the organisation’s personal data (PII) handling rules into clear, enforceable application and platform settings, covering authorised use, encryption, least privilege, logging, how long data is kept, and how it is deleted.
- [ ] Set up and check that data is encrypted while it is being sent through gateways and load balancers, and ensure that all personally identifiable information (PII) stored in databases is encrypted when stored, using the organisation’s enterprise key management system.
- [ ] Enable and centralise audit logs for access to and processing of personal data (PII), and ensure the logs are sent to security information and event management (SIEM) with tamper-resistant storage for a defined period.
- [ ] Set up automated rules to keep, delete, or anonymise data in line with the retention policy, and confirm that deletions work as intended using test evidence.
- [ ] Monitor the boundaries at external entry points and the agreed key internal boundaries to detect unauthorised processing of personal information and to produce records that can be audited (audit-ready telemetry).
- [ ] Set up an exception process that allows time-limited policy overrides, with approval records that clearly state the scope, which personal data (PII) elements or rules are affected, the authorised reason for the exception, and when it expires. Then review and remove any exceptions on the agreed schedule.


---

#### SC-7.25 — Unclassified National Security System Connections (Enhancement)

This expectation is about making sure your unclassified national security systems do not connect directly to outside networks without checks at the network boundary. If systems can connect straight to places such as the public internet, some traffic could avoid safeguards. That makes it easier for harmful activity, data to be leaked, or unauthorised access to happen without being noticed or controlled.

To meet this requirement, the organisation must:
- identify which in-scope systems and services are inside its network boundary, and
- prohibit any dedicated direct connection from those systems to external networks unless it goes through Department of Defense (DoD)-approved firewall or gateway devices.

These approved devices must be set up to control how network addresses are handled and to inspect the actual application information being sent and received, not just basic connection details.

The organisation must also:
- stop any technical workaround that would bypass these devices,
- document how the boundary protection works in its plans and designs, and
- keep records showing that the approved devices mediate (manage) external network traffic.

##### Mediated egress chokepoints for unclassified national security systems

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm SC-7(25) scope mapping: identify all in-scope {{sc-07.25_odp.01}} assets/services, tag them, and produce an environment-by-environment network location inventory (subnet/VLAN/tenant/route domain) | Compliance Manager | Enterprise | 24h | — |
| Design approved egress chokepoint architecture: select boundary protection device(s) as the sole egress, define VRF/route-table/next-hop model, and produce a single-mediated-egress network design pack (diagrams + routing rules) | System Design Authority | Enterprise | 32h | — |
| Implement routing constraints to enforce single default egress: configure cloud route tables / on-prem routing / VRF policies so in-scope segments have only the approved egress next-hop; document change records | Infrastructure Lead | Enterprise | 40h | — |
| Configure boundary mediation policy: enable managed NAT and application-layer inspection on {{sc-07.25_odp.02}} for in-scope outbound flows; implement explicit allow-lists per application/protocol and default-deny for non-matching traffic | Security Engineer | Enterprise | 48h | £15,000 |
| Remove/disable bypass paths: identify and block alternate egress routes, tunnels, policy-based routing exceptions, unmanaged VPN/SD-WAN direct breakout, and misrouted cloud egress; complete verification that bypass paths fail without passing through the approved gateway | Operations Lead | Enterprise | 32h | — |
| Establish drift prevention + audit evidence automation: implement policy-as-code / configuration management enforcement for NAT + inspection settings; integrate gateway identity/policy reconciliation and log retention; ensure logs include source, destination, gateway device ID, NAT translations, and inspection outcomes | DevOps Lead | Enterprise | 40h | £8,000 |
| Operational verification and acceptance testing: run scheduled test cases from representative in-scope systems to permitted external endpoints; validate gateway logs within expected time windows; produce an audit-ready evidence pack and sign-off report | Security Operations Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 240h  
**Total Estimated Cost:** £23,000

###### Actions Required for Compliance

- [ ] Create and keep up to date an official inventory label for every asset that meets **SC-07.25_ODP.01**, and link each one to its network segment and route domain.
- [ ] Using **sc-07.25_odp.02**, identify and mark the approved exit points (“egress chokepoints”). Then set up **single-path routing** for the in-scope network segments, using the default route, virtual routing and forwarding (VRF), and the designated egress gateway.
- [ ] Set up the **sc-07.25_odp.02** policies to allow **managed network address translation (NAT)** and **application-level inspection** for outbound network traffic that is in scope.
- [ ] Set up explicit allow-lists of approved external destinations and protocols, and block any network traffic that does not match the approved outbound (egress) policy.
- [ ] Remove or block any ways to bypass the normal network path (for example, alternate default routes, exceptions in routing rules, direct tunnel or software-defined wide area network (SD-WAN) breakouts, and unmanaged virtual private network (VPN) or direct vendor connections). Then confirm everything works by testing the network paths.
- [ ] Automate checks to prevent unauthorised changes to network address translation (NAT) and inspection settings, and produce audit-ready proof from gateway configuration exports and logs.
- [ ] Run scheduled checks on representative systems that are in scope, and confirm that the matching gateway mediation records are produced within the expected time window.


---

#### SC-7.26 — Classified National Security System Connections (Enhancement)

This requirement is about preventing a highly sensitive, classified system from being connected directly to the outside world without proper safeguards in place. If a classified system could connect straight to an external network, such as the internet, it would be harder to control what information goes in or out. This increases the risk of unauthorised access, data leakage, or harmful activity passing through without being noticed.

To meet this expectation, the organisation must clearly define what it means by a “direct connection” and what it considers an “external network”. It must then ensure that any classified system that needs outside connectivity routes that access only through an organisation-approved cross-domain solution. This solution must include managed interface boundary protection, and there must be no hidden routes that bypass it.

The organisation must also:
- document how the boundary protection is set up and operated
- keep records of the system design and architecture showing the approved connection pathway
- record the relevant configuration settings
- include this requirement in the system security plan
- keep audit evidence showing the protection is working
- assign named responsibilities to the appropriate staff for oversight, implementation, and compliant design

##### Enforce approved CDS boundary for classified external connectivity

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm SC-7(26) interpretation and publish “direct connection” vs “external network” definitions, including examples for physical links, dedicated virtual links, peering, site-to-site tunnels, and direct VPN termination | Compliance Manager | Enterprise | 16h | — |
| Produce approved boundary reference architecture for the “single mediation point” pattern (CDS at boundary, sole ingress/egress path) and map it to target environments (prod/test/DR, on-prem/cloud/hybrid) | System Design Authority | Enterprise | 24h | — |
| Implement routing and interface binding controls: enforce default/egress next-hop to CDS (VRF/route-table constraints) and restrict classified subnet reachability to CDS interfaces/addresses and explicitly approved ports/protocols | Network/Boundary Protection Engineering Lead | Department | 40h | £25,000 |
| Remove/disable bypass paths: identify and remediate any existing direct tunnels/VPN terminations, unmanaged routes, additional peering, or alternate egress gateways that could allow classified-to-external traffic to bypass the CDS | Operations Lead | Department | 32h | £10,000 |
| Integrate CDS boundary changes into change/configuration management: create/update change templates, approval workflow, and configuration baselines; implement automated deployment guardrails (policy-as-code where applicable) | Project Manager | Enterprise | 24h | £8,000 |
| Implement continuous mediation verification: configure drift detection and periodic path/flow verification (route/peering/tunnel checks) and ensure audit evidence captures CDS as mediation point (e.g., flow logs, config snapshots) | Security Engineer | Enterprise | 32h | £15,000 |
| Run compliance validation and evidence pack: execute test cases (attempted bypass scenarios), produce audit-ready report linking design, implemented controls, and continuous evidence outputs to SC-7(26) | Compliance Manager | Enterprise | 16h | — |

Total Estimated Effort: **184h**  
Total Estimated Cost: **£58,000**

###### Actions Required for Compliance

- [ ] Publish clear definitions for “direct connection” and “external network”, aligned to your enclave or zone boundaries.
- [ ] Design the classified system network so that all connections to and from external networks pass through the approved CDS boundary protection device.
- [ ] Set routing rules so that any classified subnets can send traffic only through the CDS as the default (outgoing) next hop, and remove any other backup routes, peer connections, or tunnels.
- [ ] Set up network interface connections and firewall or gateway rules so that only pre-approved CDS-mediated data flows are allowed.
- [ ] Add configuration for the CDS boundary to the organisation’s change and configuration management process, with peer review and records that can be audited.
- [ ] Set up ongoing checks to detect any changes (drift) and verify the actual routes taken, so you can prove the content delivery system (CDS) remains the required mediation point and raise alerts if there are signs it is being bypassed.


---

#### SC-7.27 — Unclassified Non-national Security System Connections (Enhancement)

This requirement is about preventing your internal, non-national security services from having a direct, unfiltered route to the outside world. If an internal service can connect straight to the wider Internet (or other external networks) without going through the organisation’s approved firewall or gateway, it becomes easier for harmful activity, data leaks, or unauthorised access to go unnoticed. This is because you lose control over—and visibility into—what is leaving and entering your environment.

To meet this expectation, the organisation must:
- Define what counts as a “direct connection”.
- Prohibit any dedicated physical or virtual link from unclassified, non-national security systems (for example, internal IT services that are not designated as national security systems) to external networks, unless all traffic first passes through an approved firewall or gateway.
- Ensure the approved firewall or gateway uses managed routing and checks traffic at the application level (not just basic network information).

The organisation must also:
- Document how this boundary is built into system design and security plans.
- Configure systems so that bypassing the firewall or gateway is not possible.
- Assign named responsibilities for this control.
- Keep evidence (such as audit records and configuration documentation) showing that the gateway is used and that it performs the required checks.

##### Enforce approved gateway mediation for unclassified external links

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define “direct connection” and mediation boundary rules for the unclassified, non-national security system (including dedicated tunnels, peering, private interconnects, static routes, SD-WAN bypass paths, and host-level default gateway exceptions) | Security Architecture Lead | Enterprise | 16h | — |
| Design and implement network segmentation for the unclassified system (VRFs/VLANs/security zones) and establish routing so the approved gateway is the only reachable first hop to external networks | Network Security Engineer | Department | 40h | — |
| Configure controlled egress/ingress on the approved boundary protection device for managed routing and application-layer inspection (enable relevant inspection profiles for HTTP(S), DNS, and other applicable protocols) | Infrastructure Lead | Department | 32h | — |
| Implement logging and evidence capture on the boundary protection device (session/flow logs and inspection outcomes) and integrate with SIEM/central logging for correlation by source host/IP and destination | Operations Lead | Enterprise | 24h | — |
| Create policy-as-code and change control guardrails (infrastructure-as-code for gateway/routing/inspection objects; peer review workflow; automated checks that block changes enabling bypass paths) | DevOps Lead | Enterprise | 48h | £6,000 |
| Develop continuous validation and bypass detection (automated compliance tests; correlation queries/dashboards; alerting on external traffic lacking gateway-log correlation) | Security Engineer | Enterprise | 32h | — |
| Execute validation and produce audit-ready evidence pack (configuration review, test results proving no alternate first hop, and sample correlated logs for representative external sessions) | Compliance Manager | Enterprise | 24h | — |

Total Estimated Effort: **236 Hours**  
Total Estimated Cost: **£6,000**

###### Actions Required for Compliance

- [ ] Define and publish the organisation’s technical meaning of “direct connection” for the unclassified, non-national security system. This includes tunnels, peering, and static routes where the first external hop bypasses the gateway.
- [ ] Divide the unclassified system into separate network areas (virtual routing and forwarding instances) and set up routing so that the approved boundary protection device is the only route to any external networks.
- [ ] Remove or restrict any backup ways for traffic to leave the network (such as default gateway settings on hosts, alternate software-defined wide area network (SD-WAN) rules, or direct network address translation (NAT) and exit rules) that could allow traffic to bypass the gateway.
- [ ] Set up the approved boundary protection device to use managed routing and application-level inspection settings for the application’s relevant protocols, and turn on inspection and session logging.
- [ ] Set up “policy-as-code” (using infrastructure-as-code) to manage gateway rules, routing objects, and inspection profiles, with peer review and automated checks that confirm “gateway mediation required” compliance.
- [ ] Set up log correlation and alerts to identify any outside network traffic coming from the unclassified system that does not have matching evidence that it passed through the approved gateway.


---

#### SC-7.28 — Connections to Public Networks (Enhancement)

This requirement is about ensuring the special on-premises gateway computer used for Secret and Confidential work is never directly connected to any public network, such as the Internet or any partner network that can be accessed from outside your organisation. If it were directly connected, attackers could potentially reach the gateway from outside your organisation, which would increase the risk of unauthorised access, data theft, or disruption to sensitive services.

To meet this expectation, your organisation must set up and maintain the gateway so it has no dedicated direct connection to public networks. You must treat any dedicated link between the gateway and another system as a “direct connection”, and treat any publicly accessible network as “public”.

You should check in practice that the gateway’s network connections, firewall and routing arrangements, and real-world tests from outside your organisation all show that it is not directly reachable. You must also ensure that any network-related changes are reviewed and approved by the people responsible for boundary protection, so that nothing accidentally creates a public connection over time.

##### Enclave gateway VM: prevent any direct public network attachment

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create and approve an authoritative network classification for gateway-relevant segments/port groups (Public/Extranet-Public vs Internal/Private), including upstream connectivity options that could create a dedicated public path | Security Architect / Boundary Protection Owner | Enterprise | 16h | — |
| Produce a gateway VM network attachment baseline (authoritative NIC/vNIC inventory) showing zero attachments to any *Public/Extranet-Public* network objects, and document the allowed internal-only attachment set | Infrastructure Lead | Enterprise | 24h | — |
| Implement hypervisor-level configuration to ensure the gateway VM has only internal/private NIC attachments (remove/disable any management/secondary interfaces, SR-IOV mappings, mirroring targets, or any dedicated links to public-classified networks) | Virtualisation Engineer | Enterprise | 32h | — |
| Implement attachment restrictions and change control guardrails (RBAC/privileged access, approval workflow requiring boundary protection sign-off, and deny-by-default for attaching gateway VM to *Public/Extranet-Public* networks) | Operations Lead | Enterprise | 24h | — |
| Develop policy-as-code checks for IaC/CI/CD (e.g., Terraform/Ansible pipeline) that fail builds if the gateway VM is assigned to any *Public/Extranet-Public* network object (including future networks created with that label) | DevOps Lead | Enterprise | 40h | £6,000 |
| Implement drift detection and automated quarantine response (monitor NIC-to-port-group/VLAN mapping, alert on change, disable NICs or move to a known internal-only port group, and open a boundary protection review ticket) | Security Engineer | Enterprise | 32h | £8,000 |
| Run and record periodic external reachability validation from an approved “outside” vantage point, store evidence (results, timestamps, test method) and integrate into audit reporting | SOC / Monitoring Team | Enterprise | 16h | £2,500 |

**Total Estimated Effort:** 184h  
**Total Estimated Cost:** £16,500

###### Actions Required for Compliance

- [ ] Create and keep up to date an official inventory that maps all virtual networks, port groups, and virtual local area networks (VLANs) that affect gateways to either Public/Extranet-Public or Internal/Private classifications.
- [ ] Reconfigure the gateway virtual machine so that all network cards (NICs) and virtual network cards (vNICs) are connected only to internal/private network groups, and remove any interface that is connected to public or extranet public network segments.
- [ ] Limit hypervisor permissions so only approved administrators can change the gateway virtual machine’s network interface card (NIC) connections to the correct port group and virtual local area network (VLAN), with sign-off from the boundary protection team.
- [ ] Set up “policy as code” in the infrastructure deployment pipeline to automatically stop any change that assigns the gateway virtual machine to a Public/Extranet-Public network label.
- [ ] Set up continuous monitoring to detect changes (“drift”) in the gateway virtual machine’s network connections, and automatically isolate (quarantine) or revert changes if any attempt is made to attach a public network.
- [ ] Run and keep regular checks of whether the system can be reached from the public internet, using an approved external testing location, to show that it is not directly accessible to the public.


---

#### SC-7.29 — Separate Subnets to Isolate Functions (Enhancement)

This requirement is about protecting the most important parts of your system by keeping them in separate, secure areas. This helps ensure that problems in other parts of the system do not easily spread into areas that must keep working.

In everyday terms, it means separating:
- command-and-control functions,
- safety or mission control functions, and
- operational process control functions

into clearly separate network areas, away from less critical functions.

Without this separation, a security breach or malfunction that begins in a less critical area could spread and disrupt safety-critical operations, potentially causing system failure.

To meet this expectation, your organisation must:
- identify and document which functions are critical;
- design and implement the system so those critical functions run in logically separate network segments;
- record in your system design and architecture how this separation is implemented;
- keep the network configuration details in your configuration records;
- explain the reasoning in a criticality analysis;
- include the approach in your security plan; and
- keep audit records showing the separation is in place and working as intended.

You must also assign clear responsibility to the relevant system administrators and boundary protection staff.

##### Logically separate critical functions into dedicated subnetworks

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce function-to-subnetwork mapping (critical vs non-critical components) including command-and-control, safety/mission control, and OT process control placement | System Design Authority | Enterprise | 24h | — |
| Define target logical network segmentation design (per-critical-function subnetworks) and update network architecture diagrams | Architect | Enterprise | 32h | — |
| Implement boundary enforcement with default-deny between critical and non-critical subnetworks (firewalls/segmentation gateways/security groups) | Network Security Engineer | Enterprise | 40h | £8,000 |
| Configure explicit allow-lists for required traffic flows (protocol/port/destination) and validate least-privilege connectivity paths | Security Engineer | Enterprise | 24h | — |
| Constrain routing and administrative access paths (deny unintended east-west connectivity; restrict admin interfaces via approved management jump hosts/bastions and management subnetworks) | Infrastructure Lead | Enterprise | 32h | £6,000 |
| Update system security plan and criticality analysis with documented rationale and segregation approach | Compliance Manager | Enterprise | 16h | — |
| Produce audit-ready evidence pack (exported boundary policy configs, routing policy evidence, and network topology snapshots) and complete internal compliance sign-off | Compliance Manager | Enterprise | 20h | — |

Total Estimated Effort: **188h**  
Total Estimated Cost: **£14,000**

###### Actions Required for Compliance

- [ ] Identify and record which system components and functions are responsible for command-and-control, safety and mission control, and operational technology (OT) process control, as opposed to non-critical functions.
- [ ] Create a mapping from each function to the subnetwork it uses, and update the system architecture diagrams to show a dedicated subnetwork for every critical function.
- [ ] Set up clearly separated network sections for each critical function (for example, dedicated virtual local area networks (VLANs), virtual private cloud (VPC) subnets, virtual routing and forwarding (VRF) instances, or other equivalent logical network segments).
- [ ] Set up network boundary controls so that traffic between critical and non-critical subnetworks is blocked by default, and only allow the specific network traffic that is required using an approved allow-list.
- [ ] Limit network routing and administrative access routes so that management of critical functions is only available through approved management subnets and jump hosts.
- [ ] Update the configuration records with the current subnet, routing, and boundary policy details, and keep the audit evidence exports.
- [ ] Record why the network segmentation was chosen in the criticality assessment, and include this approach in the system security plan.


---

### SC-8 — Transmission Confidentiality and Integrity (Control)

This expectation is about keeping information safe while it moves between people, devices, and services, so it cannot be secretly read or quietly changed while in transit. Without this, sensitive information sent across internal and external networks, or through devices such as servers, laptops, mobile phones, printers, scanners, and radios, could be intercepted or tampered with. This could lead to fraud, data leaks, or decisions being made using altered information.

To meet this requirement, the organisation must clearly state which types of message transmissions and which devices are covered. It must then ensure both confidentiality (keeping the information secret) and protection against unauthorised changes, using suitable safeguards, such as protected transmission routes or encryption.

The organisation must document how it achieves this in its policy and step-by-step procedures, reflect it in system design and configuration settings, keep evidence through audit records, and include it in the system’s security plan. If it uses standard commercial transmission services, it must check what protection those services include and use additional compensating measures if needed.

##### Encrypt and authenticate all in-scope transmissions (confidential+integrity)

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create in-scope transmission map (protocols, endpoints, data flows) and define approved confidentiality+integrity encryption profiles (incl. TLS/mTLS/message signing requirements and fail-closed rules) | Security Architect | Enterprise | 32h | — |
| Implement encryption enforcement at ingress/edge (load balancers/API gateways): require TLS, disable legacy protocols/ciphers, enforce certificate validation, reject plaintext/downgrade attempts | Infrastructure Lead | Enterprise | 40h | £12,000 |
| Implement encryption enforcement for service-to-service and internal clients (service mesh or mTLS where supported; update client/server libraries to refuse weak/legacy transport and validate certificates) | Platform Engineer | Enterprise | 48h | £18,000 |
| Implement message-level integrity for asynchronous/commodity transmission paths where required (signing/verification, authenticated message formats; key management integration) | Software Lead | Department | 40h | £6,000 |
| Third-party/ISP/SaaS transmission assurance review and compensating controls plan (document provider protections, obtain evidence/assurance, implement overlays/VPN/app-layer TLS/mTLS where needed) | Compliance Manager | Enterprise | 24h | £3,000 |
| Centralise audit-ready evidence and monitoring (TLS handshake/cipher/protocol logs, certificate validation outcomes, blocked plaintext/downgrade events; SIEM dashboards and alerting; exception workflow) | Operations Lead | Enterprise | 32h | £10,000 |
| Update System Security Plan (SSP) and configuration management baselines (prod/test/DR), including regression testing and change-control guardrails to prevent encryption enforcement drift | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 280h  
**Total Estimated Cost:** £49,000

###### Actions Required for Compliance

- [ ] Create a list (inventory) of the transmission types and the transmitting components that are in scope for the application or system.
- [ ] Define and publish the approved encryption and authentication settings for each type of data transmission, to protect both confidentiality (keeping data private) and integrity (preventing unauthorised changes).
- [ ] Configure gateways, load balancers, and service-to-service components to use Transport Layer Security (TLS) and mutual Transport Layer Security (mTLS), and to block any unencrypted (plaintext) connections or attempts to reduce security (downgrade).
- [ ] Update application and client settings to use the approved protocol and cipher settings, and to verify certificates (with no insecure fallback options).
- [ ] Where needed, ensure message integrity for asynchronous message flows that are not protected by transport layer security (TLS), by digitally signing messages and verifying the signatures.
- [ ] Document the protections used by commodity transmission providers. Where current assurance is not strong enough, put in additional safeguards (for example, extra encryption on top of existing encryption or message signing).
- [ ] Keep audit records showing that encrypted connections were agreed and that non-compliant connection attempts were blocked. Log any exceptions in the security system plan (SSP).


---

#### SC-8.1 — Cryptographic Protection (Enhancement)

This requirement is about keeping information safe while it moves between your systems and users. It must not be readable by the wrong people, and it must not be changed secretly without being detected. Without these protections, sensitive information such as login or account details could be exposed while it is being sent, or attackers could alter messages so that actions are carried out using changed or fake information.

To meet this expectation, the organisation must use approved methods to protect data while it is in transit, such as secure encrypted connections for web and network traffic, and integrity checks that can detect any change to the data while it is being sent. The organisation should clearly document the rules and procedures for how confidentiality and integrity are achieved, ensure system settings actually enforce these protections, and keep records showing that secure connections were used and that attempts to tamper with data were rejected or failed.

##### Enforce TLS (confidentiality + integrity) for all in-transit traffic

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define approved TLS baseline (min protocol versions, approved cipher suites, AEAD-only requirement, certificate requirements, mTLS guidance where feasible) and map to in-scope transmission paths | Security Architect | Enterprise | 16h | — |
| Update edge gateway/load balancer/reverse proxy/API gateway configurations to enforce TLS-only (deny/redirect plain HTTP, refuse non-TLS, disable downgrade/legacy protocols, enforce approved ciphers) | Infrastructure Lead | Enterprise | 24h | — |
| Implement service-to-service TLS enforcement (where feasible: mTLS for internal calls; otherwise authenticated server TLS with strict trust validation) and update endpoint/client configuration to remove “trust all” behaviour | Platform Engineer | Enterprise | 32h | — |
| Build automated TLS posture validation (scheduled scanning from representative client networks + internal scanners) to record negotiated TLS version/cipher and certificate validity; generate drift alerts on any non-approved negotiation | DevOps Lead | Enterprise | 24h | £6,000 |
| Centralise audit-ready evidence in SIEM (ingest gateway/proxy handshake success/failure, negotiated protocol/cipher, certificate details, rejected downgrade attempts) and configure retention/alerting for repeated failures | Operations Lead | Enterprise | 20h | £3,000 |
| Produce system design/configuration baseline documentation mapping each transmission path to TLS termination points and the specific confidentiality/integrity mechanisms used | Compliance Manager | Enterprise | 16h | — |
| Execute rollout and verification across environments (dev/test/prod + DR where applicable) including change management sign-off and remediation of identified non-compliant endpoints | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 156h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Define an approved Transport Layer Security (TLS) baseline, including the minimum allowed protocol versions and the approved cipher suites, in line with organisational standards.
- [ ] Configure edge gateways, load balancers, and API gateways to allow only encrypted traffic using Transport Layer Security (TLS). Block or refuse unencrypted plain HTTP and any TLS versions or certificates that are not approved.
- [ ] Use authenticated Transport Layer Security (TLS) for communication between services (use mutual TLS (mTLS) where possible; otherwise require strict certificate checks).
- [ ] Set up “configuration as code” checks to stop deployments that use disallowed Transport Layer Security (TLS) versions or encryption settings, and to prevent insecure client and server settings.
- [ ] Set up automated checks of Transport Layer Security (TLS) configuration that record which protocol and cipher were used, confirm the certificate status, and raise alerts if the configuration changes unexpectedly (drifts).
- [ ] Send Transport Layer Security (TLS) handshake and rejection records to the security information and event management (SIEM) system, and set up alerts for attempted security downgrades and repeated handshake failures.
- [ ] Update the system design and configuration baseline documents to record where Transport Layer Security (TLS) is terminated, and explain how confidentiality and integrity are maintained for each data transmission path.


---

#### SC-8.2 — Pre- and Post-transmission Handling (Enhancement)

This requirement is about keeping information safe while it is being prepared to send and while it is being received, so it cannot be accidentally exposed or secretly changed. Without this, sensitive details could leak during steps such as combining data, converting it into a different format, or packing it for delivery. The recipient might then receive information that looks genuine but is wrong.

To meet this expectation, the organisation must have clear, followed procedures for preparing outgoing information and for handling incoming information. These procedures must cover both confidentiality (keeping it private) and correctness (ensuring it is accurate) from start to finish. This includes protecting the information during preparation, packing, any combining, and any format or protocol conversion, as well as during reception, unpacking, and any conversion back again.

The organisation should also be able to show that integrity checks are carried out at the right points, and that if a check fails, the data is not accepted as valid.

##### Cryptographically bound transfer packaging with verify-before-unpack

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define the cryptographically bound transfer package format (container structure, canonicalisation rules, metadata fields, versioning) and verification workflow requirements | System Design Authority | Enterprise | 24h | — |
| Select and standardise cryptographic primitives and key management integration (encryption algorithm/mode, signing algorithm, key IDs, rotation approach, approved libraries) | Security Engineer | Enterprise | 20h | — |
| Implement reusable packaging/verify-before-unpack library/service (outbound: aggregate→transform→pack→encrypt→sign; inbound: restricted store→verify signature→decrypt→unpack) | Software Lead | Department | 64h | — |
| Implement deterministic transformation/canonicalisation and “sign-after-final-bytes” enforcement across integration points (web/API, batch, messaging, file import/export) | Platform Engineer | Business Unit | 40h | — |
| Build audit evidence and operational telemetry (per transfer identifier: sender identity, key IDs, payload hash, verification outcome, quarantine/rejection reasons; SIEM event schema) | Compliance Manager | Enterprise | 24h | — |
| Configure restricted handling, quarantine storage, and failure handling controls (reject/quarantine before unpack/decrypt; access controls; retention) | Operations Lead | Department | 24h | — |
| Develop and run tampering/negative test suite (byte-level mutation at each pipeline stage; replay/altered-metadata tests; performance smoke tests) and produce acceptance evidence | Quality Assurance Lead | Team | 32h | £6,000 |
| Pilot rollout to representative pipelines with monitoring and remediation (enablement, integration fixes, runbooks, and sign-off against acceptance criteria) | Project Manager | Business Unit | 24h | — |

**Total Estimated Effort:** 252h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Define a standard secure transfer format that digitally signs the transfer details and the hash (fingerprint) of the final transformed data payload.
- [ ] Set the outbound pipeline order so that data aggregation and any protocol or format changes happen before encryption and signing.
- [ ] Use only organisation-approved key management tools—hardware security modules (HSMs) or key management services (KMSs)—and enforce separation so that packing/signing cannot decrypt data, and recipients can only verify or decrypt it as part of authorised workflows.
- [ ] Set up an incoming receiving process that records parcels as delivered, checks the sender’s signature before unpacking or decrypting, and places parcels in quarantine if the check fails.
- [ ] Add a post-unpacking check to confirm that the decrypted content matches the signed or bound hash and meets the required schema and business rules.
- [ ] Turn on audit logging and security information and event management (SIEM) alerts for the results of signature checks, key identifiers, transfer identifiers, and the reasons for putting items into quarantine or rejecting them.


---

#### SC-8.3 — Cryptographic Protection for Message Externals (Enhancement)

This requirement is about protecting the important “routing details” of messages while they are being sent, so that outsiders cannot read them or secretly change them.

Message headers and routing information can show who is contacting whom and how messages move through systems. If these details are not protected, an attacker could monitor communications or alter delivery information to disrupt services or redirect information.

To meet this expectation, the organisation must set out and follow documented rules and step-by-step procedures for protecting these message details. It must use approved methods that both keep the information secret and help detect any unauthorised changes while the message is in transit.

The organisation must document how the protection is designed, record the system settings used to implement it, and keep audit records that show the protection is working in practice.

Cryptography should be used by default, unless the organisation can demonstrate that, for the relevant message path, protected distribution systems are in place with tamper-evident packaging and controlled access to the message routing components.

##### Encrypt message headers/routing externals in transit (TLS/mTLS)

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define approved TLS/mTLS cryptographic transport settings for message externals (TLS 1.2/1.3 only, cipher suite policy, strict certificate validation, disable downgrade/weak renegotiation where applicable) and publish as an enterprise standard | Security Engineering / Compliance | Enterprise | 16h | — |
| Perform message externals exposure mapping across the architecture (gateways, load balancers, reverse proxies, service-to-service links, brokers/queues, webhook endpoints, intermediaries) and produce a coverage matrix of “headers/routing in transit” per path | Project Manager | Enterprise | 24h | — |
| Implement/enforce TLS for client-to-service and web/API traffic at gateways/load balancers (HTTPS-only, HSTS, strict TLS policy, redirect/deny plaintext, certificate validation mode) | Infrastructure Lead | Department | 32h | — |
| Implement/enforce mTLS (or equivalent workload mutual authentication) for service-to-service/system-to-system integrations, including certificate lifecycle integration and prevention of silent plaintext fallback | Platform Engineer | Department | 40h | £12,000 |
| Configure messaging/webhook transport security (producer/consumer TLS, broker/relay behaviour, ensure proxies do not terminate encryption unless explicitly approved and still protected end-to-end) | Operations Lead | Department | 24h | — |
| Build policy-as-code/configuration baselines and CI/CD checks to reject deployments where TLS/mTLS is disabled, weak, or misconfigured (including environment parity for prod/test/DR) | DevOps Lead | Enterprise | 32h | — |
| Implement auditable evidence capture and monitoring/alerting for encrypted session negotiation and downgrade/plaintext attempts (telemetry/logs, SIEM integration hooks, dashboards, alert rules) | Cyber Security Lead | Enterprise | 24h | £6,000 |
| Exception handling workflow for sc-08.03_odp: define documentation template, approval gates, and evidence requirements for any justified plaintext omission (tamper-evident packaging + controlled access) | Compliance Manager | Enterprise | 16h | — |
| **Total Estimated Effort** |  |  | **228h** |  |
| **Total Estimated Cost** |  |  |  | **£18,000** |

###### Actions Required for Compliance

- [ ] Define and publish approved Transport Layer Security (TLS) and mutual Transport Layer Security (mTLS) cryptographic standards for external message connections, including the approved communication protocols, cipher suites, certificate checking rules, and rules to prevent downgrade attacks.
- [ ] Create a list of every message route to identify all places where header information and routing details could be exposed (such as gateways, proxies, message brokers, webhooks, and service-to-service connections).
- [ ] Require Transport Layer Security (TLS) and mutual Transport Layer Security (mTLS) on every identified message route, and prevent any unencrypted (plaintext) fallback at gateways, load balancers, and other intermediary components.
- [ ] Set up “policy as code” and configuration baselines so deployments fail if transport layer security (TLS) is turned off or considered weak for any covered endpoint or connection.
- [ ] Record configuration settings that can be audited for every covered endpoint or link in the configuration management repository.
- [ ] Enable and keep monitoring records (telemetry/logs) that show encrypted sessions were successfully agreed for message traffic. Alert if anyone tries to send messages in plain text or to reduce (downgrade) the encryption level.
- [ ] Document and provide evidence for any exception use, and do so only for sc-08.03_odp (protected distribution systems that use tamper-evident packaging and controlled access to message routing components).


---

#### SC-8.4 — Conceal or Randomize Communications (Enhancement)

This requirement is about preventing outsiders from learning useful information just by observing when and how your messages are sent. Even if the message content is protected, details such as how often communications happen, how predictable the timing is, and how much data is sent can still reveal sensitive information when combined with other data.

To meet this requirement, the organisation must use approved encryption and related protections to hide communication patterns or make them less predictable for both internal and external connections that unauthorised people might be able to observe. This should be done unless the organisation’s protected distribution systems for external links and mission circuits already provide the needed protection.

The organisation must:
- set clear internal rules for when pattern concealment is required
- document how transmissions are kept confidential and protected from being altered
- ensure the system design and configuration show these protections are enabled
- keep records proving the protections are operating
- include this approach in the system security plan, with clear responsibility assigned to the relevant information technology (IT) and security staff when relying on the alternative protected distribution approach

##### Conceal comms patterns via encrypted fixed/randomised egress scheduling

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define traffic-class scoping rules for pattern concealment (internal/external links, application flows, and sc-08.04_odp exception mapping) | Security Architect | Enterprise | 24h | — |
| Produce egress control design for fixed-rate and bounded-randomised scheduling (rate shaping, queueing, jitter/batching strategy, and per-class policy model) | System Design Authority | Enterprise | 32h | — |
| Implement cryptographic transport hardening for scoped flows (TLS 1.2+ / strong cipher suites and/or IPsec where required) and verify end-to-end coverage | Infrastructure Lead | Enterprise | 40h | — |
| Implement egress scheduling at controlled egress points (service mesh egress / API gateway / SD-WAN / overlay) with per-route/per-destination policy enforcement for each scoped traffic class | Platform Engineer | Enterprise | 72h | £18,000 |
| Add auditable telemetry and evidence generation (policy IDs, runtime pacing/shaping counters, configuration versioning, and log retention hooks to SIEM) | Cyber Security Lead | Enterprise | 24h | — |
| Update System Security Plan and communications protection documentation (scoping rules, cryptographic mechanisms, concealment/randomisation behaviour, and sc-08.04_odp exclusions) | Compliance Manager | Enterprise | 16h | — |
| Execute test, validation, and operational readiness (baseline vs shaped traffic analysis for predictability/volume, deployment runbook, and rollback plan) | Quality Assurance Lead | Enterprise | 40h | £3,000 |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £21,000

###### Actions Required for Compliance

- [ ] Set up traffic categories and the rules for when internal and external network traffic must have its patterns hidden or randomised.
- [ ] Check and require approved secure encrypted network connections (Transport Layer Security (TLS) and Internet Protocol Security (IPsec)) for all in-scope data flows.
- [ ] Set up fixed-rate or limited randomised traffic scheduling at a controlled exit point (application programming interface (API) gateway/service mesh/software-defined wide area network (SD-WAN) edge) for specific traffic categories.
- [ ] Document and set out clear exceptions for external links and mission circuits that are covered by protected distribution systems (SC-08.04_ODP).
- [ ] Enable and keep audit records from the data-exit control layer to show that the pattern concealment and randomisation rules are active while the system is running.
- [ ] Update the System Security Plan and the configuration and design documents to reference the concealment and randomisation mechanism and the SC-08.04 ODP exceptions.


---

#### SC-8.5 — Protected Distribution System (Enhancement)

This requirement is about ensuring Secret and Confidential information is sent using approved, protected routes. This prevents unauthorised people from reading it while it is being transmitted, and allows the organisation to detect whether the information was changed during transit. Without these controls, sensitive documents could be intercepted, copied, or tampered with while they are being sent, which could seriously harm the organisation and its stakeholders.

To meet this expectation, the organisation must define and document its protected distribution system for Secret and Confidential data. This includes the practical steps and procedures used to keep transmissions private and to detect any changes. The organisation must also keep design and configuration evidence showing that the protected routes are actually in place, record relevant activity so the protections and detection can be checked later, and include this in its security planning.

Finally, the organisation must ensure staff systems enforce the use of the approved protected routes. Any attempt to send Secret or Confidential data through unapproved channels must be blocked or redirected.

##### Mandatory PDS via approved secure transfer service for Secret/Confidential

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define PDS scope, routing rules, and exceptions for Secret/Confidential (including permitted transfer mechanisms, expiry/approval process, and enforcement points) | Compliance Manager | Enterprise | 24h | — |
| Design mandatory routing/enforcement across application and enterprise messaging/email/API pathways (block/redirect unapproved channels; document decision logic and failure modes) | System Design Authority | Enterprise | 40h | — |
| Configure/implement approved secure transfer service for authenticated encryption + integrity verification with fail-closed behaviour (reject/quarantine on integrity failure) | Security Engineer | Enterprise | 56h | £25,000 |
| Integrate identity and authorisation for PDS access (SSO/MFA, recipient/role checks, least-privilege access, service-to-service authentication) | Data Protection Officer | Enterprise | 32h | — |
| Implement audit logging and SIEM integration (transfer identifiers, sender/recipient, classification tag, auth outcome, integrity pass/fail; alerting on integrity failures; retention alignment) | Operations Lead | Enterprise | 40h | £8,000 |
| Produce audit-ready design/operating documentation (architecture diagrams, configuration baselines, operator runbooks for failures/quarantine handling, evidence mapping to SC-8(5)) | Project Manager | Enterprise | 24h | — |
| Update System Security Plan and governance artefacts to reference PDS enforcement, monitoring, and log retention; complete internal compliance review sign-off | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 232h  
**Total Estimated Cost:** £33,000

###### Actions Required for Compliance

- [ ] Define and document the scope for handling Secret and Confidential information, including which transfer methods are allowed and any approved exceptions.
- [ ] Set up the application programming interface (API) and the organisation’s email and messaging routes so that all in-scope data is automatically sent through the approved secure file transfer service.
- [ ] Set up encrypted, authenticated data transfer with integrity checking in the secure transfer service, and ensure the service stops processing (fails closed) if the integrity check fails.
- [ ] Set up access to PDS using enterprise single sign-on (SSO), and require authorisation based on the intended recipient and their role for transfers of Secret and Confidential information.
- [ ] Enable audit logs for the start and end of each transfer, the sender and recipient, the classification tags, the results of authentication, and whether data integrity checks passed or failed. Send these logs to security information and event management (SIEM) and set how long they are kept.
- [ ] Publish architecture diagrams, agreed configuration baselines, and operator instructions for enforcing PDS controls and handling integrity failures
- [ ] Update the system security plan to clearly include how the programme handles PDS use, monitoring, and how long logs are kept for Secret and Confidential transmissions.


---

### SC-10 — Network Disconnect (Control)

This requirement is about making sure that when a user’s online session ends, the system closes it properly. It also requires the system to end the session automatically if the user is inactive for 15 minutes. Without this, users could remain connected longer than intended, which could leave the system vulnerable to unauthorised use, accidental access, or misuse of resources that should have been released.

To meet this expectation, the organisation must set a clear 15-minute inactivity rule and ensure sessions are ended either when the session finishes normally or when the inactivity limit is reached. This applies to both internal and external connections.

When ending a session, the system must release the network resources it was using. If multiple session activities use the same underlying connection, the system must separate them correctly so that ending one activity does not affect the others.

The organisation must document how this will work, configure it in system settings, keep evidence that it is operating as intended, record session end events with the time they occurred, and assign named responsibility so administrators and developers can support the capability.

##### Enforce 15-min inactivity session disconnect at edge and app

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Confirm scope of supported session types (web, API, admin consoles, remote access) and map each to the relevant edge component(s) and application session mechanisms | System Design Authority | Enterprise | 16h | — |
| Configure edge gateway/reverse proxy/VPN/waswo to enforce per-session inactivity timeout using parameter sc-10_odp (default 15 minutes) and to terminate sessions on explicit logout/disconnect | Infrastructure Lead | Enterprise | 40h | £6,000 |
| Validate OS-level transport teardown at the edge (socket/flow closure) and ensure logical session invalidation for shared-connection scenarios (e.g., HTTP/2 multiplexing, pooling) | Security Engineer | Enterprise | 24h | — |
| Implement or confirm application session inactivity expiry at sc-10_odp (15 minutes) and deny further requests after expiry even if transport persists | Software Lead | Enterprise | 48h | — |
| Implement end-of-session cleanup and mapping invalidation (logout/session close/connection close) including any session-to-connection correlation used by the edge | Software Lead | Enterprise | 24h | — |
| Add audit logging for disconnect events (session id, user/service identity, last activity, disconnect timestamp, reason: end-of-session vs inactivity timeout) and forward to SIEM with required retention | Compliance Manager | Enterprise | 32h | £2,500 |
| Execute end-to-end testing and evidence pack creation (test cases, timing verification, shared-connection validation, SIEM log samples) for internal and external access paths | Quality Assurance Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 236h  
**Total Estimated Cost:** £8,500

###### Actions Required for Compliance

- [ ] Choose and standardise the session-aware edge component(s)—for example, a reverse proxy, application programming interface (API) gateway, zero trust network access (ZTNA), or virtual private network (VPN)—so they are used for all internal and external access routes.
- [ ] Set a 15-minute inactivity timeout for each session at the edge for **sc-10_odp**, and end the session immediately when a user logs out or disconnects.
- [ ] Set up, or confirm, that application sessions expire after 15 minutes of inactivity at sc-10_odp, and make sure that once a session expires it is no longer accepted for any further requests.
- [ ] Check that shared connections are handled correctly, so that logical sessions are ended after 15 minutes even if the underlying transport connection pooling or multiplexing continues.
- [ ] Enable audit logging for disconnection events, including the session ID, the time of the last activity, the time of the disconnection, and the reason for the disconnection (end of session versus inactivity timeout).
- [ ] Test and record evidence: confirm the operating system’s socket and port mapping release, and verify that the connection is disconnected exactly at the end of the session or after 15 minutes of inactivity.


---

### SC-11 — Trusted Path (Control)

This requirement ensures that when people sign in or confirm they are still authorised, they do it using a special, protected method that normal software cannot interfere with. Without this, a malicious or untrusted programme could imitate a login screen, record what the user types, or change what the system accepts, which could lead to unauthorised access.

The organisation must provide a physically separate, trusted communication link between the user and the system’s trusted security functions. This means any responses sent through that link cannot be seen or altered by untrusted applications. Users must be able to use this trusted link not only for the initial sign-in, but also for identity checks when required, at a minimum.

The organisation should document how this trusted link works, make sure it is implemented exactly as described, and be able to provide evidence that both authentication and re-authentication take place through the trusted link.

##### Physically isolated trusted authentication terminal for auth & re-auth

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select and approve trusted authentication terminal/appliance design (separate UI, trusted prompts, dedicated credential entry) and define physical placement/location controls | System Design Authority | Enterprise | 24h | — |
| Procure trusted authentication terminals/appliances and required hardened peripherals (secure keyboard/display, tamper-evident casing, secure cabling) | Infrastructure Lead | Enterprise | 8h | £48,000 |
| Implement trusted terminal integration with enterprise IAM (authentication + re-auth step-up), including mapping to application authorisation result (success/failure, step-up token/session indicator) | Security Engineer | Enterprise | 56h | — |
| Implement reference monitor enforcement in the application/security layer: accept authentication/re-authentication only when a cryptographically verifiable trusted-path indicator is present and valid (signed assertion/token validation, replay protection, expiry checks) | Software Lead | Business Unit | 72h | — |
| Implement trusted path invocation and re-auth triggers: dedicated user action to initiate trusted terminal session; server-driven step-up flow for protected actions; ensure main workstation cannot render credential-entry screens for trusted auth | Architect | Business Unit | 64h | — |
| Configure auditability end-to-end: generate audit events for authentication and re-authentication with “trusted path used” indicator; ensure SIEM ingestion, retention alignment, and evidence completeness for audit | Compliance Manager | Enterprise | 32h | — |
| Execute test and assurance: negative tests for spoof/intercept attempts, validation of “no credential capture via untrusted prompts”, token tamper/replay tests, and documented acceptance evidence | Quality Assurance Lead | Department | 40h | £6,000 |

| Total Estimated Effort | 296h |
|---:|---:|
| Total Estimated Cost | £54,000 |

###### Actions Required for Compliance

- [ ] Procure and deploy a dedicated trusted authentication terminal or appliance with a separate, isolated keyboard and screen for entering credentials.
- [ ] Connect the terminal to the organisation’s identity system so it can verify users and then send the application only a signed confirmation (including any required extra verification, if needed).
- [ ] Set up a system check inside the application so that it only allows initial sign-in and re-sign-in when a trusted-path indicator is present.
- [ ] Set up the application so that, for certain high-risk actions, it requires the user to sign in again using the trusted device (a “step-up” sign-in process).
- [ ] Disable or block pop-up prompts that ask users to enter credentials in the main application when using trusted authentication or re-authentication routes.
- [ ] Enable audit logging and security information and event management (SIEM) reporting for authentication and re-authentication events, including an indicator showing whether a trusted path was used.
- [ ] Run a test to show that prompts from untrusted applications cannot capture or change the user answers used for trusted authentication and re-authentication.


---

#### SC-11.1 — Irrefutable Communications Path (Enhancement)

This requirement is about making sure the system communicates with you in a way you can always trust and immediately recognise as coming from the organisation’s own security protections—not from a normal app or a deceptive message. Without this, a malicious or faulty message could appear convincing and persuade you to enter sensitive details, approve changes, or confirm actions that should only be handled through the system’s security safeguards.

To meet this expectation, the organisation must set up the system so that the trusted way of communicating is clearly and unmistakably different from all other messages. For example, this could be done by using a dedicated on-screen area that other software cannot access, or by showing a fixed trusted indicator that cannot be copied or imitated.

The system must also automatically start this trusted communication route whenever communication is needed between the system’s security functions that set it up and you. The organisation must ensure consistent behaviour and keep evidence through documented procedures, system design and configuration records, and audit or test results.

##### Trusted communications path via non-spoofable secure UI surface

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define security functions (sc-11.01_odp mapping) and trusted-path user journey matrix, including decision points (auth, re-auth, step-up, privileged confirmation) | Compliance Manager | Enterprise | 16h | — |
| Select and design the non-spoofable secure UI mechanism for the target platforms (e.g., OS secure attention/secure desktop equivalents or enterprise identity/PAM trusted prompt), including threat model and non-overlay requirements | System Design Authority | Enterprise | 24h | — |
| Implement trusted prompt/surface integration so rendering is performed only by the security component (not the business app), including fixed indicator/region configuration and anti-spoof/anti-overlay enforcement | Platform Engineer | Department | 56h | — |
| Configure automatic initiation from the security component at the correct journey points, including state handling (success/failure/timeout) and user experience constraints | DevOps Lead | Department | 32h | — |
| Implement evidence instrumentation and audit logging for trusted-path invocation (security function, timestamp, outcome, correlation IDs) and produce initial audit-ready evidence package | Security Engineer | Enterprise | 24h | — |
| Build automated regression tests and CI/CD checks to verify trusted indicator presence, non-imitability (overlay/replace attempts), and correct auto-initiation (with recorded evidence artefacts) | Quality Assurance Lead | Team | 40h | £6,000 |
| Run security validation (test plan execution, negative tests, and sign-off) across representative environments (dev/test/prod-like) and remediate findings | Cyber Security Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 246h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Define and document the system security functions that must create the trusted communication route (sc-11.01_odp), and link them to user journeys.
- [ ] Choose and set up a platform, identity, and privileged access management (PAM) secure user interface that creates a trusted screen that cannot be imitated or faked.
- [ ] Set up the trusted prompt so it is only displayed or triggered by the security component, not by the business application.
- [ ] Set up a fixed, consistent trusted indicator or region, and check that other applications cannot place content over it or copy it to look the same.
- [ ] Set up automatic start so the trusted path is activated at the right moment in every security decision flow.
- [ ] Add logging and automated user interface (UI) tests to produce audit-ready evidence that the trusted path was used correctly and that it behaved as expected.


---

### SC-12 — Cryptographic Key Establishment and Management (Control)

This requirement is about making sure that whenever your organisation uses encryption, the secret keys that make encryption work are created, managed, and retired properly. If keys are created using unapproved tools, sent using the wrong method, stored in the wrong place, accessible to too many people, not changed on time, or not genuinely destroyed when no longer needed, attackers could steal them and use them to read or alter protected information, pretend to be trusted services, or weaken trust in digital certificates.

To meet this expectation, the organisation must generate keys using cryptographic modules that have been validated under Federal Information Processing Standards Publication 140-3 (FIPS 140-3), share keys only through approved channels, and store keys only in approved managed key storage such as a hardware security module (HSM) or key management system (KMS). Access must be limited to the minimum permissions needed. Keys must be replaced (rotated) according to the organisation’s key-management policy, and old keys must be securely destroyed using secure erase or cryptographic shredding.

The organisation must also ensure that every trust store contains only approved trust anchors, and that externally visible and internal certificates are included only when they are approved.

##### Policy-driven KMS/HSM key lifecycle with approved trust anchors

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Perform encryption usage inventory and key/certificate type mapping (TLS/mTLS, DB encryption, signing/encryption, code signing, S/MIME as applicable) | Security Architect | Enterprise | 24h | — |
| Define policy-as-code for key lifecycle (generation, issuance templates, rotation/renewal windows, disable/retire triggers, destruction/crypto-shredding) and approval workflow integration | Compliance Manager | Enterprise | 32h | — |
| Design and implement central KMS/HSM integration patterns (API/workflows, service bindings, workload identity model, separation of duties for key admin vs operators) | Platform Engineer | Enterprise | 56h | £25,000 |
| Implement enforcement of approved distribution channels (block/detect manual copying, validate request provenance, ensure all bindings use central workflows) | DevOps Lead | Enterprise | 40h | £10,000 |
| Configure automated rotation/renewal and application rebind mechanism (certificate/key rollover without manual intervention across dev/test/prod/DR) | Operations Lead | Enterprise | 48h | £15,000 |
| Implement secure destruction and audit evidence capture (crypto-shredding/secure delete, immutable event logging, linkage to approvals/change records) | Security Engineer | Enterprise | 40h | £8,000 |
| Establish approved trust-anchor governance and deployment pipeline (trust-anchor register, single source of truth, environment-specific trust-store publishing, change traceability) | Data Protection Officer | Enterprise | 32h | £6,000 |
| Run compliance validation and evidence pack (test cases for FIPS module usage, lifecycle events, least-privilege access, trust-store contents, audit log completeness) | Quality Assurance Lead | Enterprise | 24h | — |
| **Total Estimated Effort** |  |  | **336h** |  |
| **Total Estimated Cost** |  |  |  | **£64,000** |

###### Actions Required for Compliance

- [ ] List every location where the application and its supporting components use encryption, and identify the types of keys and certificates that are required.
- [ ] Choose and set up a central key management service with a hardware security module (HSM) using only cryptographic modules that are validated to Federal Information Processing Standards (FIPS) 140-3 for key generation.
- [ ] Set up applications and services to request, renew, rotate, and retire encryption keys and certificates through the key service application programming interfaces (APIs) and work processes, so there is no need for manual key or certificate copying.
- [ ] Set up least-privilege access controls for key use and key administration by using workload identities and separate roles for administrators.
- [ ] Set up automated rules to rotate, renew, and retire access, including the conditions that disable or retire it, and how applications should re-connect or re-bind when this happens.
- [ ] Enable secure data destruction (cryptographic shredding/secure deletion) through the key management service, and keep records of the destruction events.
- [ ] Create and enforce an approved list of trust anchors, and distribute the trust stores from one single source of truth, with change records (logging).


---

#### SC-12.1 — Availability (Enhancement)

This requirement is about making sure your protected information remains available even if a user loses the secret needed to unlock it, such as forgetting a passphrase. If there are no clear recovery arrangements, a lost key could make files, messages, or systems permanently inaccessible. This can lead to delays, lost productivity, and potential disruption to the business.

To meet this expectation, the organisation must plan for key loss and keep documented, up-to-date step-by-step instructions. These instructions should explain how keys are created, how they are handled day to day, and exactly how access is restored when a user can no longer use their key. Where appropriate, the organisation must put recovery arrangements in place (such as key escrow) so authorised staff can restore access.

The organisation must also ensure the system is designed and configured to support recovery, keep audit records showing that recovery actions were carried out, and include this key-loss availability approach in the system’s security plan.

##### Key escrow and auditable recovery workflow for lost user keys

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Key-loss scope assessment: inventory encryption key types (user-derived vs centrally managed), identify affected data stores/services, and define recoverability boundaries and exceptions | Compliance Manager | Enterprise | 24h | — |
| Design escrow/backup architecture: define KMS/HSM/key vault pattern, key hierarchy (KEK/DEK or equivalent), re-association to tenant/account/service identity, and recovery constraints (no broad plaintext exposure) | System Design Authority | Enterprise | 32h | — |
| Implement escrow/backup configuration in approved KMS/HSM/key vault: enable backup-wrapping/escrow for recoverable keys and validate correct identity context mapping | Security Engineer | Enterprise | 40h | £25,000 |
| Build controlled recovery workflow (software/process integration): implement step-up authentication, separation of duties (request/approve/execute), authorisation checks, and operator tooling/API endpoints for recovery actions | Software Lead | Enterprise | 56h | £15,000 |
| Implement tamper-resistant audit logging to SIEM: define event schema (request/approval/execution/key retrieval/unwrap/re-association/verification), configure protected retention/integrity, and ensure end-to-end traceability | Cyber Security Lead | Enterprise | 32h | £8,000 |
| Develop runbooks and evidence pack for user key-loss scenarios (forgotten passphrase/lost device/account lockout): include required evidence, step-by-step recovery, verification steps, and escalation/exception handling | Compliance Manager | Enterprise | 24h | — |
| Update system security plan and key management documentation; integrate recovery changes into change/configuration management and release governance | Project Manager | Enterprise | 16h | — |
| Execute tabletop/test of simulated key-loss recovery: run controlled test, capture audit evidence, measure time-to-restore, and record outcomes against acceptance criteria | Service Delivery Manager | Enterprise | 20h | — |

Total Estimated Effort: **244h**  
Total Estimated Cost: **£48,000**

###### Actions Required for Compliance

- [ ] List all types of encryption keys the application uses, and identify which ones users could permanently lose (for example, keys derived from a passphrase that has been forgotten).
- [ ] Set up key management services (KMS), hardware security modules (HSMs), and key vault escrow or backup so that recoverable key material (key encryption keys (KEKs), data encryption keys (DEKs), or equivalent wrapped keys) is retained. Also ensure that any keys recovered can be linked back to the correct user or system identity context.
- [ ] Set up an authorised recovery process that requires additional identity checks (step-up authentication), ensures different people handle different recovery tasks (separation of duties), and includes clear approval checkpoints that recovery operators must obtain before proceeding.
- [ ] Create and get approval for step-by-step instructions (runbooks) for user key-loss situations, such as a forgotten passphrase, a lost device, or account lockout. Include what proof (evidence) is required and the checks needed to confirm the outcome.
- [ ] Set up tamper-resistant audit logs for key recovery events (request, approval, execution, unwrapping, re-association, and verification) and send them to security information and event management (SIEM) with data retention controls.
- [ ] Update the system security plan and key management documents to include the recovery procedures and the escrow mechanism that has been put in place. Then confirm this by running a recovery test or a tabletop exercise.


---

#### SC-12.2 — Symmetric Keys (Enhancement)

This requirement is about ensuring the secret “lock-and-key” codes used to protect data are created, safeguarded, and sent to the correct systems in a safe, approved way. If these keys are created informally, stored carelessly, or shared outside the approved process, an attacker could steal them and then read or change protected information, or pretend to be trusted systems.

To meet this expectation, the organisation must use key-management tools and documented steps that have been validated under the United States National Institute of Standards and Technology Federal Information Processing Standards (NIST FIPS) to generate symmetric keys (the same key is used to both lock and unlock data). The organisation must keep these keys protected from unauthorised access throughout their entire life, and share them only using the approved method with authorised recipients.

The organisation must also keep clear written procedures, record how this is done in system design and configuration records, keep audit evidence showing key creation, protection, and distribution, and maintain an up-to-date list of the approved, validated key-management products used in practice.

##### FIPS-validated KMS/HSM for symmetric key generation and automated distribution

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Create and maintain authoritative register of FIPS-validated KMS/HSM products (vendor, product/version/build, FIPS validation reference/scope, approved use-cases) | Compliance Manager | Enterprise | 24h | — |
| Select approved KMS/HSM deployment pattern and define symmetric key workflows (create/select, rotate/re-key, retire) including RBAC/authorisation model and key usage constraints (encrypt/decrypt) | System Design Authority | Enterprise | 32h | — |
| Procure/enable required KMS/HSM components and licences for symmetric key generation/control/distribution (including any required connectors/SDKs) | Infrastructure Lead | Enterprise | — | £120,000 |
| Implement centralised KMS/HSM-backed key service/API for symmetric key generation and returning only key identifiers/handles (no raw key material exposure) | Platform Engineer | Enterprise | 56h | — |
| Integrate automated provisioning pipeline to perform the approved sequence (create/select key → grant usage permissions → attach key identifier to workload configuration) across environments (dev/test/prod) | DevOps Lead | Enterprise | 48h | — |
| Implement controls to prevent ad-hoc/manual raw symmetric key handling (block import/export paths, enforce “no raw key material” in application interfaces, add detections and alerting) | Security Engineer | Enterprise | 40h | — |
| Configure audit logging and SIEM forwarding for key events (key creation/selection, permission grants, rotation/re-keying, retirement) and validate audit evidence for representative scenarios | Security Operations Lead | Enterprise | 32h | — |

| Total Estimated Effort | 232h | Total Estimated Cost | £120,000 |

###### Actions Required for Compliance

- [ ] Create and keep a list (register) of approved Federal Information Processing Standards (FIPS)-validated key-management products. The register must include the specific versions or builds and the scope of what each product was validated to do. These products are used to produce, control, and distribute symmetric keys.
- [ ] Set up and configure a central key management service backed by a hardware security module (HSM) to create symmetric encryption keys, and provide applications with the key identifiers (handles) they need to use those keys.
- [ ] Update applications so they obtain encryption keys from the key management service (KMS) or hardware security module (HSM), and remove any ability to create or import raw symmetric key material.
- [ ] Set up automated workload provisioning to follow the approved steps in order: create or select the key, grant permission to use it, and add the key identifier to the workload configuration.
- [ ] Apply the principle of least privilege by limiting access rights for important key creation, update, and deletion actions, and for key use, using built-in service identities and assigned roles.
- [ ] Enable, keep, and send key-management audit records for key creation, permission changes, key rotation or re-keying, and key retirement to the security information and event management (SIEM) system so they are available as evidence for audits.
- [ ] Add detection and controls to stop or alert on any key import, export, or manual handling of key material outside the approved process.


---

#### SC-12.3 — Asymmetric Keys (Enhancement)

This requirement is about ensuring the secret signing keys used to protect important digital activities are created correctly, kept secure, and given out in a controlled way. If these keys are created using the wrong certificates or stored in ordinary software, they could be copied or stolen. That would allow criminals to pretend to be staff, alter messages, or create fake documents that appear trustworthy.

To meet this expectation, the organisation must create, manage, and distribute asymmetric cryptographic keys only using Department of Defense (DoD)-approved or DoD-issued Medium Hardware Assurance public certificate types, together with approved hardware security tokens. These tokens must keep the user’s private key protected inside the device, so it is not exposed or sent in an unprotected form.

The organisation should be able to demonstrate, using documented procedures and audit records, that for each active user or service identity:
- the correct certificate type and approved token model were used
- the private key could not be exported or copied out during normal operations
- provisioning and distribution were carried out through the approved token-based process, without insecure delivery of private key material.

##### Token-bound asymmetric key generation using approved Medium HA PKI

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define approved Medium HA PKI certificate profiles/types and approved hardware token models (including non-exportable/non-migratable requirements) and publish an enforceable allow-list | Security Architect (Crypto/Key Management) | Enterprise | 24h | — |
| Design token-bound enrolment workflow and CSR/key-generation constraints (ensure private key is generated and remains inside the token; define API/enrolment contract and failure modes) | System Design Authority | Enterprise | 32h | — |
| Implement PKI integration for token-bound issuance (configure CA/enrolment service to accept only CSRs bound to approved token identifiers and to issue only approved certificate profiles) | Infrastructure Lead | Business Unit | 40h | £25,000 |
| Build auditable linkage model and persistence (identity/service account ↔ token identifier/model ↔ certificate profile/type ↔ issuance timestamp ↔ CSR/enrolment request ID) with tamper-evident logging | Compliance Manager | Enterprise | 28h | — |
| Implement distribution controls to deliver only certificates/enrolment instructions (block private key export, prevent private key material in logs/tickets/API responses/file exports; add automated checks) | Operations Lead | Department | 24h | — |
| Operationalise lifecycle controls (revocation/rotation triggers on access removal/token replacement; integrate with identity events and PKI procedures; define runbooks) | Service Delivery Manager | Enterprise | 24h | — |
| Verification & monitoring automation (automated rejection of non-approved profile/token requests; alerting for attempted private-key export or out-of-workflow issuance; audit sampling evidence pack) | Cyber Security Lead | Enterprise | 32h | £8,000 |
| Pilot deployment and control effectiveness testing (test cases for non-exportability, workflow enforcement, audit evidence completeness; remediate findings) | Quality Assurance Lead | Business Unit | 24h | £5,000 |

**Total Estimated Effort:** 228h  
**Total Estimated Cost:** £38,000

###### Actions Required for Compliance

- [ ] Define and publish allow-lists of approved Medium Hardware Assurance public key infrastructure (PKI) certificate profiles or types, and approved hardware security token models.
- [ ] Set up the certificate request process so that the secure, approved device generates the public and private keys, and link (bind) the certificate signing request (CSR) to the device’s key reference handle.
- [ ] Set up automated checks (policy-as-code) that block any certificate request that does not match the approved certificate profile or type and the approved token model.
- [ ] Issue instruments in a way that creates a traceable, auditable link between the user identity, the token identifier/model, the certificate signing request (CSR) or enrolment request ID, and the certificate issuance details.
- [ ] Secure the distribution so it delivers only certificates (and enrolment instructions). Use clear technical safeguards to prevent private keys from being exported or sent to other systems.
- [ ] Link account access changes—such as revoking or rotating credentials—with identity lifecycle events (joiners, movers, and leavers), including replacing tokens, and confirm the behaviour using test cases.
- [ ] Set up monitoring and alerts for attempted private key exports, certificates being issued outside policy, and token misuse.


---

#### SC-12.6 — Physical Control of Keys (Enhancement)

This requirement is about making sure the secret keys that protect encrypted information are kept under the organisation’s physical control, even when data is stored with outside providers such as cloud or data-centre companies. If this is not done, the provider could potentially share the keys with unauthorised people or change them, which could allow others to read, tamper with, or permanently misuse your protected data.

To meet this expectation, the organisation must clearly identify which outside providers store encrypted information, set out in writing who is responsible for keeping physical control of the keys, and maintain clear procedures for how keys are created, managed, and recovered. The organisation must ensure the provider cannot access, disclose, or alter the keys, and that system settings and design records show this is enforced.

The organisation should keep evidence of the relevant settings and access activity, review records related to keys, and have a practical plan for what to do if key control is ever suspected to be compromised.

##### Customer-managed keys with provider key isolation for external storage

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create and maintain the external-provider encryption/key custody register (providers, services, environments incl. DR, encryption mechanism, customer-managed key identifiers, and evidence links) | Compliance Manager | Enterprise | 16h | — |
| Define the key-custody pattern and enforcement approach (e.g., HSM-backed or cloud KMS/HSM model ensuring provider cannot access plaintext key material; document required provider configuration constraints) | System Design Authority | Enterprise | 24h | — |
| Establish key-custody roles and dual-control procedures (Key Custodian, Security Approver, Recovery Controller) including runbooks for rotation, disablement, deletion, and recovery operations | Security Engineer | Enterprise | 20h | — |
| Configure external services to use customer-managed keys by key identifier/policy only (encryption-at-rest, prevent key identifier/policy changes without authorisation, ensure provider cannot decrypt via unauthorised paths) | Infrastructure Lead | Business Unit | 32h | — |
| Implement configuration drift controls using guardrails/IaC checks and change management gates (baseline key identifiers/policies, automated detection, approval workflow, audit trail) | DevOps Lead | Enterprise | 28h | £6,000 |
| Enable audit logging and evidence retention (key access, key policy changes, rotation/disable/delete, encryption configuration changes) and forward logs to SIEM with tested alerting/retention settings | Operations Lead | Enterprise | 24h | £3,500 |
| Update system design documentation and system security plan to explicitly state custody model, enforcement mechanisms, and responsibilities across production/test/DR | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 180h  
**Total Estimated Cost:** £9,500

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date register of external providers that store the encryption keys for all services that hold the application’s encrypted data.
- [ ] Choose and put in place a custody approach for encryption keys that ensures the unencrypted key data is not available to the external service provider—for example, using a hardware security module (HSM) under your organisation’s control, or using a customer-controlled key management system (KMS).
- [ ] Set out the main responsibilities for holding keys and write the procedures for creating, managing, rotating, disabling, deleting, and recovering keys, using dual control (two authorised people working together).
- [ ] Set up each external storage service to use encryption keys and key rules chosen and managed by the customer, and prevent the service provider from changing the encryption key identifiers or key rules without organisational approval.
- [ ] Put in place drift controls (for example, safeguards in infrastructure-as-code) to make sure encryption key identifier and policy settings stay compliant.
- [ ] Enable and send audit logs for important access events and for changes to key and encryption settings to the security information and event management (SIEM) system, keeping them for the period required by policy.
- [ ] Update the system security plan and system design documents to show where key material is securely kept (custody location) and how the provider’s keys are kept separate and protected (provider key isolation).


---

### SC-13 — Cryptographic Protection (Control)

This requirement is about protecting sensitive information using approved methods for “scrambling” (encryption) and checks (verification). This ensures that, even if data is intercepted or stolen, it cannot be read or misused. Without these protections, confidential files could be exposed when stored, messages could be read or changed while being sent between systems, signed items could be forged, and people who are generally allowed to access information but are not formally approved could still gain access to information they should not see.

To meet this expectation, the organisation must first identify which protection needs apply to its systems, including:
- data stored on devices
- data moving across networks
- digital signatures
- situations where information must be kept separate between groups

It must then put in place the required cryptography for each use. For digital signatures, it must use Federal Information Processing Standards (FIPS)-validated cryptography. For classified data, it must use National Security Agency (NSA)-approved cryptography. The organisation must also keep clear documentation and records showing what was selected, how it is configured, and evidence that it is working as intended.

##### Approved cryptography mapping and enforcement for data, signatures, separation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create per-application cryptographic use inventory mapping in-scope uses (data at rest, data in transit, digital signatures, separation of information) to concrete components/flows | Security Engineer | Enterprise | 24h | — |
| Produce cryptography mapping matrix binding each use to required cryptography type (FIPS-validated for digital signatures; NSA-approved for classified data at rest and in transit) including algorithms, formats, and module/HSM integration points | Security Engineer | Enterprise | 24h | — |
| Define approved cryptography enforcement requirements (configuration/build-time rules) for TLS, encryption-at-rest, and signature services, including certificate validation rules and key-management constraints | System Design Authority | Enterprise | 20h | — |
| Implement configuration changes for enforcement: approved TLS protocol/cipher suites and certificate validation; approved encryption-at-rest for storage/backups; approved signature service module/library/HSM profile selection | Platform Engineer | Enterprise | 48h | — |
| Implement CI/CD policy-as-code and deployment gates to validate deployed TLS/encryption/signature module settings against the approved baseline (fail builds on drift) | DevOps Lead | Enterprise | 40h | £8,000 |
| Implement runtime/configuration verification and drift detection (periodic audits, alerting, and evidence capture for deviations) | Operations Lead | Enterprise | 32h | £6,000 |
| Maintain audit-ready evidence pack: retain current FIPS validation artefacts, NSA-approved cryptography artefacts, cryptographic use inventory, mapping matrix, system design/configuration records, and automated check results; update System Security Plan references | Compliance Manager | Enterprise | 28h | — |

**Total Estimated Effort:** 216h  
**Total Estimated Cost:** £14,000

###### Actions Required for Compliance

- [ ] Document a per-application list of cryptography uses, covering data stored on systems (data at rest), data sent over networks (data in transit), digital signatures, and separation of information.
- [ ] Create a cryptography mapping matrix that links each use to either:

- **FIPS-validated** cryptography for **digital signatures**, or  
- **National Security Agency (NSA)-approved** cryptography for **classified data at rest and in transit**.
- [ ] Set up Transport Layer Security (TLS) and certificate checks to use only the approved encryption settings to protect data while it is being sent.
- [ ] Set up encryption for data stored on disk and for backups so that only National Security Agency (NSA)-approved encryption methods are used for classified information.
- [ ] Set up digital signature services to use only Federal Information Processing Standards (FIPS)-validated cryptographic modules, and record the module, library, and hardware security module (HSM) identifiers.
- [ ] Set up continuous integration and continuous delivery (CI/CD) rules, using automated checks, and add deployment approval gates to confirm that the cryptography settings used in releases match the approved baseline.
- [ ] Collect and keep current Federal Information Processing Standards (FIPS) and National Security Agency (NSA) approval evidence, and store automated verification results so they are available for audit.


---

### SC-15 — Collaborative Computing Devices and Applications (Control)

This requirement is about preventing people from secretly turning on shared meeting tools—such as cameras, microphones, networked whiteboards, and remote meeting devices—from a distance. If these controls were not in place, someone could switch these tools on without the people in the room knowing. This could cause privacy breaches, covert recording, or disruption during meetings and work.

To meet this expectation, the organisation must set clear rules so that remote activation is blocked by default and only allowed for three specific purposes:
- authorised incident response
- emergency maintenance
- accessibility support sessions that have been approved by the system owner

For accessibility support, the system must check that the system owner’s approval exists and is still valid before anything is turned on.

In addition, whenever a device or application is activated while people are physically present, it must provide a clear, unmistakable signal on the spot that it is in use, and that signal must match the device’s actual on/off state.

##### Brokered remote activation with deny-by-default and in-use indicators

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Design the brokered remote activation flow (deny-by-default) including sc-15_odp exception taxonomy, token scope model, and short-lived authorisation lifecycle | System Design Authority | Enterprise | 40h | — |
| Implement identity-first authorisation checks per exception type (incident response, emergency maintenance, accessibility support) with ticket/work order validation and system owner approval validity checks | Security Engineer | Enterprise | 56h | — |
| Integrate broker-issued scoped tokens into the collaboration/device control plane and enforce blocking of all non-broker remote activation paths | Platform Engineer | Enterprise | 64h | — |
| Implement endpoint “in use” signalling propagation (UI/controller/LED/banner) that is strictly tied to activation state; ensure deactivation clears indicators | Software Lead | Enterprise | 48h | — |
| Build audit evidence and SIEM-ready logging (request, decision, token issuance, activation/deactivation outcomes) with required fields and retention alignment | Compliance Manager | Enterprise | 32h | — |
| Add monitoring and detections for anomalous activation attempts (off-hours, repeated failures, activation outside approved windows) and define alert routing | Operations Lead | Enterprise | 24h | £6,000 |
| Execute end-to-end testing and acceptance verification (including physical-present indicator tests, exception workflows, token expiry/revocation, and negative tests) and produce audit-ready test evidence | Quality Assurance Lead | Enterprise | 40h | — |

**Total Estimated Effort:** 304h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Set up a remote activation service that issues short-lived, limited-use authorisation tokens only after checks based on exceptions are completed.
- [ ] Block or disable direct remote activation paths for collaborative devices and applications, so activation is only possible using tokens issued by the broker.
- [ ] Create and enforce a clear set of categories for exceptions covering incident response, emergency maintenance, and accessibility support, aligned to **sc-15_odp**.
- [ ] Set up the broker to work with the organisation’s identity system, including multi-factor authentication (MFA) and conditional access, and check that each requester is allowed to make the request for the relevant exception type.
- [ ] Add a check that the system owner has approved accessibility support, including verifying whether the approval has expired or been revoked when the support is activated.
- [ ] Link device activation and deactivation events to the endpoint’s screen and light (LED) display so that people nearby get a clear, unmistakable “in use” signal.
- [ ] Set up audit logging and security information and event management (SIEM) alerts for activation requests, decisions, token issuance, and activation outcomes


---

#### SC-15.1 — Physical or Logical Disconnect (Enhancement)

This expectation is about making sure people can clearly and easily stop using shared collaboration tools when their session ends, so they are not left connected by mistake. If someone does not properly end a shared session, or if their access is removed incorrectly, they could unintentionally keep contributing or still be able to view information. This increases the risk that organisational information could be misused or exposed after the meeting or work session has finished.

The organisation must provide a sensible way to disconnect from shared computing devices used for collaboration. This can be a simple button or menu option that participants can use themselves, or it can happen automatically when the session ends or when a defined condition is met. The disconnect option must still be available after collaboration, be easy to use without complex steps, and be supported by clear guidance that matches what users see on screen.

The organisation should also be able to demonstrate, using records, that the disconnect happened for the correct person and for the correct session.

##### Session-scoped logical disconnect for collaboration tools

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define target collaboration tools in-scope and map current session/entitlement model to required logical disconnect behaviour (manual + automatic) | Compliance Manager | Enterprise | 16h | — |
| Design session-scoped authorisation model and “disconnect revokes permissions” flow (token/session entitlement lifecycle, API/websocket/session termination semantics) | System Design Authority | Enterprise | 24h | — |
| Implement manual disconnect UX and backend enforcement for each in-scope tool (single obvious control, minimal steps, confirmation only where required) | Software Lead | Enterprise | 56h | — |
| Implement automatic disconnect conditions (session end/host end/inactivity timeout) with server-side revocation and verification that collaboration actions are blocked post-disconnect | Security Engineer | Enterprise | 48h | — |
| Integrate disconnect with enterprise IdP/session tokens (ensure effective access termination; handle edge cases such as reconnection, stale tokens, and multi-device sessions) | IAM Team | Enterprise | 40h | — |
| Implement audit evidence and SIEM forwarding (manual vs automatic, user identity, session identifier, timestamps, event schema, retention alignment) | Operations Lead | Enterprise | 32h | — |
| Develop participant guidance and operational runbooks (help content matching UI, contractor/partner instructions, Service Desk scripts, monitoring/incident guidance for disconnect failures) | Service Delivery Manager | Enterprise | 24h | — |

Total Estimated Effort: **240h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Take an inventory of all shared computing devices used to share organisational information, and identify which ones support permissions that apply only for the current session and automatically leave or disconnect when the session ends.
- [ ] Set up each tool so participant access lasts only for the current session, and is removed when the participant chooses **Leave**, **End**, or **Disconnect**.
- [ ] Set up automatic disconnection when a session ends and/or when there is inactivity, so it removes access permission (authorisation) rather than only changing what the user interface shows.
- [ ] Provide a standard “disconnect” button in the participant-facing manual controls (one clear action) that stays visible on the session screen after the collaboration ends.
- [ ] Link disconnect events to the organisation’s identity and session system, and make sure the specific session is ended properly.
- [ ] Set up audit records for manual versus automatic disconnections, including the user, session ID, and time of the event, and send these records to the security information and event management (SIEM) system, with retention kept for audit purposes.
- [ ] Publish and check participant guidance so it uses the exact wording and placement of the “disconnect” control shown in the user interface (UI).


---

#### SC-15.3 — Disabling and Removal in Secure Work Areas (Enhancement)

This requirement is about ensuring that, when computers are installed in the most secure rooms used for highly sensitive information, the communication and collaboration features are turned off or removed. This includes tools that let people chat, share screens, take part in video calls, or work together on documents. If this is not done, staff could accidentally or intentionally use these collaboration features inside secure work areas, which could allow unauthorised listening, recording, or sharing of sensitive conversations and information.

To meet this requirement, the organisation must keep a written, up-to-date list of every secure work area where “Secret-and-above” information is handled. This includes secure rooms such as Sensitive Compartmented Information Facilities (SCIFs) and other approved secure rooms. The organisation must also keep a written list of the specific collaboration devices and applications that must be disabled or removed on federal on-premises computers and their associated virtual copies when those computers are located in those secure rooms.

The organisation must:
- set out the rule in its procedures
- document how the disabling or removal is carried out
- apply the rule to both the physical computers and their virtual instances
- restrict who is allowed to switch the features back on
- keep evidence that the controls worked, including audit records and retained documentation
- carry out periodic checks to confirm nothing has been missed or re-enabled

##### Block/remove collaboration apps in SCIFs via secure-work-area profiles

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish authoritative secure work area inventory (SCIF/secure work areas) with identifiers, network zones/VLANs, and assignment rules | Compliance Manager | Enterprise | 24h | — |
| Establish authoritative in-scope collaboration inventory (apps/features) and map each to disable/remove methods per endpoint/VM platform | Security Engineer | Enterprise | 32h | — |
| Design “Secure Work Area Collaboration Restriction Profile” (remove vs block execution) including preventive enforcement logic and dependency handling | System Design Authority | Enterprise | 24h | — |
| Implement profile enforcement in endpoint management for physical endpoints (prevent start/usage, remove where feasible, enforce via secure-work-area assignment/detection) | Platform Engineer | Enterprise | 56h | £18,000 |
| Implement profile enforcement for virtual instances (golden image and/or per-VM configuration, ensure migration/failover does not bypass) | DevOps Lead | Enterprise | 48h | £12,000 |
| Implement change control guardrails (who can request exceptions, approval workflow, and technical controls to prevent unauthorised override) | Project Manager | Enterprise | 24h | — |
| Configure audit logging and periodic verification (evidence of profile state, app presence/exec prevention checks, reporting to audit) | Operations Lead | Enterprise | 32h | £6,000 |
| Run pilot in representative secure work areas and iterate to meet acceptance criteria (including rollback/exception handling) | Service Delivery Manager | Enterprise | 24h | — |

Total Estimated Effort: **264h**  
Total Estimated Cost: **£36,000**

###### Actions Required for Compliance

- [ ] Create and keep an official list of approved Secret+ secure work areas (secure compartmented information facilities (SCIFs) and others). Give each area a unique identifier so it can be used to trigger enforcement actions.
- [ ] Create and keep an up-to-date, approved list of the in-scope shared computing devices and applications that must be disabled or removed from federal on-premises computers and the related virtual machines.
- [ ] Create a version-controlled collaboration restriction profile for each secure work area that removes or blocks every in-scope application or feature.
- [ ] Set up endpoint management so that, when devices are assigned to (or detected in) the secure work area, the required profile is applied automatically—so that apps cannot be started or used.
- [ ] Set up virtual machine (VM) and image/automation controls so that any related virtual instances use the same security and configuration profile, and cannot avoid it during migration or failover.
- [ ] Restrict and review (audit) any ability to override, re-enable, or exempt the profile, using approved change control and privileged access controls.
- [ ] Set up audit logs and carry out regular checks to prove that enforcement controls are working during secure work area periods, and to detect any return of collaboration applications that are in scope.


---

#### SC-15.4 — Explicitly Indicate Current Participants (Enhancement)

This requirement is about ensuring that, during online meetings and teleconferences used for Department of Defense (DoD)-controlled collaborative sessions, everyone can clearly see who else is currently in the meeting. Without this, an unauthorised person could join without being noticed, and participants might unknowingly share information with the wrong people.

To meet this expectation, the organisation must:
- define which types of online meetings and teleconferences must display the current participant list; and
- configure the meeting system so that the names (or other clearly identifiable labels) of current participants are visible to all participants throughout the session.

The participant list must update automatically as people join or leave, with no hidden participants. The organisation must document how the participant display works, include this in its security planning, and keep system records showing that the participant list was available and updated during real sessions.

##### Show live participant roster for DoD-controlled meetings

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm meeting-type scope for {{ insert: param, sc-15.04_odp }} and map each to the corresponding meeting platform scheduling templates/workflows | Compliance Manager | Enterprise | 16h | — |
| Define the required roster behaviour (names/identifiers, UI placement, visibility to all attendees, update rules for late join/leave/disconnect, and “no anonymous/hidden” constraints) and produce an implementation specification | Security Engineer | Enterprise | 24h | — |
| Configure the meeting platform to enable an always-visible participant roster for the scoped meeting types (including late-join and disconnect update behaviour) | Collaboration service owner | Business Unit | 32h | — |
| Implement central configuration enforcement to prevent drift (admin policy/baseline, disable/limit meeting modes that suppress participant visibility, and add pre-session validation checks where supported) | Platform Engineer | Enterprise | 24h | — |
| Enable evidence collection: configure join/leave and roster-availability logging, ensure events are forwarded to SIEM, and define retention/alerting for audit readiness | Operations Lead | Enterprise | 28h | £8,000 |
| Conduct test and assurance: end-to-end test plan, execute test cases for late join/abrupt disconnect/role variations, and produce an audit-ready test report with screenshots/log extracts | Quality Assurance Lead | Enterprise | 24h | — |
| Update the system security plan and operational runbooks to document the roster mechanism, where it appears, how it updates, how drift is prevented, and how evidence is collected | Data Protection Officer | Enterprise | 16h | — |

**Total Estimated Effort:** 184h  
**Total Estimated Cost:** £8,000

###### Actions Required for Compliance

- [ ] Identify and record the specific meeting types and workflows that make up {{ insert: param, sc-15.04_odp }}.
- [ ] Turn on the participant list (people-in-meeting) for those meeting types, and make sure it stays visible to everyone throughout the session.
- [ ] For meetings run under Department of Defense (DoD) control, disable or limit any meeting settings that reduce or hide who can see other participants (for example, anonymous or hidden participant options).
- [ ] Test and verify roster updates when participants join late or leave, confirming the roster updates automatically and correctly.
- [ ] Apply the roster-display settings through central administration using policy and configuration management, and set up drift detection to identify any changes from the approved settings.
- [ ] Enable and keep records of audit and log evidence for people joining or leaving meetings and for roster availability, and send the relevant events to the security information and event management (SIEM) system.
- [ ] Update the system security plan to explain how the participant indicator works, where it appears in the user interface, what happens when it is updated, and what evidence is used to support it.


---

### SC-16 — Transmission of Security and Privacy Attributes (Control)

This requirement is about making sure that whenever information is sent between different systems, or moves within the same system, it carries the correct labels. These labels tell everyone how the information must be handled and which privacy rules apply. Without this, sensitive information could be shared too widely, copied, or processed in ways that are not allowed. It could also be used for the wrong purpose, or without the correct steps to protect people’s privacy, which could lead to legal, financial, and reputational harm.

To meet this expectation, the organisation must define:

- **Security labels** for every data object, including its classification (for example, *Secret* or *Confidential*), any handling restrictions, limits on who it may be shared with, who is allowed to see it, and the authorised limits on how it may be transferred and processed.
- **Privacy labels** for the same data objects, including whether it contains personal data or health data, the permitted purposes for using it, and the flags needed to manage individuals’ rights.

The organisation must ensure these labels are attached and kept intact during both:
- transfers between systems, and
- transfers between components within the same system.

These labels must be used to guide decisions about who can access the information and how it may be used. This must be supported by documented procedures, security and privacy plans, clear responsibility for system administrators, and audit records showing that the labels were carried correctly and that enforcement worked as intended.

##### Propagate security/privacy attributes on all exchanged data

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the security/privacy attribute schema aligned to sc-16_prm_1 (classification, handling caveats, dissemination limits, PII/PHI indicator, permitted purposes, rights-handling flags) and publish the canonical schema + versioning approach | Compliance Manager | Enterprise | 24h | — |
| Design the standard machine-readable attribute envelope for all exchange types (API headers, message headers, file sidecar/embedded properties, DB event metadata) including mapping rules and required/optional fields | System Design Authority | Enterprise | 32h | — |
| Implement propagation middleware/shared library to attach, extract, validate, and preserve attributes across component-to-component hops (including DTO/serialisation transformation safeguards and label-stripping prevention) | Platform Engineer | Enterprise | 72h | — |
| Implement receiving-side enforcement engine (access control, information flow control, privacy permitted-purpose/rights checks) with deny/quarantine default for missing/invalid attributes and policy rule identifiers | Security Engineer | Enterprise | 56h | — |
| Integrate audit evidence generation into the exchange pipeline (log attribute sets or cryptographic hashes, validation failures, enforcement outcomes; ensure SIEM-friendly structure and retention alignment) | Operations Lead | Enterprise | 40h | — |
| Extend integration points and adapters so every outbound/inbound exchange path uses the envelope (web/API, messaging, file transfer, internal service calls, replication events) and add automated regression tests for preservation/enforcement | Software Lead | Business Unit | 64h | — |
| Run security/privacy validation and acceptance testing (representative production-like flows, negative tests for missing/invalid labels, end-to-end audit evidence verification) and produce implementation sign-off pack | Quality Assurance Lead | Business Unit | 24h | — |

**Total Estimated Effort:** 312h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define the required security and privacy information structure (schema) and the rules for how it is mapped for **sc-16_prm_1**, including: classification, handling caveats, limits on who it can be shared with, whether it contains personal data or protected health information, permitted purposes for use, and the flags that control how rights are handled.
- [ ] Set up a standard “metadata envelope” for outgoing data exchanges (for example, in application programming interface (API) headers, message headers, or document properties). This envelope should carry the full set of attributes with every data object.
- [ ] Create a shared “propagation” middleware library that checks that required attributes are present and correctly formatted, and ensures those attributes are carried forward unchanged through every step from one component to another.
- [ ] Set up enforcement on the receiving side to apply access control, control how information can flow, and handle privacy permitted purposes and rights based on the attributes received.
- [ ] Set a default “deny” or “quarantine” response for exchanges when attribute values are missing, incorrectly formed, or not authorised, and make sure this same rule is applied consistently across every integration point.
- [ ] Set up audit logging to record when attributes are sent and when enforcement decisions are made (including any validation failures) so that evidence can be generated.
- [ ] Update the integration runbooks and change-management checklists so that, for every new system or component interface, teams must use the propagation/envelope mechanism.


---

#### SC-16.1 — Integrity Verification (Enhancement)

This requirement is about making sure the “labels and settings” that control who can access information and how personal data is handled are not changed without authorisation while they are being sent between systems. If these security and privacy labels are altered, the organisation could unintentionally give access to the wrong people or apply the wrong privacy treatment. This would undermine trust and could lead to regulatory action and reputational damage.

To meet this expectation, the organisation must first decide exactly which security attributes and which privacy attributes are sent between systems, and record how each one is sent. The receiving systems must then verify that both sets of attributes arrive unchanged, using an integrity-check approach designed to detect unauthorised tampering. If the check shows the attributes were changed, the system must treat them as invalid and not apply them.

The organisation must also assign clear responsibility to named roles. It must keep evidence in system design documents, configuration records, audit logs, and the relevant security and privacy plans, including procedures that clearly state what to do if a check fails.

##### Signed security/privacy attribute tokens with fail-closed verification

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authoritative inventory of transmitted security & privacy attributes and map each attribute to token claims (including schema versioning rules) | Compliance Manager | Enterprise | 24h | — |
| Design canonical signed token schema (JWS/JWE options), including deterministic claim serialisation, `iss/aud/exp/nbf/jti` requirements, and fail-closed enforcement semantics | System Design Authority | Enterprise | 32h | — |
| Implement token issuance in the authoritative source services (JWS signing, `kid` handling, issuer/audience configuration, optional JWE confidentiality) | Software Lead | Business Unit | 56h | — |
| Implement fail-closed token verification across all receiving integration points (API gateways, services, message consumers): signature, issuer/audience, expiry/not-before, schema/version checks, and deny/withhold decisioning | Platform Engineer | Business Unit | 72h | — |
| Integrate audit logging for verification outcomes (success/failure reason codes, `jti`, issuer/audience, enforcement decision) and forward to SIEM with correlation identifiers | Operations Lead | Department | 24h | — |
| Establish key management and rotation procedures using enterprise KMS/HSM (key lifecycle, access controls, rotation schedule, incident handling for compromised/expired keys) | Security Engineer | Enterprise | 40h | £15,000 |
| Create and publish security/privacy procedures and runbooks (governance of attribute set, schema governance, receiver failure handling, monitoring thresholds, and responsibilities) | Data Protection Officer | Enterprise | 24h | — |

**Total Estimated Effort**: 272h  
**Total Estimated Cost**: £15,000

###### Actions Required for Compliance

- [ ] Create an inventory of the security attributes and privacy attributes that are sent, and map each one to the token’s claims.
- [ ] Define and publish a single, standard token claim format (including version number, issuer, intended audience, and validity dates/times).
- [ ] Set up token issuing using asymmetric digital signatures, with keys stored and managed in an enterprise key management system (KMS) or hardware security module (HSM), and rotate the keys regularly.
- [ ] Before applying any attributes, verify on the receiving side that the message is valid by checking its signature, sender (issuer), intended recipient (audience), time window (expiry and not-before), and the format/version of its claims.
- [ ] Set the system to “fail closed” so that if integrity checks fail, the system rejects or withholds the requested attributes and applies safe default settings.
- [ ] Add audit logging of verification results (including reason codes, token identifiers, and enforcement decisions) to the security information and event management (SIEM) system.
- [ ] Update the security and privacy procedures or plans to document how information is sent, how it is checked, what happens if it fails, and the named responsibilities for each role.


---

#### SC-16.2 — Anti-spoofing Mechanisms (Enhancement)

This requirement is about making sure the system’s “security is working” signals cannot be faked. Without strong anti-fraud checks, an attacker could change the information the organisation uses to decide whether security protections have actually been applied—so it would appear that everything is secure when it is not.

To meet this requirement, the organisation must clearly identify which “security status” information must be protected. It must then ensure the system has safeguards that prevent unauthorised changes and that confirm the displayed status is based on real, working security measures.

The organisation must also protect this security-status information while it is being sent between systems and while it is stored. It must limit who can affect it, and ensure that only authorised actions can update it.

Finally, the organisation must:
- keep audit records showing what was changed, when, and by whom
- document how the safeguards work and how they are configured
- include this in the system security plan
- assign responsible staff to run and monitor it
- maintain procedures for what to do if tampering is suspected

##### Signed security-status events with verification and tamper rejection

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define protected security-status attributes and authoritative event schema (attribute IDs, allowed values, success/unknown mapping, replay-resistance fields, producer identity fields) | System Design Authority | Enterprise | 24h | — |
| Establish trust boundaries and producer allow-list (authorised producer services, environment scoping for prod/test, key-to-producer mapping rules) | Cyber Security Lead | Enterprise | 16h | — |
| Implement producer-side signing: event canonicalisation, signing using enterprise KMS/HSM keys, inclusion of key ID, producer ID, timestamp, event ID, nonce/sequence, and signing failure handling | Software Lead | Department | 40h | — |
| Implement consumer-side verification and tamper rejection: signature verification, schema validation, stale/nonce/sequence checks, unknown-producer handling, and “reject→attribute unknown/invalid” state management | Software Lead | Department | 48h | — |
| Implement secure transport and tamper-evident retention: mutual TLS configuration, append-only storage/logging of received payload + verification metadata, and retention policy alignment | Infrastructure Lead | Enterprise | 32h | £12,000 |
| Add audit evidence and SOC alerting: dashboards/alerts for signature failures, replay/staleness, producer mismatch, repeated invalid events; ensure audit logs record received event, verification outcome, and action taken | Compliance Manager | Enterprise | 24h | £6,000 |
| End-to-end testing and assurance: test plan, negative test cases (forged signatures, wrong key IDs, stale timestamps, replayed nonces), performance impact checks, and audit-ready evidence pack | Quality Assurance Lead | Department | 32h | — |

**Total Estimated Effort:** 216h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Create an inventory of security-status details that show when security checks have been completed successfully, and define an event format (schema) for each one.
- [ ] Choose and record trusted authorised producers for each attribute, and confirm they are permitted to generate security-status events.
- [ ] Set up digital signing of status events on the producer side using enterprise key management system (KMS) or hardware security module (HSM) keys, and include fields that make the events resistant to replay attacks.
- [ ] Set up signature checking on the customer side, and reject the request (or mark it as unknown) if the signature check fails for any reason.
- [ ] Set up mutual Transport Layer Security (mutual TLS) for sending events between producers and consumers, and save the signed event data along with verification details in a tamper-evident log.
- [ ] Add security information and event management (SIEM) and monitoring alerts for invalid digital signatures, replayed or outdated messages, and mismatches between the message producer, and check that alerts are sent to the correct recipients.
- [ ] Use tests to confirm that altered or unsigned events cannot be used to mark security processing as successful.


---

#### SC-16.3 — Cryptographic Binding (Enhancement)

This requirement is about ensuring that any security and privacy information sent with a data item is securely “bound” to that data, so it cannot be quietly changed or separated. Without this, someone could tamper with the security or privacy details (for example, changing how sensitive the data is) or swap those details between messages. That could lead to unauthorised access, incorrect handling, or privacy breaches.

To meet this expectation, the organisation must use a signed-and-encrypted message approach. This means it must:
- digitally sign the security and privacy labels as part of the signed message information;
- encrypt the whole message using authenticated encryption, so any changes to the message are detected; and
- reject the message if the signature check fails or if the encryption integrity check fails.

The organisation must also:
- document how this works;
- configure the system to use the required methods for transmissions that include these attributes;
- keep evidence in audit records showing that the checks were performed; and
- maintain clear procedures and responsibilities in its security planning, so administrators can implement and operate it correctly.

##### CMS-signed, AES-GCM encrypted envelope binding security/privacy attributes

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the envelope schema (fields, canonicalisation rules, payload hash spec, nonce/IV requirements, recipient/scope model) and publish as an engineering design document | System Design Authority | Enterprise | 24h | — |
| Implement CMS/PKCS#7 signing of canonicalised security/privacy attributes + payload hash + message identifier (including certificate selection and chain handling) | Software Lead | Enterprise | 56h | — |
| Implement AES-GCM encryption of the signed structure with per-message unique IV/nonce, and define AAD usage for stable context (channel/service identifier, recipient scope) | Security Engineer | Enterprise | 48h | — |
| Implement receive-side verification workflow (verify CMS signature first, then decrypt AES-GCM; hard-fail on any failure; ensure attributes are never applied on invalid envelopes) | Platform Engineer | Enterprise | 40h | — |
| Enforce boundary validation and non-conforming traffic handling (schema validation, reject/quarantine policy, metrics for envelope compliance rate) | Operations Lead | Enterprise | 24h | — |
| Add audit evidence generation and SIEM-ready logging (message identifier, correlation IDs, signature valid/invalid, certificate serial/thumbprint, AES-GCM auth result) plus alerting thresholds for verification failures | Compliance Manager | Enterprise | 32h | — |
| Build and run test suite (known-answer crypto tests, tamper tests for attributes/context, replay/nonce misuse tests, interoperability tests across environments) and produce acceptance evidence | Quality Assurance Lead | Enterprise | 48h | — |

**Total Estimated Effort:** 272h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define the structure of the message “envelope” that carries attributes, including the message identifier, a nonce or timestamp, the security label(s), the privacy attribute(s), the payload hash, and the intended recipient(s) or scope.
- [ ] Implement content management system (CMS) public key cryptography standards (PKCS) #7 signing over signed metadata that has been put into a standard (canonical) format, and that includes the security and privacy attributes and the hash of the payload.
- [ ] Encrypt the signed message envelope using Advanced Encryption Standard in Galois/Counter Mode (AES-GCM). Use a different, unique initial value (IV) for each message, and include additional authenticated data (AAD) that stays the same for the context (for example, the channel or service identifier and the intended recipient scope).
- [ ] Set up receiving-side checks to verify the content management system (CMS) signature, then decrypt the message using advanced encryption standard in Galois/Counter Mode (AES-GCM). Reject any message if the signature check or any authentication step fails.
- [ ] Use boundary checks at the API gateway, service mesh, and message broker to block or quarantine messages that do not meet requirements—specifically, messages that include attributes but are missing the required envelope.
- [ ] Record an audit log for each message’s signature check result, certificate identifier, AES-GCM authentication result, message identifier, and correlation identifiers.


---

### SC-17 — Public Key Infrastructure Certificates (Control)

This requirement is about ensuring the digital certificates your systems depend on are issued correctly, and that your organisation only trusts approved certificate sources. If certificates are issued without the required rules, or by an unapproved provider, or if your systems are allowed to trust unknown or unapproved certificate authorities, attackers could pretend to be trusted services or users. This could result in fraud, unauthorised access, or sensitive information being intercepted, changed, or both.

To meet this expectation, the organisation must either issue public key certificates for Secret and Confidential systems in line with the Department of Defense (DoD) Public Key Infrastructure (PKI) Certificate Policy for Secret and Confidential systems. This includes issuance aligned with International Traffic in Arms Regulations (ITAR)/Export Administration Regulations (EAR) and the Cybersecurity Maturity Model Certification (CMMC). Alternatively, it must obtain these certificates from an approved certificate service provider.

The organisation must also keep its trust lists up to date, so that only approved trust anchors are included in its trust and certificate stores. It must keep clear records and follow defined procedures showing how certificates are requested, approved, and issued, and how the trust lists are kept accurate and restricted to approved entries.

##### Policy-controlled PKI issuance and approved trust-anchor stores

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Publish/maintain the governed certificate policy package for Secret/Confidential systems (DOD-CP-aligned; ITAR/EAR and CMMC-aligned where applicable), including mappings to request validation, approval, issuance, revocation, lifecycle, and key protection | Compliance Manager | Enterprise | 24h | — |
| Define and document the end-to-end controlled certificate issuance workflow (intake → identity/authorisation validation → authorised approval → issuance → revocation → lifecycle), including role definitions, segregation of duties, and immutable audit log requirements | Compliance Manager | Enterprise | 32h | — |
| Implement/enable the issuance workflow in the PKI/CA operations process (including enforcement that only authorised roles can trigger issuance and that all events are recorded for audit) | Cyber Security Lead | Enterprise | 40h | — |
| Create and maintain an “approved trust anchors” inventory (root/intermediate CA certificates) with versioning, ownership, and controlled change procedure (including approval evidence and rollback approach) | Compliance Manager | Enterprise | 24h | — |
| Configure and enforce organisation-managed trust/certificate stores across environments (endpoints via MDM/enterprise policy; servers/OS trust stores; application/runtime trust bundles for containers/microservices; where applicable, browser trust management) with environment-specific baselines | Platform Engineer | Enterprise | 56h | — |
| Implement policy-as-code enforcement in CI/CD and release pipelines to block deployments that introduce unapproved CA certificates/trust bundles (including scanning of artefacts/images/configs and requiring attested trust-bundle versions) | DevOps Lead | Enterprise | 48h | £12,000 |
| Establish evidence generation and retention for auditors: issuance workflow audit logs, trust-anchor inventory change history, trust-store configuration snapshots, and pipeline attestations (including retention periods and access controls) | Data Protection Officer | Enterprise | 24h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £12,000

###### Actions Required for Compliance

- [ ] Publish and approve the certificate policy for Secret and Confidential systems exactly according to the organisation’s defined standard (DOD-CP), including certificate issuance that is aligned with the International Traffic in Arms Regulations (ITAR), the Export Administration Regulations (EAR), and the Cybersecurity Maturity Model Certification (CMMC).
- [ ] Define and document the full certificate issuing process—from when a request is received, through checks and authorised approval, to issuing and later revocation or end-of-life handling. Include the specific named roles involved and what each role is responsible for.
- [ ] Set up role-based controls so only authorised roles can approve and trigger certificate issuance, and enable tamper-proof audit logs that record each request, approval, and issuance.
- [ ] Create and keep an approved list of trusted certificate “anchors” (root and intermediate certificate authority certificates), with version tracking and formal approval for any changes.
- [ ] Use central configuration management to configure application and infrastructure certificate stores so they contain only the approved trust anchors.
- [ ] Add continuous integration and continuous delivery (CI/CD) and checks during deployment to stop unapproved certificate authority (CA) certificates or trusted certificate bundles from being added to application files or to the system trust store used at runtime.
- [ ] Collect and keep audit evidence: records of the certificate issuance workflow, the approved versions of the trust-anchor inventory, and saved snapshots of the trust-store configuration for each environment.


---

### SC-18 — Mobile Code (Control)

This expectation is about preventing risky software or content that can be sent over the internet or email from being run on your organisation’s computers and devices. Without clear rules, someone could accidentally (or on purpose) allow harmful code to run, which could damage systems, steal information, or disrupt services.

To meet this expectation, the organisation must clearly set out, in writing, which types of mobile code and which specific technologies are allowed and which are not. It must also keep up-to-date lists that staff and reviewers can check. Mobile code must only be allowed to run when it has been explicitly approved. The organisation must monitor mobile code activity so that both allowed and blocked attempts are recorded and can be reviewed.

The organisation should also require that approved mobile code comes from trusted sources—for example, by using digitally signed content. It must keep evidence of approvals and monitoring results so that decisions can be checked during audits.

##### Digitally signed mobile code allowlisting with endpoint enforcement

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define acceptable/unacceptable mobile code policy (scope, rationale, device/browser/applet boundaries, safe-fail requirements) | Compliance Manager | Enterprise | 24h | — |
| Create authorisation record model and schema (technology identifier, trusted signing authority/certificate details, allowed origins, scope, expiry/renewal rules) | Security Engineer | Enterprise | 32h | — |
| Implement trust-first enforcement mapping (authorisation records → endpoint/browser configuration rules; fail-closed for unsigned/untrusted content) | System Design Authority | Enterprise | 40h | — |
| Build managed allow/block baselines for high-risk/legacy mobile code technologies (e.g., disable legacy plugin/script engines; restrict risky web features; document user/system messaging) | Infrastructure Lead | Enterprise | 32h | — |
| Develop policy-as-code pipeline (version-controlled policy, change approvals, automated packaging for endpoint management deployment) | DevOps Lead | Enterprise | 40h | — |
| Configure telemetry, audit logging, and SIEM integration for both allowed and blocked attempts (normalised event schema, retention, correlation, dashboards) | Operations Lead | Enterprise | 40h | £15,000 |
| Execute pilot rollout and validation (test cases for trusted/expired/untrusted signatures; evidence pack for SC-18 audit; remediation of gaps) | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 232h  
**Total Estimated Cost:** £15,000

###### Actions Required for Compliance

- [ ] Publish written lists of acceptable and unacceptable mobile code and technology, with a clearly defined scope for servers, endpoints, and mobile devices.
- [ ] Create an authorisation record template that links each approved mobile code type or technology to the trusted signing details, publisher details, and certificate details, including the expiry date.
- [ ] Set managed browser and device policies so that mobile code can run only if its digital signature and trust checks are successful, and only for authorised mobile code.
- [ ] Use enterprise configuration baselines to disable or limit mobile code technologies and features that are not acceptable, and make sure the system fails safely if they are encountered.
- [ ] Set up a “policy as code” workflow to version, approve, and roll out mobile code enforcement configuration to endpoint devices.
- [ ] Set up and centralise logging and telemetry for both permitted and blocked attempts to run mobile code, and send the records to security information and event management (SIEM) with retention for audit purposes.


---

#### SC-18.1 — Identify Unacceptable Code and Take Corrective Actions (Enhancement)

This requirement is about finding dangerous “code-in-files” before they reach people, then stopping them and raising an alert. In everyday terms, it covers word-processing documents that secretly contain embedded instructions (macros), as well as any scripts or other active content that has been identified as malicious or not allowed by your rules. Without this, harmful content could be sent to staff, which could lead to data theft, fraud, or disruption.

To meet this expectation, the organisation must:
- Keep a documented list of what it considers unacceptable.
- Ensure its systems can detect that specific type of content.
- When it is found, immediately block it from being sent, quarantine it so it cannot be used or delivered normally, and alert both the system owner and the security operations team so they can investigate.
- Record what was detected and what actions were taken, and keep those records so follow-up investigations can be completed.

##### Gateway enforcement to block/quarantine unacceptable mobile code

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm gateway enforcement architecture and inspection points (inbound/outbound email + web/file upload/download paths) and produce an implementation design | System Design Authority | Enterprise | 24h | — |
| Define “unacceptable mobile code” detection rules and corrective action workflow (block/quarantine/alert) as policy-as-configuration, including macro-enabled word-processing formats and active content classification | Compliance Manager | Enterprise | 20h | — |
| Implement gateway inspection/enforcement configuration (content inspection, macro/active content detection, deny/block logic, quarantine routing, and alert triggers) | Security Engineer | Enterprise | 56h | £18,000 |
| Build quarantine repository integration (secure storage, unique quarantine ID generation, access controls, retention hooks, and retrieval workflow for authorised investigation) | Platform Engineer | Enterprise | 32h | £6,000 |
| Implement auditable evidence logging (event schema, file hash capture, metadata capture, policy match recording, timestamps, and SIEM forwarding) | Security Engineer | Enterprise | 28h | £4,000 |
| Develop and execute test plan (representative macro-enabled documents + malicious/policy-violating scripts/active content), validate block/quarantine behaviour and alert content for both owner and SOC | Quality Assurance Lead | Enterprise | 24h | — |
| Operationalise (runbooks, alert routing validation, change management packaging, and initial monitoring/metrics for false positives/throughput) | Operations Lead | Enterprise | 20h | — |

**Total Estimated Effort:** 204h  
**Total Estimated Cost:** £28,000

###### Actions Required for Compliance

- [ ] Create and keep a version-controlled record of the gateway policy that defines what counts as “unacceptable mobile code” and the required “corrective actions” (block, quarantine, alert).
- [ ] Send all relevant incoming and outgoing data paths used by the application (email and file upload/download channels) through the inspection and enforcement gateway.
- [ ] Set up the gateway to check word-processing files for hidden macros, and to block scripts or other active content that has been flagged as malicious or against policy.
- [ ] Set up automatic enforcement to block the transmission and place the detected item in quarantine, creating a unique quarantine ID.
- [ ] Set up alerts to be sent through the security operations centre (SOC), security information and event management (SIEM), and security orchestration, automation and response (SOAR), and include the reason for the alert and the quarantine reference ID in the system-owner notification process.
- [ ] Turn on audit logging for every detection and enforcement event (including the policy match, file hash, metadata, timestamps, and the action taken), and confirm the logs are kept for the required retention period.
- [ ] Run validation tests using realistic macro-enabled documents and harmful or policy-violating active content to confirm the system blocks, quarantines, or alerts as expected.


---

#### SC-18.2 — Acquisition, Development, and Use (Enhancement)

This requirement is about making sure any mobile code your organisation plans to use in its systems is trustworthy before it is put into live services. Without these checks, harmful or changed code could be introduced, potentially stealing data, disrupting services, or allowing attackers to gain access through features intended to help users.

To meet this expectation, the organisation must ensure that every piece of mobile code it obtains, builds, or uses for release is:

- first approved by the system owner  
- scanned for malware (malicious software)  
- digitally signed so it can be traced back to an authorised source  

Before release, the code must be run only in a separate testing environment (sandbox). This testing must use the minimum access needed, and the organisation must record what happens during the test.

The organisation should be able to provide evidence of approval, malware scanning results, digital signing, and the sandbox test with limited access and logging, for both third-party code and code developed internally.

##### Mobile code pipeline with approval, scan, signing, sandbox gates

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define mobile code inventory schema and evidence model (artefact hash/version, target system, system owner, approval ID, scan/sign/sandbox run references) and integrate with existing CMDB/change tooling | Compliance Manager | Enterprise | 24h | — |
| Implement fail-closed CI/CD pipeline gates for promotion (approval gate, malware scan gate, signing gate, sandbox gate) with artefact-byte immutability checks and promotion blocked on missing/invalid evidence | DevOps Lead | Enterprise | 80h | — |
| Integrate malware scanning for exact artefact bytes (approved scanner/profile, clean/known-good policy, scan report generation, evidence storage, allow-list handling where required) | Security Engineer | Enterprise | 56h | £18,000 |
| Implement digital signing and signature verification (key/cert integration, signing service/runner, certificate chain validation, promotion-time re-verification, signing evidence capture) | Security Engineer | Enterprise | 56h | £12,000 |
| Build sandbox-only execution harness with least-privilege test identity (isolated VM/container, restricted egress/filesystem, runtime/audit logging, run ID/permissions profile capture, deterministic execution wrapper) | Platform Engineer | Enterprise | 72h | £25,000 |
| Enforce “use through pipeline only” by disabling/constraining direct production deployment paths for mobile code artefacts (RBAC/permissions, deployment endpoint controls, pipeline-only promotion workflow) | Operations Lead | Enterprise | 32h | — |
| Implement auditable evidence trail and retention (link artefact hash → approval ID → scan report ID → signing metadata → sandbox run ID → promotion decision; export to SIEM/audit store) | Data Protection Officer | Enterprise | 40h | — |
| Testing, security validation, and go-live readiness (end-to-end pipeline test cases, negative tests for fail-closed behaviour, signing/scan/sandbox assurance validation, documentation for auditors) | Quality Assurance Lead | Enterprise | 32h | — |
| **Total Estimated Effort** |  |  | **392h** |  |
| **Total Estimated Cost** |  |  |  | **£55,000** |

###### Actions Required for Compliance

- [ ] Define the organisation’s mobile code coverage and record the artefact hash and version details so the build pipeline can be tracked.
- [ ] Set up continuous integration and continuous delivery (CI/CD) promotion “gates” that require the system owner’s approval. The approval must be linked to the specific software package (artefact) version and the target system.
- [ ] Add an approved malware scan step and save the scan reports as proof for the promotion.
- [ ] Use approved digital signing keys and certificates, and check that every signature is valid when the software is built and when it is promoted to the next stage.
- [ ] Set up an isolated “sandbox” environment that runs only the candidate file, using a test account with the minimum necessary permissions, and collects audit logs.
- [ ] Limit production software releases so mobile code can only be moved into production through the approved, controlled pipeline process.
- [ ] Set how long to keep evidence records for the approval ID, scan report ID, signing details, sandbox run ID, and promotion decision logs.


---

#### SC-18.3 — Prevent Downloading and Execution (Enhancement)

This requirement is about preventing unapproved “plug-in” style code from the internet from being brought onto your devices and then run. If this kind of code is allowed, it could quietly change settings, steal information, or help criminals take control of systems, because the code may be unknown, not trusted, or not properly checked.

To meet this expectation, the organisation must block any unapproved mobile code from external sources—such as unsigned JavaScript, Java applets, ActiveX, or Flash—so it cannot be downloaded and cannot run on the system. In practice, the organisation should put in place and maintain the right technical protections and usage rules so that attempts to load this unapproved code are stopped every time, including when it arrives through common ways users access external content, while approved code (where the organisation has explicitly allowed it) can still run normally.

##### Block unapproved mobile code download and execution via deny-by-default

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define deny-by-default scope for “unacceptable mobile code” (sc-18.03_odp) and map to concrete endpoint/browser/plugin/runtime controls (including any approved exceptions/allow-list process) | Compliance Manager | Enterprise | 16h | — |
| Create managed endpoint/browser baseline to remove/hard-disable legacy mobile-code runtimes (e.g., Flash/Java applets/ActiveX/other plugin frameworks) and enforce deny-by-default for external-origin execution | Endpoint/Client Engineering Lead | Enterprise | 40h | £6,000 |
| Implement runtime execution blocking for remaining mobile-code vectors (e.g., restrict script execution to approved contexts/origins; disable/limit interpreters where applicable; enforce trust boundaries) | Security Engineer | Enterprise | 48h | £8,000 |
| Deploy application control rules to prevent execution of dropped/unapproved binaries or script interpreters used as mobile-code payloads; validate rule coverage across common user entry points | Platform Engineer | Enterprise | 56h | £12,000 |
| Extend enforcement to additional client entry points (document viewers and remote/web access clients) and confirm consistent behaviour with browser controls | Infrastructure Lead | Enterprise | 32h | £4,000 |
| Configure SIEM telemetry and evidence model for blocked download and blocked execution events (event mappings, required fields, retention alignment, and reason/category taxonomy) | Cyber Security Lead | Enterprise | 32h | £3,000 |
| Build and run test plan (download + runtime execution) across representative endpoints/environments; produce audit-ready evidence pack and remediate gaps | Quality Assurance Lead | Enterprise | 24h | — |

Total Estimated Effort: **248h**  
Total Estimated Cost: **£33,000**

###### Actions Required for Compliance

- [ ] Create a managed “deny by default” baseline configuration that disables or blocks the mobile-code runtimes identified in **SC-18.03 ODP** (for example, **Adobe Flash**, **Java applets**, and **ActiveX**) on all standard devices.
- [ ] Set client runtime rules to stop unapproved mobile code from running when it comes from outside sources. Only allow script and plug-in execution in approved situations, with exceptions only where explicitly permitted.
- [ ] Set up endpoint application control to stop unapproved programmes or scripts from running, including ones delivered via blocked mobile code that could be used to execute harmful payloads.
- [ ] Connect client and endpoint enforcement logs to the security information and event management (SIEM) system, and make sure each event records the user and device, the source and content identifier, and the reason for the enforcement action.
- [ ] Test and record that access rules are enforced at every relevant entry point, including the web browser, the document viewer, and any remote or web-based client applications used to reach external content.
- [ ] Set up an exception process for any mobile code that has been explicitly approved, and make sure exceptions are limited to the smallest possible set of allowed items (allow-lists) with monitoring in place.


---

#### SC-18.4 — Prevent Automatic Execution (Enhancement)

This requirement is about preventing suspicious code from running automatically when someone opens an email or clicks a link. It also ensures that people must explicitly confirm before anything that could be risky is opened. Without this, a harmful file or script could start just because an email was viewed or a link was clicked. This could lead to unwanted downloads, unexpected pop-ups, or malware running on company devices.

To meet this expectation, the organisation must keep an up-to-date list of the specific email applications and web browsers used to open attachments and links. It must then configure each one so mobile code cannot run automatically from email attachments or web links. The organisation must also turn off auto-run features for portable storage devices such as USB drives, CDs and DVDs.

Finally, the organisation must ensure users are prompted to confirm before opening attachments or clicking links, and it must be able to demonstrate that the confirmation prompt appears before anything runs.

##### Disable mobile-code auto-execution and enforce user prompts

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish and govern the in-scope application set (sc-18.04_odp.01): compile approved email clients and web browsers from endpoint management inventory; define versioning and change-control workflow | Compliance Manager | Enterprise | 24h | — |
| Create secure configuration baselines for each in-scope email client and browser (disable preview/auto-opening; require explicit user action before opening potentially executable content) | Security Engineer | Enterprise | 40h | — |
| Implement configuration deployment via MDM/UEM and/or endpoint management tooling; ensure settings are enforced and locked (where supported) | DevOps Lead | Enterprise | 32h | £6,000 |
| Implement consistent prompt-before-execution user experience (sc-18.04_odp.02) across in-scope apps; verify “Cancel/No” blocks the action | Security Engineer | Enterprise | 28h | — |
| Disable portable media auto-run/auto-execute at the managed endpoint system level; validate no standard user action can bypass (within supported OS controls) | Infrastructure Lead | Enterprise | 24h | — |
| Develop and execute controlled validation tests using safe payloads/links for each in-scope app and for portable media; capture results demonstrating non-execution and prompt timing | Quality Assurance Lead | Enterprise | 40h | — |
| Produce audit-ready evidence pack: configuration state reports, baseline references, test scripts/results, and exception handling approach (if any) | Compliance Manager | Enterprise | 20h | — |

| Total Estimated Effort |  |  | **228h** |  |
| Total Estimated Cost |  |  |  | **£6,000** |

###### Actions Required for Compliance

- [ ] Create and keep up to date the approved list of in-scope email clients and web browsers (sc-18.04_odp.01) using the device inventory and the change control process.
- [ ] Turn off email client features that automatically preview or open attachments, as these could cause mobile code to run automatically.
- [ ] Turn off the browser’s automatic opening of downloaded files, and require the user to explicitly confirm before opening any item that could be executable.
- [ ] Set up the required “confirm before opening/clicking” user prompt workflow for attachments and links (sc-18.04_odp.02), and make sure that choosing “Cancel/No” stops the action from running.
- [ ] Turn off automatic start (auto-run/auto-execute) for USB and CD/DVD portable media on the managed endpoint at the system level.
- [ ] For each in-scope application, run controlled validation tests to prove that nothing runs when a page is viewed or loaded, and that the prompt is shown before anything executes.
- [ ] Gather and keep configuration reports and test results to be ready for audits


---

#### SC-18.5 — Allow Execution Only in Confined Environments (Enhancement)

This requirement is about ensuring that any approved “mobile code” (software that is sent to, or runs from, outside sources) can only run inside tightly controlled, pre-approved virtual machines that are set aside for this purpose. In practice, it helps prevent harmful or unwanted code from spreading from a place where it was meant to be tested or used into other parts of your systems, which could lead to disruption, data loss, or unauthorised access.

To meet this expectation, the organisation must keep an up-to-date, formally approved written list of the specific confined virtual machines where mobile code is allowed. This list must also state which types of mobile code are acceptable and the rules for what it may do while running there. The system must be set up to enforce this boundary by blocking execution anywhere outside the approved list, and it must keep records showing both successful allowed runs and blocked attempts.

The organisation must also document how this is designed, how it is managed day to day, who is responsible, and how it is included in its security planning.

##### Confined VM allow-list enforcement for permitted mobile code

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authoritative confined VM inventory (VM unique IDs/names, environment tags, ownership, lifecycle rules) and publish as version-controlled configuration | Infrastructure Lead | Enterprise | 24h | — |
| Define permitted mobile code allow-list (identity model, signer/version/hash fields, approval workflow inputs, and mapping to runtime artefacts) | Security Engineer | Enterprise | 32h | — |
| Design and implement deny-by-default enforcement in the orchestration/launch workflow (confined VM eligibility check + mobile code identity match; no “fallback/any VM” path) | System Design Authority | Enterprise | 56h | — |
| Implement runtime enforcement hooks and identity extraction (mobile code identifier calculation/verification and VM identifier capture) with deterministic allow/deny outcomes | Software Lead | Enterprise | 48h | — |
| Harden confined VMs to support confinement intent (least-privilege service accounts, restricted egress, baseline application allow-listing, and configuration hardening aligned to standards) | Operations Lead | Enterprise | 40h | — |
| Centralise and normalise audit evidence for allowed/blocked attempts (log schema, correlation keys, retention alignment, and SIEM ingestion/alerting for policy violations) | Compliance Manager | Enterprise | 32h | £6,000 |
| Produce enforcement design documentation and change-control artefacts (policy rationale, evaluation logic, evidence locations, and traceability to approved change records) | Project Manager | Enterprise | 20h | — |

| Total Estimated Effort | 252h | Total Estimated Cost | £6,000 |

###### Actions Required for Compliance

- [ ] Create and get approval for an inventory of confined virtual machines (unique virtual machine IDs/names) that are allowed to run mobile code.
- [ ] Create an approved list of mobile code that can run, using cryptographic identity (for example, signed artefact identifiers or hashes), and record the person who signed it and the version.
- [ ] Set the orchestration or hypervisor rules so that the target virtual machine must be marked with `confined=true` (or an equivalent label) before any execution is allowed.
- [ ] Set “deny by default” execution rules so mobile code can run only when **both** the virtual machine and the mobile code are listed in their respective approved (allow) lists.
- [ ] Apply least-privilege access controls to each confined virtual machine (VM), and limit outbound network connections (egress) to what is appropriate for your environment.
- [ ] Integrate orchestration and the hypervisor, and add runtime logging to the security information and event management (SIEM) system. Include fields for the mobile code identifier, the virtual machine (VM) identifier, and whether the outcome was allowed or blocked.
- [ ] Document how enforcement is designed, and keep version-controlled records of changes when updating the list of confined virtual machines and the mobile code allow-list.


---

### SC-20 — Secure Name/Address Resolution Service (Authoritative Source) (Control)

This requirement ensures that when someone checks your organisation’s website or service address, they receive the correct information and also evidence that it genuinely came from your organisation and was not altered while being sent. Without this, attackers could redirect customers or staff to fake websites by changing the address information, or make it harder for partners to trust that your published details are genuine.

To meet this, your official name-and-address service must, every time it responds to an external request, include clear cryptographic proof showing both where the information originated and that it has not been changed during transmission. If your naming system is split across parent and child domains, you must also provide a way for outsiders to check the security status of the child domains and confirm the complete chain of trust from the parent to the child.

You should document how this is done, configure it correctly, keep records showing it is working as intended, and assign clear responsibility to the people who manage and oversee the service.

##### Enable DNSSEC on authoritative DNS with validated delegation chain

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Create authoritative DNS zone inventory and scope (externally reachable zones, including vendor/cloud-managed) with ownership mapping and signing readiness assessment | DNS/Network Engineering Lead | Enterprise | 24h | — |
| Design DNSSEC signing model (KSK/ZSK separation, algorithms, NSEC/NSEC3 choice, key storage approach, rollover strategy) and produce audit-ready design documentation | System Design Authority | Enterprise | 32h | — |
| Implement DNSSEC signing for all in-scope authoritative zones (configure signing, ensure RRSIG coverage for returned RRsets, validate zone signing status in each environment) | Infrastructure Lead | Enterprise | 56h | — |
| Implement delegation security: ensure parent DS records match each child DNSKEY set; coordinate with parent zone operators (internal or external) and document DS publication workflow | DNS/Network Engineering Lead | Enterprise | 40h | — |
| Build automated key lifecycle and safe rollover controls (policy-driven automation, monitoring for expiry/mis-match, staged rollovers, rollback plan) | DevOps Lead | Enterprise | 48h | £6,000 |
| Establish external validation testing and continuous checks (external resolvers/vantage points, representative record sets, delegated chain-of-trust verification, alerting on validation failures) | Security Engineer | Enterprise | 40h | £3,000 |
| Produce runbooks and evidence pack for audit (change procedures, roles/responsibilities, screenshots/logs from external validation, key rollover evidence, configuration baselines) | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 304h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] List all externally accessible authoritative Domain Name System (DNS) zones and identify which ones are responsible for public host and service names.
- [ ] Turn on Domain Name System Security Extensions (DNSSEC) signing for each authoritative zone, so that authoritative resource records (RRsets) are returned with the required digital signature information.
- [ ] Set up and check parent-to-child delegation security by publishing DS records that match each child zone’s DNSKEY set that is signed using DNS Security Extensions (DNSSEC).
- [ ] Set up automated key signing key (KSK) and zone signing key (ZSK) lifecycle management, with documented safe key rollover procedures, and ensure separation of duties.
- [ ] Run ongoing external Domain Name System Security Extensions (DNSSEC) checks on representative records and delegated zones, and record the results as evidence.
- [ ] Create and keep up to date DNS security (DNSSEC) step-by-step guides, define who is responsible for what, and document the approval and change process for updating signing and delegation information.


---

#### SC-20.2 — Data Origin and Integrity (Enhancement)

This requirement is about ensuring that when your systems look up internal names and addresses, they can show where the information came from and that it was not altered while being transferred or used. Without this, attackers or mistakes could provide your systems with incorrect location details, which could cause staff and services to connect to the wrong places, leak information, or disrupt operations.

To meet this expectation, the organisation must keep clear, easy-to-check records showing that internal lookups use a trustworthy source and include safeguards that protect the information from being changed. It should:

- document the approach in its security policy and step-by-step procedures for secure internal name and address resolution  
- keep system design and configuration records describing the protections that are actually in place  
- include these measures in the system security plan  
- retain audit records that show the protections were applied

##### DNSSEC-signed internal resolution with resolver integrity evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Design authoritative internal DNS architecture (zone ownership, delegation model, record inventory, signing scope, environment separation for prod/test/DR) | System Design Authority | Enterprise | 24h | — |
| Implement DNSSEC signing for internal authoritative zones (enable signing, KSK/ZSK strategy, key generation, signing policy, staged rollout to non-prod then prod) | Security Engineer | Enterprise | 40h | £6,000 |
| Standardise controlled recursive resolver configuration (DNSSEC validation required; validation failure handling; logging of validation state; resolver hardening and rate limiting) | Platform Engineer | Enterprise | 32h | £4,000 |
| Enforce resolver usage for internal clients (DHCP/DNS baselines, egress controls to prevent bypass, endpoint management configuration, verification testing) | Infrastructure Lead | Enterprise | 28h | £3,000 |
| Configure and retain audit/evidence logs on authoritative and recursive components (query identity where appropriate, authoritative server/zone, validation outcome, timestamps; retention and access controls) | Operations Lead | Enterprise | 24h | £2,500 |
| Produce assessor-ready evidence pack and operating procedures (design/config records, trust anchor/key management procedures, rotation and incident handling runbooks, failure mode documentation) | Compliance Manager | Enterprise | 30h | — |
| Integrate artefacts into System Security Plan (SSP) and version-controlled change management workflow (review gates, evidence mapping to SC-20(2), periodic review schedule) | Project Manager | Enterprise | 16h | — |

| Total Estimated Effort | 214h |  |
|---|---:|---:|
| Total Estimated Cost |  | £15,500 |

###### Actions Required for Compliance

- [ ] Create official internal Domain Name System (DNS) zones for all internal name and address lookups used by the system.
- [ ] Turn on Domain Name System Security Extensions (DNSSEC) signing for the authoritative zones, and document the key lifecycle and rotation steps for the key-signing key (KSK) and zone-signing key (ZSK).
- [ ] Set up internal recursive Domain Name System (DNS) servers to require Domain Name System Security Extensions (DNSSEC) validation, and to record whether each DNS query passed or failed validation.
- [ ] Require clients to use the approved name resolution service (using DHCP and DNS baseline settings and network and outbound traffic controls) to prevent them from bypassing the controlled resolvers.
- [ ] Turn on logging for DNS query and response activity, and for validation checks, on both recursive and authoritative DNS servers, and keep those logs for audit purposes.
- [ ] Create documentation that assessors can review, covering the system design, how trust anchors are managed, possible failure scenarios, and how incidents are handled
- [ ] Update the system security plan to include references to the Domain Name System Security Extensions (DNSSEC) and resolver integrity protections, and to the locations where evidence is stored.


---

### SC-21 — Secure Name/Address Resolution Service (Recursive or Caching Resolver) (Control)

This requirement is about ensuring that when your systems look up names and addresses (for example, to decide where to send data), they only trust results that genuinely came from approved, official sources and that the information was not altered while it was being sent. Without this, attackers could redirect your systems to the wrong destinations or change the information, causing staff and services to connect to fraudulent locations. This could lead to fraud, disruption, or loss of data.

To meet this expectation, the organisation must clearly state which sources are considered authoritative, ensure the service checks that each received result truly came from those sources and has not been changed, and only then use, store, or share the result.

If the organisation uses standard name look-up technology, it must use the built-in protection that verifies signed responses. If it does not, it must use a trusted validation service reached through an authenticated, approved connection.

The organisation must document the secure process, record the results in audit logs, assign responsibility for operating it, and include it in the system’s security plan.

##### Enable DNSSEC validation and fail-closed caching on resolvers

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Inventory and map all recursive/caching resolver paths used by the application environment (including forwarders, VPC/VNet DNS forwarders, and any OT/DMZ resolvers) and identify which are recursive/caching | Infrastructure Lead | Enterprise | 16h | — |
| Select and standardise resolver DNSSEC configuration approach per resolver platform (e.g., BIND/Unbound/Knot/Windows/managed DNS), including root trust anchor handling and chain-of-trust requirements | System Design Authority | Enterprise | 12h | — |
| Implement DNSSEC validation enablement on each recursive/caching resolver (configuration changes, trust anchor installation, and verification that validation is active) | Security Engineer | Enterprise | 24h | — |
| Configure fail-closed behaviour for validation failures (e.g., bogus/indeterminate handling to return no usable answer such as SERVFAIL and ensure clients do not receive unsigned/invalid data) | Security Engineer | Enterprise | 16h | — |
| Enforce caching policy for validated answers only (ensure bogus/failed/indeterminate results are not cached as valid; validate cache behaviour with controlled queries) | Platform Engineer | Enterprise | 16h | — |
| Ensure upstream validation cannot be bypassed (review/adjust forwarding rules; confirm upstream resolvers also validate DNSSEC or remove insecure forwarding paths) | Infrastructure Lead | Enterprise | 12h | — |
| Centralise audit evidence: export resolver configuration baselines and forward DNSSEC validation outcome logs (validated/bogus/failed) to SIEM with appropriate retention and alerting hooks | Compliance Manager | Enterprise | 20h | £3,000 |
| Execute controlled testing and evidence capture (valid DNSSEC domain, intentionally broken signature domain, negative tests, and change records; confirm fail-closed and non-caching) | Quality Assurance Lead | Enterprise | 18h | — |

Total Estimated Effort: **124h**  
Total Estimated Cost: **£3,000**

###### Actions Required for Compliance

- [ ] List all Domain Name System (DNS) resolvers and forwarders used by the application that use recursion or caching, and identify where the application depends on client DNS lookups.
- [ ] Enable Domain Name System Security Extensions (DNSSEC) validation on each recursive or caching resolver, and confirm that the root trust anchor and the chain-of-trust checking are working.
- [ ] Set DNSSEC (Domain Name System Security Extensions) to fail closed, so that if DNSSEC checks fail the system returns no usable answer (for example, by using “SERVFAIL” or treating the result as “bogus”), rather than returning invalid data.
- [ ] Check that the caching policy stores and serves only Domain Name System Security Extensions (DNSSEC)-validated responses, and that any responses with failed or incorrect validation are not saved and treated as valid.
- [ ] Check that any upstream forwarding route also verifies Domain Name System Security Extensions (DNSSEC) (or remove any insecure forwarding routes that could allow DNSSEC checks to be bypassed).
- [ ] Send the forward resolver Domain Name System Security Extensions (DNSSEC) validation results logs to the security information and event management (SIEM) system, and keep the configuration evidence for audit purposes.
- [ ] Run test cases using a domain that is signed with Domain Name System Security Extensions (DNSSEC) and an approved test zone with an invalid signature, to confirm that the system rejects the responses and does not store them in its cache.


---

### SC-22 — Architecture and Provisioning for Name/Address Resolution Service (Control)

This requirement is about making sure the organisation’s “phonebook” for finding website names and internet addresses stays reliable, and that different types of users are directed to the correct services.

If the service relies on a single point of failure, a website outage or network problem could prevent staff and customers from reaching the organisation’s online services. If internal and external access are mixed up, the wrong people could use the wrong systems, which could expose information or disrupt operations.

To meet this expectation, the organisation must run at least two official name/address servers: one primary and one secondary. These must be placed in different geographically separated network areas, not in the same building or network. The organisation must also separate responsibilities by setting up:
- internal-only servers that accept requests only from approved internal locations, and
- external-only servers that accept requests only from approved external sources, such as the internet,

with clear rules for who is allowed and technical controls that enforce those rules.

The organisation must document the design and procedures, keep configuration records and audit evidence, appoint named individuals responsible for managing it, and keep independent test proof that these arrangements work.

##### Dual-site authoritative DNS with enforced internal/external client roles

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authoritative DNS architecture per zone (primary/secondary roles, authoritative-only configuration, internal vs external role endpoints/views) | System Design Authority | Enterprise | 16h | — |
| Select and document geographically separated network placement (primary/secondary subnets, routing independence, failover considerations) | Infrastructure Lead | Enterprise | 12h | — |
| Provision/implement DNS server instances for each authoritative zone (ns1 primary + ns2 secondary) with recursion disabled and authoritative-only behaviour validated | Platform Engineer | Enterprise | 24h | £6,000 |
| Implement network enforcement for role separation (firewall/security groups/ACLs allowing UDP/TCP 53 only from internal allow-lists to internal-role servers, and only from external allow-lists to external-role servers) | Network Security Engineer | Enterprise | 20h | £3,000 |
| Implement DNS-aware protections and hardening (rate limiting/edge protections where available; ensure no recursion/caching-only misconfiguration; baseline secure configs) | Security Engineer | Enterprise | 16h | £2,500 |
| Create version-controlled infrastructure-as-code and change-controlled deployment pipeline for DNS + network rules (peer review, approvals, rollback plan) | DevOps Lead | Enterprise | 20h | £4,000 |
| Enable audit logging and evidence generation (DNS query/access logs, allow/deny outcomes, SIEM integration, retention alignment) | Compliance Manager | Enterprise | 14h | £1,500 |
| Execute validation and periodic test evidence (internal/external test harness, negative tests for unauthorised sources, documented results and remediation loop) | Quality Assurance Lead | Enterprise | 18h | — |

**Total Estimated Effort:** 140h  
**Total Estimated Cost:** £17,000

###### Actions Required for Compliance

- [ ] For each DNS zone, set up two authoritative DNS servers, with one clearly acting as the primary and the other acting as the secondary.
- [ ] Put the primary and secondary Domain Name System (DNS) servers in separate facilities and on different network subnetworks.
- [ ] Define internal and external client allow-lists (IP address ranges and named IP addresses) for each Domain Name System (DNS) role.
- [ ] Set firewall, security group, and access control list (ACL) rules to restrict Domain Name System (DNS) traffic on User Datagram Protocol (UDP) and Transmission Control Protocol (TCP) port 53 to the internal-role and external-role DNS servers only.
- [ ] Turn off recursion on authoritative Domain Name System (DNS) servers and check that they only return authoritative answers.
- [ ] Enable and keep DNS (Domain Name System) access and query logging so you can provide audit evidence that role separation is being enforced.
- [ ] Run and record regular validation tests from both internal and external test networks to confirm the system allows and blocks access correctly.


---

### SC-23 — Session Authenticity (Control)

This requirement is about making sure that when two systems communicate, they can reliably trust who they are talking to, and that the information exchanged during that conversation is genuine. Without this, an attacker could secretly intercept the connection, take over an existing conversation, or send false messages so that actions are carried out under the wrong identity or based on altered information.

To meet this expectation, the organisation must set clear rules for how it will protect the authenticity of ongoing communication sessions, and put practical procedures in place to do so. This includes how it prevents middle-person interference, session takeovers, and the insertion of false information. It must document how the system is designed to achieve this, configure the systems so the protections are enabled where needed, and keep records of the relevant settings.

Finally, it must keep audit records showing when session authenticity protections were applied or failed, assign responsibility to named roles, and be able to demonstrate with evidence that the protections work as intended.

##### Enforce mutual TLS with strict identity checks for session authenticity

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define session authenticity requirements by integration type (TLS 1.2+/1.3, allowed cipher suites, mTLS requirement, SAN/identity rules, revocation/expiry handling, and rejection criteria) | Security Architect | Enterprise | 24h | — |
| Select and standardise the enforcement mechanism for mTLS at the session layer (API gateway/reverse proxy/service mesh/application library) and produce reference configuration templates | System Design Authority | Enterprise | 32h | — |
| Implement mTLS enforcement for all in-scope service endpoints and remove/disable any unauthenticated TLS pathways for those routes (including test/prod parity) | Infrastructure Lead | Department | 40h | — |
| Implement strict certificate identity validation on both sides (trust-store enforcement, SAN/hostname matching to expected peer identity, and defined behaviour for expiry/revocation failures) | Security Engineer | Department | 40h | — |
| Bind authenticated TLS peer identity into application/session context and enforce authorisation/session correlation based on that identity (including propagation mechanism and application-side checks) | Software Lead | Business Unit | 32h | — |
| Implement audit-ready logging of TLS handshake outcomes (success/failure, peer identity attempt, endpoint, timestamp, and failure reason) and integrate with SIEM/observability dashboards | Operations Lead | Enterprise | 24h | — |
| Operationalise certificate lifecycle (automated issuance/rotation, onboarding/offboarding workflows, emergency rollback procedure, and change-management runbooks) | Platform Engineer | Enterprise | 32h | £8,000 |
| Execute end-to-end validation and compliance evidence pack (test plans, negative tests for MITM/identity mismatch, certificate rotation tests, and sign-off against acceptance criteria) | Compliance Manager | Enterprise | 24h | — |

Total Estimated Effort: **268h**  
Total Estimated Cost: **£8,000**

###### Actions Required for Compliance

- [ ] Create an authenticity requirement matrix for each integration, requiring mutual Transport Layer Security (mTLS) and strict certificate checks.
- [ ] Set up API gateways, reverse proxies, or a service mesh so that every defined system-to-system session path requires client certificates.
- [ ] Set up certificate checks that only trust approved trust stores and confirm that the certificate’s subject alternative name (SAN) matches the expected identity of the other party.
- [ ] Use authenticated Transport Layer Security (TLS) peer identity as part of the application or user session details, and use it to make access decisions (authorisation) and to link related session activity (session correlation).
- [ ] Set up and centralise logging of whether each Transport Layer Security (TLS) connection handshake succeeds or fails, including the other party’s identity, the endpoint, the time, and the reason for any failure, in the security information and event management (SIEM) system.
- [ ] Automate the issuing, renewing (rotation), starting (onboarding), and stopping (offboarding) of digital certificates, with clear emergency rollback procedures.


---

#### SC-23.1 — Invalidate Session Identifiers at Logout (Enhancement)

This requirement ensures that when a person logs out, the system immediately “closes the door” for that specific login session, so it cannot be used again. If this is not done, an attacker who somehow gets hold of a valid session identifier could continue using it to access accounts or systems even after the person has left, potentially bypassing normal sign-in checks.

To meet this expectation, the organisation must make sure the session identifier is made unusable both when a user logs out and when a session ends for any other reason. The system must also reject any later attempt to use an identifier that has been cancelled.

The organisation should document how sessions are ended, set clear procedures for keeping sessions genuine, and keep evidence in audit records showing that sessions are cancelled at logout and at other termination events. This approach must be included in the system’s security plan.

Clear responsibility must be assigned to the relevant administrators. The system must be configured and supported using appropriate technical controls, and the configuration details must be kept up to date.

##### Enforce session revocation on logout and termination via IdP + app checks

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| IdP session/logout configuration: enable authoritative logout and forced sign-out handling; map non-logout termination triggers (admin disable, credential reset, risk sign-out) to immediate session revocation | Cyber Security Lead | Enterprise | 24h | — |
| Implement/enable logout propagation mechanism (front-channel/back-channel where supported) and validate that logout events terminate the correct session identifiers across relying parties | System Design Authority | Enterprise | 16h | — |
| Relying-party enforcement design: define session/token validation strategy (per-request validation vs short interval), including refresh-token rotation policy and rejection behaviour for invalidated identifiers | Security Engineer | Enterprise | 20h | — |
| Application and gateway/API changes: enforce session/token validation on every request (or defined interval), ensure invalidated identifiers are rejected with consistent error handling, and add refresh-token rotation support where applicable | Platform Engineer | Department | 56h | — |
| Audit logging and correlation: configure IdP event logging for logout/forced sign-out/revocation and application/gateway denial logging; implement correlation identifiers and SIEM rules to evidence “termination then rejection” | Security Engineer | Enterprise | 24h | £6,000 |
| Test and evidence pack: create test cases for logout and each non-logout termination scenario; run integration tests, capture evidence screenshots/log extracts, and produce an audit-ready compliance report | Quality Assurance Lead | Department | 24h | — |
| Update system security documentation/runbooks: document “session termination” definitions, event-to-revocation mapping, relying-party enforcement mechanism, operational troubleshooting steps, and monitoring expectations | Compliance Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 176h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Configure the organisation’s identity provider (IdP) to end or cancel user sessions when users log out, and also when sessions are forcibly ended (including forced sign-out and non-logout termination events).
- [ ] Enable logout “propagation” (using front-channel and back-channel methods where supported) so relying parties receive the logout/termination signal.
- [ ] Set up relying-party enforcement so the application or gateway checks that the user’s session or token is still valid, and blocks any session identifiers that have been cancelled or invalidated.
- [ ] Where applicable, enable refresh-token rotation and stop accepting previously issued refresh or session identifiers after they have been revoked.
- [ ] Enable and keep audit logs for identity provider (IdP) logouts and forced sign-outs, and for when an application or gateway rejects attempts to reuse access after termination.
- [ ] Update the system security plan and the step-by-step operating guides to record how session-ending events are matched, and to describe the enforcement method used to stop sessions being reused.


---

#### SC-23.3 — Unique System-generated Session Identifiers (Enhancement)

This requirement is about ensuring that every time someone starts a session with your system, the system creates a new, hard-to-guess session code that only your system can generate. If session codes could be predicted, reused, or influenced by a user, an attacker could copy an old valid code and pretend to be an authorised user, potentially gaining access without logging in again.

To meet this requirement, your organisation must generate a new session identifier for every session using strong, system-generated randomness, providing at least 128 bits of unpredictability for each identifier—rather than simple patterns or values that could be guessed. The system must only accept session identifiers that it generated itself, and it must reject any codes that were not created by the system or that were reused from earlier sessions, so that users are required to log in again or access is denied as appropriate.

##### CSPRNG session IDs with server-side validation (≥128-bit entropy)

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define session ID requirements and design: ≥128-bit entropy generation approach, encoding format, cookie/header transport, TTL and revocation semantics, and server-side validation rules | System Design Authority | Enterprise | 16h | — |
| Implement CSPRNG-based session ID generation in the application (per-session start, new ID each time, entropy-preserving encoding, no downgrade/weak RNG fallbacks) | Software Lead | Business Unit | 24h | — |
| Implement server-side session store integration (Redis/distributed cache or DB): keying by session ID, explicit TTL, logout/revocation handling, and resilience for lookup failures | Platform Engineer | Business Unit | 32h | £3,000 |
| Implement request-time validation middleware/filter: accept only session IDs present in active server-side state; deny/force re-auth on missing/expired/revoked/not-found IDs; ensure consistent behaviour across web/API endpoints | Security Engineer | Department | 24h | — |
| Add audit evidence and operational logging: session creation (CSPRNG used + documented entropy basis), validation outcomes (valid/invalid/not found), and revocation events; integrate with SIEM and ensure log retention alignment | Compliance Manager | Enterprise | 16h | — |
| Build automated tests and security validation: unit/integration tests for generation uniqueness, TTL expiry, replay rejection, and negative cases; add load/performance checks for session lookup | Quality Assurance Lead | Department | 24h | — |
| Deployment hardening and configuration: secure session cookie attributes, environment-specific secrets management, session store clustering/HA configuration, and runbook updates for incident/rollback | Operations Lead | Business Unit | 16h | £2,000 |
| Total Estimated Effort |  |  | **172h** |  |
| Total Estimated Cost |  |  |  | **£5,000** |

###### Actions Required for Compliance

- [ ] Generate a unique session identifier for each session using the platform’s cryptographically secure random number generator (CSPRNG), and document that the randomness provides at least 128 bits of entropy, as required by sc-23.03_odp.
- [ ] Set up a server-side session storage system (for example, Redis or a database) that uses the generated session identifier as the key, with a clearly defined time limit (time-to-live), and that immediately invalidates the session when the user logs out.
- [ ] Check the session identifier provided with each request against the server’s stored sessions. If it is missing or has expired, deny the request and require the user to sign in again.
- [ ] Record audit logs for when sessions are created, when session checks succeed or fail (valid or invalid), and when sessions are revoked.
- [ ] Create automated tests that try using old session identifiers after they have expired and after logout, and confirm that the system rejects them.


---

#### SC-23.5 — Allowed Certificate Authorities (Enhancement)

This requirement is about making sure your web connections only trust certificates from a known, approved set of certificate providers. If certificates from unknown or unapproved providers were allowed, an attacker could potentially make your systems treat a fake website as genuine. This could result in stolen information, fraudulent logins, or data being sent to the wrong place.

To meet this expectation, the organisation must keep an up-to-date, documented list of which certificate providers are allowed to verify the certificates used to set up secure web sessions. That list must include only the Department of Defense public key infrastructure (DoD PKI) provided by the Defense Information Systems Agency (DISA), and any other commercial providers that have been explicitly approved for Transport Layer Security (TLS).

Any systems that create or check these secure web sessions must be configured to accept only the certificate providers on the approved list. The organisation must also keep audit records showing evidence that these checks are carried out. Finally, the organisation must document how this is done in its procedures, system design, and security planning, and assign clear responsibility for maintaining the approved list and managing any changes.

##### Enforce TLS CA allowlist for protected sessions (DoD + approved CAs)

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the “Allowed TLS CAs” register schema and mapping rules (fingerprint vs issuer DN/CA name), including how sc-23.05_odp is represented and versioned | System Design Authority | Enterprise | 16h | — |
| Populate the initial Allowed TLS CAs register from sc-23.05_odp (DoD PKI (DISA) + explicitly approved commercial CAs) and establish validation checks (uniqueness, format, expiry handling) | Cyber Security Lead | Enterprise | 24h | — |
| Implement trust-bundle generation pipeline (endpoint-specific bundles derived only from the Allowed TLS CAs register; no system trust store append) | Platform Engineer | Enterprise | 40h | — |
| Configure TLS termination points to use the generated trust bundles for protected sessions only (web servers, API gateways, reverse proxies, load balancers), including separate handling for non-protected traffic where required | Infrastructure Lead | Business Unit | 56h | — |
| Enforce TLS handshake verification behaviour (fail closed) and ensure protected sessions cannot be established when the presented chain does not chain to an allowlisted CA | Security Engineer | Department | 32h | — |
| Implement auditable logging and SIEM forwarding for each protected session TLS verification attempt (success/failure, CA/issuer used, failure reason) and validate log completeness | Operations Lead | Enterprise | 24h | — |
| Establish change management controls for Allowed TLS CAs updates (CAB workflow, approvals, deployment through release pipeline with audit trail) | Compliance Manager | Enterprise | 24h | — |
| Run periodic configuration compliance checks and drift alerts (bundle vs register reconciliation per endpoint, reporting, and remediation workflow) | DevOps Lead | Enterprise | 24h | £6,000 |
|  |  |  |  |  |
| **Total Estimated Effort** |  |  | **270h** |  |
| **Total Estimated Cost** |  |  |  | **£6,000** |

###### Actions Required for Compliance

- [ ] Create and keep an “Allowed TLS Certificate Authorities (CAs)” register that includes only the Department of Defense public key infrastructure (DoD PKI) from the Defense Information Systems Agency (DISA) and only commercial certificate authorities (CAs) that have been explicitly approved, in line with sc-23.05_odp.
- [ ] Convert each permitted certificate authority (CA) into identifiers that can be checked automatically by systems (for example, certificate fingerprints and/or the issuer distinguished name (DN) or CA name), and keep the register versioned.
- [ ] Create a trusted certificate bundle for each Transport Layer Security (TLS) connection endpoint using only the certificates from the approved register. Then configure each TLS setup to trust only those bundles.
- [ ] Set up Transport Layer Security (TLS) checks so that connection handshakes fail if the certificate chain does not end with an approved certificate authority (CA).
- [ ] Set up and centralise logging of the results of Transport Layer Security (TLS) checks, including the certificate issuer (certificate authority (CA)) or the reason for failure, and send this information to security information and event management (SIEM) for secure retention.
- [ ] Put change controls in place before updating the allowed certificate authority (CA) register, and deploy any trust bundle updates through the normal release process.
- [ ] Carry out regular compliance checks to spot any changes in the trusted certificate list (“trust store”) and raise alerts if it no longer matches the approved certificate authority (CA) register.


---

### SC-24 — Fail in Known State (Control)

This requirement is about ensuring that if a system has a serious failure, it does not move into a chaotic or unsafe state. Instead, it must automatically switch to a known, safer, reduced operating mode.

Specifically, if there is power loss, a software crash, a hardware fault, a network outage, a storage input/output failure, or a watchdog reset, the system must:
- pause non-essential services,
- keep critical functions running,
- allow access only for authorised maintenance accounts.

At the same time, it must preserve:
- the current configuration,
- information about any ongoing user sessions,
- queued transactions,
- the last known sensor or telemetry readings,
- system logs up to the point the failure occurred.

This matters because, without this approach, important information could be lost or damaged, service disruption could last longer than necessary, and unauthorised access could become possible during recovery.

To meet this expectation, the organisation must define and document the failure events that trigger the safe mode and the behaviour the system must follow in safe mode. It must ensure the system is designed to do this automatically, keep the supporting procedures and records, and assign clear responsibility for implementing and maintaining it.

##### Automated safe-mode on defined failures with state preservation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define organisation failure-type mapping to concrete detector signals and safe-mode trigger reasons (per component), including agreed time window for safe-mode entry | System Design Authority | Enterprise | 24h | — |
| Implement failure detectors and unified “enter safe mode” internal event interface (crash markers, health events, connectivity/storage thresholds, watchdog markers) | Software Lead | Department | 56h | — |
| Build Safe Mode Controller enforcing known safe degraded mode: pause non-essential services, hold critical functions, and switch to maintenance-only access enforcement | Platform Engineer | Department | 72h | — |
| Implement state preservation package for {{ sc-24_odp.03 }}: durable config snapshot, resumable session/transaction handling (idempotent outbox/inbox), telemetry snapshot, and crash-safe log flush | Security Engineer | Department | 96h | — |
| Ensure deterministic safe-mode entry on restart: boot-time unclean shutdown/crash/watchdog checks, automatic re-entry, and state restoration flow | Operations Lead | Business Unit | 48h | — |
| Add auditable evidence: structured audit events for trigger reason, timestamp, affected components, persisted state items, and maintenance-only enforcement activation; ensure inclusion of logs up to failure point | Compliance Manager | Enterprise | 40h | — |
| End-to-end testing and validation: failure injection per failure type, timing verification, restart scenarios, access-denial tests, and evidence review for audit readiness | Quality Assurance Lead | Department | 64h | £12,000 |
| Pilot rollout to one production-like environment with runbooks and operator-approved recovery workflow (including rollback/disable criteria) | Project Manager | Business Unit | 32h | £3,000 |

**Total Estimated Effort:** 432h  
**Total Estimated Cost:** £15,000

###### Actions Required for Compliance

- [ ] For each failure type listed in **sc-24_odp.01**, identify the specific detection signals for every affected component.
- [ ] Implement a “Safe Mode” controller that enforces **sc-24_odp.02** by pausing non-essential services, keeping critical functions running, and restricting access to maintenance use only.
- [ ] Before or when entering safe mode, store `sc-24_odp.03` items in long-term (durable) storage, including configuration, session state, queued transactions, a telemetry snapshot, and crash-safe logs.
- [ ] Add checks during system start-up to automatically return to safe mode after a power cut, software crash, or a watchdog reset.
- [ ] Set the system to allow only maintenance access while in safe mode, and check that every route for non-maintenance access is blocked.
- [ ] Create automated tests that simulate each **SC-24 ODP.01** failure and confirm that the system’s state is preserved and that audit evidence is recorded.


---

### SC-25 — Thin Nodes (Control)

This requirement is about keeping certain computers as simple as possible, so they do less and store less information than they need to. This matters because if a thin client computer used for work or administration is compromised, attackers have fewer features they can misuse and less data they can steal or misuse.

To meet this expectation, the organisation must use thin client workstations, diskless virtual desktops, and jump hosts for their intended purposes. Each device must be set up to run only the minimum functions needed and to store only the minimum information needed—for example, avoiding persistent local storage where diskless operation is used.

The organisation must also:
- write and keep clear instructions for how these devices are used
- maintain up-to-date design and configuration records showing how the “minimal” approach is achieved
- include these devices in its overall security plan
- assign named responsibilities for this work
- keep audit records that show the settings are being followed

##### Thin node baselines for minimal functionality and diskless storage

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| SC-25 baseline requirements workshop and scope definition for node types (Thin Client, Diskless VDI, Jump Host), including minimal-function/minimal-storage interpretation and mapping to existing standards | Compliance Manager | Enterprise | 8h | — |
| Authoritative baseline v1.0: Thin Client (allowed/prohibited software/services, local persistence restrictions, approved storage/redirection behaviour, admin capability limits) | Security Engineer | Enterprise | 24h | — |
| Authoritative baseline v1.0: Diskless VDI (non-persistent pool/session configuration, session teardown wiping, approved storage redirection, required agent/service allow-list) | System Design Authority | Enterprise | 28h | — |
| Authoritative baseline v1.0: Jump Host (required tooling allow-list, prohibited agents/features, controlled session/session-end cleanup, minimal local data persistence) | Security Engineer | Enterprise | 20h | — |
| Baseline enforcement implementation in endpoint/virtualisation management (configuration profiles, policies, and automated checks) for all three node types, including drift detection and remediation workflows | Platform Engineer | Enterprise | 56h | £12,000 |
| Operationalise “minimal use” procedures (role-based admin/user guidance, permitted storage rules, reset/cleanup expectations, escalation/change routes for deviations) and publish to the service catalogue/knowledge base | Service Delivery Manager | Enterprise | 16h | — |
| Audit-ready evidence pack and reporting automation (baseline versioning, change records, compliance reports, drift/enforcement logs, and deployed fleet evidence by node type) | Compliance Manager | Enterprise | 20h | £6,000 |

**Total Estimated Effort:** 172h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Create three baseline profiles—**Thin Client**, **diskless virtual desktop infrastructure (VDI)**, and **jump host**—that list which functions and services are allowed, and clearly state which software and features are explicitly prohibited.
- [ ] Set up virtual desktop infrastructure (VDI) so it does not store data between sessions, and ensure only approved user profiles and data are redirected. When a session ends, fully wipe the session data.
- [ ] Apply endpoint configuration profiles to thin clients and jump hosts to turn off or remove non-essential services, and to ensure any local data is controlled and cleared.
- [ ] Publish role-based thin-node usage procedures covering what storage is allowed, what reset and cleanup you should expect, and which actions are not permitted (for example, installing software locally).
- [ ] Set up ongoing compliance checks and detect changes (drift) in the endpoint and virtual desktop infrastructure (VDI) management platform, then fix any areas that do not meet the baseline requirements.
- [ ] Keep audit evidence: the baseline version history, compliance reports, and enforcement or drift logs for each type of node.


---

### SC-26 — Decoys (Control)

This requirement is about setting up carefully managed “trap” areas inside your systems. These areas are made to look tempting to attackers, so you can spot them early, keep them occupied away from real services, and learn from what they try to do. Without this, attackers may test and break into your genuine business systems without being noticed, or their harmful actions could spread and cause real disruption, data loss, or financial harm.

To meet this expectation, the organisation must deploy decoy components that are deliberately configured to attract malicious attention, and use them to detect, redirect, and analyse hostile behaviour. The decoys must be kept appropriately separated from operational systems, so anything an attacker does in the decoy cannot spread into systems that support your mission and day-to-day work.

The organisation must also document how the decoys are used and designed, record relevant activity for investigation, include decoy use in its security planning, assign clear responsibilities, involve system developers as needed, implement the supporting mechanisms, and consult the Office of the General Counsel before deploying decoys when the specific deployment requires it.

##### Isolated deception honeypots with SIEM evidence and OGC workflow

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define decoy scope, placement model, and network zoning (VLAN/subnet/VPC), including threat assumptions and non-propagation requirements | System Design Authority | Enterprise | 24h | — |
| Design and implement micro-segmentation + firewall/routing isolation for decoy zones (allow-list egress to SIEM/telemetry, NTP, and controlled management; deny-by-default to production/OT) | Infrastructure Lead | Enterprise | 40h | £6,000 |
| Deploy deception honeypot services/endpoints in segregated zones with realistic protocol emulation while ensuring no proxying to production and no credential/data pathways | Security Engineer | Department | 32h | £18,000 |
| Configure decoy telemetry pipelines (agent/log sources, session identifiers, interaction metadata, artefact capture where permitted) and integrate into enterprise SIEM with alert enrichment and correlation rules | Cyber Security Lead | Enterprise | 40h | £12,000 |
| Create audit-ready evidence model and retention mapping (what is logged, how decoy identity is tagged, retention periods, access controls, and evidence export approach) | Compliance Manager | Enterprise | 16h | — |
| Develop operational runbooks and governance artefacts (deployment, monitoring, escalation, safe shutdown/decommission, vulnerability/patch approach, and system security plan updates with named responsibilities) | Project Manager | Enterprise | 24h | — |
| Establish OGC consultation gate workflow and complete legal review for any legally sensitive decoy behaviours (e.g., credential capture/simulated user interactions); record constraints in decoy design documentation | Data Protection Officer | Enterprise | 20h | — |

**Total Estimated Effort:** 216h  
**Total Estimated Cost:** £36,000

###### Actions Required for Compliance

- [ ] Choose decoy targets and set where the decoys will be placed inside dedicated, separated network areas, with no normal business network routing.
- [ ] Set up and configure decoy services that imitate real attack points, while blocking any attempts to use them as a route to production systems.
- [ ] Use micro-segmentation and approved “allow-lists” for incoming and outgoing connections, so the decoys can only send data to approved telemetry and management destinations.
- [ ] Connect decoy telemetry to the organisation’s security information and event management (SIEM) system, and set up alerts that are specific to each decoy, including the decoy identifier and session details.
- [ ] Create decoy runbooks for deployment, monitoring, escalation, and safe shutdown or decommissioning, and update the system security plan.
- [ ] Set up and run an Office of Government Commerce (OGC) consultation decision process for legally sensitive use of decoys, and record the outcomes.


---

### SC-27 — Platform-independent Applications (Control)

This requirement is about making sure your organisation’s key software can run on more than one type of computer, even if one platform is disrupted. It does this by packaging the software in a portable way. Without this, critical services could become unavailable if a particular operating system or hardware type is attacked, fails, or needs replacing, because the software would be difficult to move or rebuild quickly.

To meet this expectation, the organisation must include containerised, platform-independent applications (for example, microservices managed by Kubernetes) that are provided as signed software packages, along with portable deployment instructions. The organisation must also keep an up-to-date list of exactly which applications are included.

The organisation must document how these applications are handled in its security policy and procedures, describe them in system design and configuration records, include them in the system security plan, and keep audit records showing they are being used and managed as intended.

##### Signed, portable container apps with an auditable platform-independence catalogue

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define sc-27_odp in-scope criteria and ownership model; produce a catalogue schema (fields, validation rules, versioning approach, and evidence mapping) | Compliance Manager | Enterprise | 16h | — |
| Build and publish the authoritative platform-independence catalogue (initial population from known in-scope apps) including canonical image references, signing verification method, supported platforms/architectures, and canonical portable manifest source locations/versions | Project Manager | Enterprise | 40h | — |
| Implement signed-image pipeline controls: generate immutable image digests, sign images at build/release, and publish signing metadata required for verification | DevOps Lead | Enterprise | 56h | £12,000 |
| Implement deployment-time signature verification and enforcement (e.g., admission/deployment gate that blocks unsigned/unapproved digests across environments/platforms) | Security Engineer | Enterprise | 48h | £6,000 |
| Standardise portable manifest generation and storage: implement canonical manifest build (Helm/Kustomize/render outputs), enforce “no hand-edit” policy, and store portable artefacts with immutable version identifiers | Platform Engineer | Enterprise | 40h | — |
| Implement binding between catalogue entries and deployable artefacts (manifest version ↔ approved image digest set) and ensure reconciliation evidence is produced per release | Operations Lead | Enterprise | 32h | — |
| Establish auditable evidence pack and retention workflow (catalogue membership snapshots, signature verification logs, manifest-to-deployment mapping, and reconciliation records) plus runbooks for audit readiness | Compliance Manager | Enterprise | 24h | — |
| Update system security plan and system design/configuration records to reference the catalogue and describe portability/reconstitution approach; complete compliance validation against sc-27_odp acceptance criteria | Data Protection Officer | Enterprise | 24h | — |

**Total Estimated Effort:** 280h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Define and publish the in-scope, platform-independent application catalogue entries in line with **SC-27 ODP**, including: the **service name**, the **supported platforms and computer architectures**, the **standard (canonical) location for the application images**, and the **portable source for the deployment manifest**.
- [ ] Digitally sign every in-scope application image using cryptography, and during deployment verify the signature by using unchangeable image identifiers (immutable image digests).
- [ ] Create a portable “manifest” standard (for example, Kubernetes resource manifests, Helm charts, or Kustomize outputs). Ensure that all manifests are generated from a single, agreed “source of truth” rather than being manually edited inside the cluster.
- [ ] Set up deployment gates (admission checks and continuous integration/continuous delivery (CI/CD) checks) to stop any deployment if either the software image is not signed and verified, or the software version is not the catalogue-approved artefact.
- [ ] Enable auditable evidence capture that links each catalogue entry to the signed image digest, then to the portable manifest version, and finally to the deployed environment or platform. Keep the related logs for as long as required by the organisation’s retention rules.
- [ ] Update the system security plan and the system design and configuration records to reference: the catalogue, the approach for enforcing signed files and manifests, and the process for moving and rebuilding the system on the supported platforms.


---

### SC-28 — Protection of Information at Rest (Control)

This expectation is about keeping confidential and secret information safe even when it is stored away, such as on hard drives, in databases, and in backup copies. If this is not done properly, unauthorised people could access sensitive details, or malicious software and insiders could quietly change stored information, including important system settings and authentication details. This could lead to fraud, service disruption, or loss of trust.

To meet this requirement, the organisation must first keep an up-to-date list of exactly which confidential and secret user and system information must be protected while stored. It must then have clear, documented procedures and system designs for protecting that information’s confidentiality and accuracy, and ensure the real systems are set up accordingly. This includes using approved safeguards such as encryption and measures that protect data integrity, and applying the same protections to backups. Where normal protection cannot be achieved, approved alternative measures must be used.

Finally, the organisation must be able to provide evidence that these protections are in place and working. This includes showing that integrity checks pass and that authorised backup restore testing succeeds.

##### Encrypt and integrity-protect confidential/secret at-rest data

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create authoritative at-rest scope mapping linking confidential/secret categories to concrete storage locations (volumes, databases, object/file shares, config repos, snapshots, replication targets, backup sets) | Data Protection Officer | Enterprise | 24h | — |
| Define and publish the “At-Rest Confidentiality & Integrity Standard” (encryption mechanisms, integrity mechanisms incl. WORM/immutability vs signing+verification, key management requirements, exception/compensating control process) | Compliance Manager | Enterprise | 32h | — |
| Implement encryption-at-rest enforcement across in-scope storage types (DB TDE/equivalent, encrypted object/file/block storage, encrypted backup repositories/streams; apply across prod/test/DR where applicable) | Infrastructure Lead | Enterprise | 64h | £18,000 |
| Implement integrity protection for in-scope datasets (enable WORM/immutability for backups/config artefacts where feasible; otherwise implement signing + scheduled hash/signature verification with alerting and remediation workflow) | Security Engineer | Enterprise | 56h | £12,000 |
| Harden key usage and access paths (least-privilege decrypt/encrypt roles for services, remove shared keys/accounts, enforce auditable key access via enterprise KMS/HSM; configure rotation policy alignment) | Cyber Security Lead | Enterprise | 40h | £6,000 |
| Produce audit-ready evidence pack (encryption status reports per storage type; immutability configuration evidence; integrity check job results + alert history; key access logs extracts; documented restore test evidence) | Compliance Manager | Enterprise | 32h | — |
| Execute at least one protected backup restore test and validate integrity expectations (restore from immutable/encrypted backups; verify integrity checks/signatures; record outcomes and lessons learned) | Service Delivery Manager | Enterprise | 24h | £2,500 |

**Total Estimated Effort:** 272h  
**Total Estimated Cost:** £38,500

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date, authoritative record showing which confidential or secret information stored while not in use is held in this application’s storage media, databases, and backup locations.
- [ ] Publish an approved “At-Rest Confidentiality and Integrity Standard” that sets out the encryption and data-integrity measures required for each storage type and each data category.
- [ ] Turn on encryption for data stored on disk by default for every mapped storage location, including the database (database transparent data encryption (TDE) or an equivalent), encrypted storage volumes/objects/files, and encrypted backups or snapshots.
- [ ] Enable integrity protection for mapped datasets. Where feasible, use write-once, read-many (WORM) storage or immutability for backups and configuration files. Otherwise, use digital signing and run scheduled integrity checks, with alerts if problems are detected.
- [ ] Enforce enterprise key management controls: allow decryption access only to the minimum necessary users (least-privilege); restrict key use to authorised roles and services; and keep audit logs of who accessed the keys.
- [ ] Collect audit evidence showing the encryption status, how immutability and integrity settings are configured, the results of integrity checks, and the outcome of backup restore verification.


---

#### SC-28.1 — Cryptographic Protection (Enhancement)

This requirement is about protecting sensitive information so that, even if someone gains access to your on-premises storage, they still cannot read it or make hidden changes to it. It protects Confidential and Secret information stored on your own servers, storage systems, and backup locations, including databases, file shares, backups, and records. Without this protection, unauthorised people could copy confidential files, steal data from storage, or alter records and backups in ways that may not be noticed until it is too late.

To meet this expectation, the organisation must encrypt all Confidential and Secret information while it is stored (“at rest”) across all relevant on-premises storage media and system components, using encryption strength appropriate to the sensitivity of the information. The organisation must also ensure the encryption approach helps prevent unauthorised changes. It must keep clear documentation showing what encryption is used and how it is configured for each relevant storage and backup location.

##### Encrypt Confidential/Secret data at rest on on-prem storage

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create/maintain authoritative data-location inventory for Confidential/Secret at-rest data on on-prem storage (servers, storage arrays/LUNs, file shares, backup repositories), including classification mapping and ownership | Data Protection Officer | Enterprise | 24h | — |
| Define cryptographic mechanism standards and configuration profiles per storage/media type (encryption algorithm/mode, key size, authenticated/integrity-capable options where available) and map Confidential vs Secret to key policies | Security Architect | Enterprise | 20h | — |
| Implement storage-layer encryption across all inventoried locations (enable volume/LUN encryption on arrays and server volumes; enable backup repository encryption) with change records and configuration baselines; document any vendor-specific constraints | Infrastructure Lead | Department | 56h | £18,000 |
| Implement/extend central key management controls (HSM-backed KMS/enterprise key manager): RBAC for key admin and decrypt operations, audited key usage, and classification-based key lifecycle (rotation/revocation) | Cyber Security Lead | Enterprise | 40h | £25,000 |
| Configure integrity/tamper-evidence approach for backups and storage workflows (authenticated/integrity-capable encryption where supported; compensating integrity verification during backup/restore; ensure alerts/logs on verification failures) | Security Engineer | Department | 32h | £6,000 |
| Produce audit-ready evidence pack per storage location: encryption configuration exports, key policy mapping, and key-management audit logs; include “no undocumented exceptions” statement and exception handling process (if any) | Compliance Manager | Enterprise | 24h | — |
| Execute practical validation tests (unauthorised copy/unlock test for encrypted volumes/snapshots; tamper/corruption detection during restore/verification; confirm logging/alerting and evidence capture) and record results | Quality Assurance Lead | Department | 24h | — |
| Operationalise and hand over: update runbooks, monitoring/alerting dashboards, and access review procedures for key administrators and decrypt operators; confirm backup/restore verification cadence | Operations Lead | Business Unit | 16h | — |

| Total Estimated Effort | 236h |
|---|---:|
| Total Estimated Cost | £55,000 |

###### Actions Required for Compliance

- [ ] Create and get approval for a complete list (inventory) of every on-premises storage location that holds Confidential and Secret data while it is stored (including backups). Map each location to **SC-28.01_ODP.01** and **SC-28.01_ODP.02**.
- [ ] Enable enterprise-approved storage and volume encryption on every inventoried server volume and every storage-array logical unit number (LUN) that hosts the identified data.
- [ ] Enable encryption for storing backups in the backup repository, and ensure the backup software is configured to write backups to the encrypted storage locations.
- [ ] Set up central key management using a hardware security module–backed key management system (HSM-backed KMS) or enterprise key manager, with role-based access control (RBAC), audited key use, and key rules based on data classification for Confidential versus Secret.
- [ ] Choose encryption options that provide integrity and authentication where available, or build and document integrity checks into the backup and restore process to detect any tampering.
- [ ] For each encrypted location, collect and store audit-ready evidence, including storage configuration exports and key-management audit logs.
- [ ] Run validation tests to show that the data cannot be read without authorisation or keys, and to confirm that any tampering or corruption is detected during restore and verification.


---

#### SC-28.2 — Offline Storage (Enhancement)

This requirement is about taking the organisation’s most sensitive information (the **Confidential** and **Secret** data sets and their associated metadata) out of systems that can be reached over the network, and keeping it offline in a secure location. The risk it addresses is that, if sensitive files stay online, they could be accessed by someone who should not have access—for example due to mistakes, stolen login details, or other unauthorised routes.

To meet this expectation, the organisation must:
- Clearly identify exactly which **Confidential** and **Secret** data sets and metadata are to be moved.
- Remove them from all online storage locations.
- Be able to provide evidence that they are no longer present online.

The organisation must then:
- Store the data offline in designated secure locations that are protected against unauthorised access.
- Document where the data is stored and how it is moved.
- Keep records showing when the data was moved and when it was stored offline.

The organisation should also have clear procedures, and include this approach in its security planning, system design, configuration documentation, and any related encryption settings if used. Named roles must be responsible for carrying out these actions.

##### Offline secure vault for Confidential/Secret datasets removal

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish version-controlled “sc-28.02_odp” dataset inventory (dataset identifiers, associated metadata, and every online system/location where it resides) | Compliance Manager | Enterprise | 16h | — |
| Define export-to-staging and deletion runbook (roles, approvals, integrity/hash requirements, retention/deletion rules, and evidence capture checklist) | Project Manager | Enterprise | 24h | — |
| Perform export of each dataset from online sources to controlled staging; compute and record cryptographic integrity values (e.g., SHA-256) and capture export logs | Storage Engineer | Enterprise | 40h | — |
| Prepare offline secure vault storage (encrypted offline media/appliance selection, physical security requirements, and custody log templates); confirm key handling approach for offline at-rest protection | Security Engineer | Enterprise | 24h | £12,000 |
| Execute deletion across all identified online locations (data, associated metadata/indexes, access revocation/shares/links/service accounts) with change records and operator logs | Operations Lead | Enterprise | 48h | — |
| Conduct verification scans/searches across online storage platforms and backup catalogues; reconcile results against inventory/hashes and produce an evidence pack (query results, scan reports, reconciliation summary) | Cyber Security Lead | Enterprise | 32h | — |
| Obtain formal approvals and archive audit evidence in the compliance repository (custody logs, export/deletion/verification evidence, vault location identifiers, and sign-off records) | Compliance Manager | Enterprise | 16h | — |

Total Estimated Effort: **200h**  
Total Estimated Cost: **£12,000**

###### Actions Required for Compliance

- [ ] Create and get approval for a complete list (inventory) of all **Confidential** and **Secret** datasets, including the related information (metadata), and link each dataset to every online storage location (per **SC-28.02_ODP**).
- [ ] For each dataset in scope, copy it from online storage to a controlled staging area, and record its integrity hash and dataset identifier.
- [ ] Store the exported datasets on offline, encrypted, non-network-connected storage (such as a dedicated appliance) kept in a physically secure vault, with custody and access records.
- [ ] Delete the datasets and their associated metadata from all online storage locations, and remove any remaining ways to access them (shared links, shared folders, and service accounts).
- [ ] Carry out targeted checks and searches across online storage and backup records to confirm that the datasets are no longer available online, and keep a record of the results.
- [ ] Document the locations where data is stored while offline, how that offline “at rest” data is protected using encryption and how encryption keys are managed, and provide a step-by-step process for removing the data, including the named responsible roles.


---

#### SC-28.3 — Cryptographic Keys (Enhancement)

This requirement is about keeping the secret keys that protect your systems locked away in a special, tamper-resistant place, so they can’t be stolen or misused. Without this, an attacker who gets hold of the keys could pretend to be your services, read or change protected information, or take control of systems—even if other safeguards are in place.

To meet this expectation, the organisation must store cryptographic keys using a hardware-protected key store (for example, a Trusted Platform Module), so the keys are protected while they are stored on the device. Access must be limited to the system owner and designated key custodians, using only the minimum permissions needed. Unauthorised staff must be prevented from accessing the keys.

The organisation must also securely configure the hardware key store, keep evidence of how it is set up and how the protection works, clearly document responsibilities and procedures, include this approach in its security planning, and keep records showing who accessed or used the protected keys.

##### TPM-backed hardware key store with custodian-only access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select and standardise the TPM-backed key storage mechanism for the application (OS/platform crypto provider, key management API approach, and supported deployment targets) | System Design Authority | Enterprise | 16h | — |
| Implement application key generation and usage via hardware-backed keystore (no raw key material export; update key lifecycle flows for create/rotate/recover) | Software Lead | Department | 40h | — |
| Configure trusted platform state enforcement (measured/attested boot where supported; define and apply TPM key usage policies tied to approved platform state) | Security Engineer | Department | 32h | — |
| Implement custodian-only access to key operations (identity/workflow authorisation, separation of duties, just-in-time approvals, and service account hardening) | Cyber Security Lead | Enterprise | 24h | — |
| Harden TPM and key-store configuration (ownership/hierarchy permissions, disable unnecessary interfaces, secure defaults, and environment-specific baselines for prod/test/DR) | Infrastructure Lead | Business Unit | 24h | — |
| Enable audit evidence generation and SIEM forwarding (key-store events, authorisation changes, usage attempts/success/failures, TPM events; retention mapping) | Compliance Manager | Enterprise | 24h | £3,000 |
| Produce compliance evidence pack (system design/configuration evidence, role mappings, TPM/key policy settings, test results, and audit log retention/coverage statements) | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 196h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Choose and standardise the trusted platform module (TPM)-backed method the application platform supports for storing encryption keys (for example, operating system or platform cryptography application programming interfaces (APIs), or an equivalent option).
- [ ] Set up the creation and secure storage of cryptographic keys so they are generated and kept inside the trusted hardware key store protected by the Trusted Platform Module (TPM).
- [ ] Define and enforce identity and access management (IAM) roles and workflows so the system owner and key custodians can approve key actions, using the principle of least privilege and separating responsibilities.
- [ ] Set up trusted platform module (TPM) security hardening and key rules, including who can control the TPM and its keys (ownership and hierarchy permissions), what approvals are required before changes (authorisation requirements), and turning off any TPM features or connections that are not needed (disable unnecessary interfaces).
- [ ] Where available, use measured and verified boot, and use trusted platform hardware (a trusted platform module, TPM) rules to ensure encryption key use is only allowed on the approved device state.
- [ ] Turn on audit logging for key-store and trusted platform module (TPM) events, send the logs to the security information and event management (SIEM) system, and check that audit logs are kept long enough to cover key creation, changes, and use attempts.
- [ ] Produce audit-ready documentation, including: system design evidence, exports of trusted platform module (TPM) and key store configurations, role mappings, and procedures that set out responsibilities for key custodians.


---

### SC-29 — Heterogeneity (Control)

This requirement is about not relying on just one type of technology. Across the whole network and beyond—how people are identified and allowed access, the computers staff use, the servers that run services, the websites and applications, the databases, and the tools that collect and review security records—the organisation should use a deliberately mixed set of technologies rather than depending on a single one.

This matters because if one technology has a hidden weakness, a supplier problem, or a widespread flaw, attackers could potentially use it to affect many parts of the system at the same time. Using different technologies reduces the risk that “one mistake breaks everything” and makes successful attacks harder.

To meet this expectation, the organisation must:
- plan and document which technologies will be used for each part of the system
- keep an up-to-date list of what is actually in place
- ensure procurement and design records support the decision to use a deliberate mix of technologies
- configure system settings to match the chosen technologies
- name specific people responsible for implementing and maintaining this approach

##### Deliberate technology diversity map and enforcement by component

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish and publish the authoritative “technology diversity map” template (CMDB/configuration management register schema) covering all 7 SC-29 component areas, including required fields (vendor/product, version/build, environment scope, evidence links) | System Design Authority | Enterprise | 16h | — |
| Populate the technology diversity map with current deployed technologies for the application system across prod/test/DR, including verification against authoritative sources (CMDB, infrastructure inventory, IAM configuration, SIEM ingestion sources, deployment manifests) | Infrastructure Lead | Business Unit | 40h | — |
| Define target diversity rules and exception criteria per component area in system design/security documentation (minimum diversity expectation, approved exception triggers, compensating controls, and approval workflow) | Security Architecture | Enterprise | 24h | — |
| Implement diversity at integration points used by critical paths (documented and evidenced): independent/parallel log ingestion paths into SIEM; distinct reverse-proxy/app runtime options where feasible; multiple IAM integration mechanisms (e.g., federation/SSO broker patterns) | Platform Engineer | Department | 32h | — |
| Create deployment governance controls to prevent “no single-platform drift”: update change management/release gates and pipeline checklists to require selecting from the approved technology list per component area; define escalation/approval for diversity-reducing changes | Project Manager | Enterprise | 24h | — |
| Produce baseline configuration standards per approved technology platform (so diversity is enforced operationally, not only on paper) and map each baseline to the diversity rule for audit traceability | Operations Lead | Department | 24h | — |
| Record procurement/design rationale and maintain audit evidence pack: architecture decision records (ADRs), procurement justifications, and release-by-release updates linking deployed components to the diversity rule | Compliance Manager | Enterprise | 20h | — |

| Total Estimated Effort |  |  | **200h** | — |
| Total Estimated Cost |  |  | — | **£0** |

###### Actions Required for Compliance

- [ ] Create and keep up to date an official technology diversity map that covers every component of the SC-29 system and all relevant environments.
- [ ] Set clear expectations for diversity targets for each component area in the system design and security documentation, including specific criteria for when exceptions are allowed.
- [ ] Where possible, choose and deploy at least two different technology platforms for each component area. If this is not feasible, document the approved exceptions and the compensating controls that will be used.
- [ ] Add governance checks (“gates”) to the change and release process so that deployments cannot reduce diversity below the approved rule unless an authorised approval is recorded.
- [ ] Publish and use standard configuration settings for each selected technology platform to prevent “paper diversity”
- [ ] Record the procurement and architecture reasons showing that diversity was deliberately chosen to reduce failures caused by shared weaknesses and supply-chain problems.
- [ ] Review and update the diversity map at every major release, and keep audit records showing which deployed components follow the approved diversity rule.


---

#### SC-29.1 — Virtualization Techniques (Enhancement)

This requirement is about using approved virtual environments to run different types of software safely, and updating them on a regular schedule. It addresses the risk that outdated or poorly managed software can make it easier for attackers to gain access, and that making frequent changes to real systems can lead to mistakes that leave weaknesses behind.

To meet this expectation, the organisation must run a variety of operating systems and applications inside approved virtual environments, and update those virtual operating systems and applications at least once every quarter. These updates must be carried out through the organisation’s formal change approval process. The organisation must keep clear records showing what was changed, when it was done, and what the system looked like before and after.

The organisation must also keep an up-to-date list of what is running virtually, document how the virtual approach is used in its system design and security planning, assign named people to carry out the work, and keep audit-ready evidence that the quarterly updates were completed.

##### Quarterly VM/App diversity refresh via approved golden images

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define and publish the approved virtualisation standard (isolation model, network segmentation, logging/telemetry, hardening baseline, supported hypervisors/managed VM platforms) as a controlled configuration baseline | System Design Authority | Enterprise | 40h | — |
| Create the curated diversity catalogue and golden-image lineage mapping (approved OS/app stack list, template lineage rules, versioning scheme, retirement criteria) | Compliance Manager | Enterprise | 32h | — |
| Build/extend golden-image/template pipelines for quarterly rebuilds (vendor patch ingestion, app update ingestion, malware scanning integration, configuration validation, build metadata generation) | Platform Engineer | Enterprise | 120h | £18,000 |
| Implement deployment guardrails (IaC policy checks, template allow-lists, admission controls, and enforcement that only approved templates/isolation profiles can be instantiated) | DevOps Lead | Enterprise | 56h | £6,000 |
| Establish quarterly change-control workflow and evidence pack (change record template, linkage to pipeline run/build identifiers, before/after state capture, CAB approval workflow) | Project Manager | Enterprise | 24h | — |
| Implement auditable inventory/configuration records (CMDB/report updates, automated extraction of OS/app versions, template lineage, isolation profile; retention of pipeline logs and deployment confirmations) | Operations Lead | Enterprise | 48h | £4,000 |
| Update system design/architecture and system security plan to explicitly describe virtualisation approach, diversity mechanisms, and isolation controls (including audit evidence references) | Security Engineer | Enterprise | 24h | — |

**Total Estimated Effort:** 344h  
**Total Estimated Cost:** £28,000

###### Actions Required for Compliance

- [ ] Publish an approved virtualisation standard as a controlled configuration baseline, covering the supported platforms, the isolation model, the security hardening baseline, and the logging requirements.
- [ ] Create and keep up to date a catalogue of the required virtual operating system and application stacks, mapped to the approved golden image and template lineages.
- [ ] Set up a quarterly “golden image” and template build process that recreates virtual operating system and application images, including applying updates and patches, and then running security checks to confirm they are secure.
- [ ] Set up deployment controls so only approved deployment templates and isolation profiles can be created (template allow-lists and policy-as-code).
- [ ] Create and get approval for a formal change record for each quarterly virtual refresh. Link it to the relevant pipeline run and build identifiers, and record the “before” and “after” state.
- [ ] Automate updates to the configuration management database (CMDB) and inventory for every new virtual machine instance or template deployment, including the operating system and application versions, the template’s lineage, and the isolation profile. Keep the deployment and pipeline logs for audit purposes.
- [ ] Update the system design and architecture and the system security plan to describe the virtualisation approach, the use of diversity, and the isolation controls.


---

### SC-30 — Concealment and Misdirection (Control)

This requirement is about making it harder for attackers to identify your real business targets and the paths into your organisation. It does this by deliberately disguising and rearranging what they can see online. Without these measures, criminals may be able to test your internet-facing websites, public-facing application interfaces, and critical operational technology gateway servers, understand how they are set up, and then launch attacks that are more likely to succeed.

To meet this expectation, the organisation must keep a documented and approved set of disguise methods in place for these systems. This includes hiding underlying system details, using fake targets and fake services, changing which network ports are used, and regularly updating relevant configuration details. These actions must happen continuously, with decoy and port changes carried out at least once every seven days. There must be clear written procedures, named staff responsible for the work, and working mechanisms to ensure the changes are carried out.

The organisation must also record what was changed and when, and include this approach in its security planning documents. This is to show that the weekly activity actually took place.

##### Weekly moving-target ingress with decoys and port/service shuffling

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Deception techniques design pack: map SC-30 concealment/misdirection requirements to concrete implementation details (virtualisation scope, decoy endpoints, port-mapping pool, weekly shuffle elements, evidence schema) | Security Architect | Enterprise | 40h | — |
| Select/confirm programmable ingress/gateway pattern and integration approach (reverse proxy/API gateway/service-mesh/load balancer automation hooks) with architecture diagrams and change/rollback strategy | System Design Authority | Enterprise | 32h | — |
| Implement gateway/routing automation (configuration-as-code) to support dynamic remapping of external ports/endpoints to real vs decoy services, including deterministic mapping set IDs | Platform Engineer | Department | 80h | — |
| Build decoy services/honeypots for covered web/API/OT gateway surfaces (controlled responses, no real data access, consistent fingerprints, auth/error boundaries, test harness) | Software Lead | Department | 96h | — |
| Virtualised deployment model for real+decoy instances (VM/container templates, TLS termination behaviour consistency, resource isolation, environment segregation, baseline hardening) | Infrastructure Lead | Business Unit | 64h | £18,000 |
| Weekly rotation pipeline (minimum 7-day cadence): pre-change smoke tests, controlled rollout, post-change verification, automated rollback, and audit logging of mapping parameters | DevOps Lead | Team | 72h | £6,000 |
| SOC/monitoring enablement: telemetry for deception effectiveness and detection (SIEM event fields, alerting rules, dashboards, runbooks, and evidence retention validation) | Operations Lead | Department | 40h | — |
| Change/configuration management packaging: approved release artefacts, access controls for automation identity, audit-ready evidence generation and retention checks for each weekly rotation | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 448h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Define and get approval for the deception design methods used for each covered system (web applications, public application programming interfaces (APIs), and operational technology (OT) gateway servers).
- [ ] Set up a programmable entry point (gateway) that can automatically route traffic from outside to the correct inside systems, including both real and decoy instances.
- [ ] Set up virtual real and decoy service instances with controlled outward identifiers (fingerprints) and clear separation from production data.
- [ ] Set up decoy endpoints and honeypots that look like the expected system interfaces, but do not provide access to real data or privileged functions.
- [ ] Set up an approved pool of network port mappings, then change them weekly (every 7 days or less) by rotating the mappings and shuffling the configuration using configuration-as-code.
- [ ] Automate the weekly rotation process, including checks before and after, the ability to undo changes if needed, and storing proof of what happened (mapping set ID, date and time, and who/what performed the change).
- [ ] Check and record that the system runs continuously by creating audit-ready evidence for every weekly rotation cycle.


---

#### SC-30.2 — Randomness (Enhancement)

This expectation is about making routine security actions harder for attackers to predict, so they cannot easily plan when and how to strike. If the organisation always carries out the same checks at the same times, always uses the same service accounts and administrative roles, or replaces approved tools or suppliers with unapproved ones, an attacker can learn the pattern and choose the best moment to cause maximum disruption.

To meet this expectation, the organisation must introduce uncertainty by varying routine security activities by time of day, rotating which service accounts and administrative roles are used for those activities, and using only pre-approved alternative tools and suppliers. It must record these “randomness” methods in its security policy and procedures, ensure they are built into system design and architecture, apply them through system configuration, include them in the system security plan, and keep audit records and other relevant documentation so authorised people can check that the methods were actually carried out.

##### Policy-driven randomness for routine security tasks

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create and approve a system-specific **sc-30.02_odp randomness techniques register** covering: time-of-day variation windows/exclusions, bounded jitter rules, service account/admin role rotation set, and approved alternate tooling/supplier restrictions | Compliance Manager | Enterprise | 24h | — |
| Define “routine security tasks” scope and map each task to an **execution profile** (time profile + jitter bounds + excluded periods) and to an **approved toolchain/supplier binding** | System Design Authority | Enterprise | 16h | — |
| Design and implement the **policy-enforced scheduler/orchestrator** logic to select execution profiles, apply bounded jitter, block excluded windows, and trigger identity/role rotation workflows (where applicable) | Platform Engineer | Department | 56h | £3,000 |
| Implement **tooling/supplier enforcement** at execution time (task profile → approved toolchain/integration endpoints), including reject/alert behaviour for any non-approved selection | Security Engineer | Department | 24h | £1,500 |
| Integrate **audit evidence generation**: log schema and event capture for randomness decisions (timestamps, selected profile/jitter, selected identity/role, approved toolchain/supplier identifier) and ensure forwarding to central logging/SIEM | DevOps Lead | Enterprise | 24h | £2,000 |
| Update **system security plan, runbooks, and configuration management records** to reference the randomness techniques register and scheduler/orchestrator configuration (including version/commit identifiers) and provide auditor traceability | Compliance Manager | Enterprise | 16h | — |
| Execute end-to-end **validation and assurance**: representative test runs proving time-of-day variation, role/service account rotation (where applicable), and approved toolchain enforcement; produce evidence pack for review | Quality Assurance Lead | Enterprise | 20h | £1,000 |

**Total Estimated Effort:** 180h  
**Total Estimated Cost:** £7,500

###### Actions Required for Compliance

- [ ] Create and get approval for a register of system-specific randomness methods, aligned with **SC-30.02_ODP**, covering: **time-of-day variation**, a **rotation set for services and administrators**, and an **approved list of alternative tools or suppliers**.
- [ ] Identify and record the organisation’s defined “routine security tasks” for this application or system that will be carried out using randomness.
- [ ] Set up a central scheduler (or orchestrator) to run each routine security task only within its approved time-of-day window, with limited timing variation (jitter) and with specific excluded periods.
- [ ] Link each task profile to approved workload identities and service principals, and to an approved administrator role rotation set, so that tasks run with the minimum permissions needed (least privilege).
- [ ] Only allow tasks to run using approved toolchains and suppliers by checking the selected toolchain or supplier during execution, and raising an alert if anything not approved is chosen.
- [ ] Turn on and keep audit logs for every run. Each log should record the time and date, the chosen randomness profile and jitter settings, the identity and role used, and the approved toolchain or supplier identifier.
- [ ] Update the system security plan and runbooks to refer to the randomness techniques register and the version of the implemented scheduler and orchestration configuration.


---

#### SC-30.3 — Change Processing and Storage Locations (Enhancement)

This expectation is designed to make it harder for criminals to find and attack your most important computer work and where it is kept. It does this by periodically moving that work to different locations. If you do not do this, attackers can learn your fixed setup and repeatedly target the same places, which increases the chance of a successful breach and reduces the time and effort they need.

To meet this expectation, the organisation must:
- Keep a documented list of the specific processing and storage locations that will be moved for critical services.
- Move those locations at random times at least every three months.

Each move must be approved using the organisation’s normal change process before it happens. The organisation must keep clear records showing:
- what was changed,
- when it was approved, and
- when it was completed.

The organisation must also update its records to show the new locations, keep evidence that the changes were carried out, and retain audit evidence that the move happened as required. This approach must be included in its security planning.

##### Quarterly random relocation of critical processing/storage via change

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define and approve the “relocatable scope list” (processing/storage components and allowed from/to targets) with version-controlled documentation | System Design Authority | Enterprise | 24h | — |
| Design the random quarterly move-window generator (rules, minimum frequency quarterly, non-deterministic scheduling, storage of planned windows in the change package) | Architect | Enterprise | 32h | — |
| Extend/implement the change-control workflow templates to capture required fields (from/to, cutover method, rollback, pre-approvals, timing rationale) and enforce approval gates | Compliance Manager | Enterprise | 40h | — |
| Build automation for execution orchestration and configuration updates (CMDB/service-to-region mapping, endpoint/DNS/ingress targets, replication topology identifiers) linked to each change record | Platform Engineer | Department | 56h | £6,000 |
| Implement evidence capture and retention for each move (cutover/failover/replication logs, orchestration run logs, change approval/completion timestamps) and validate audit traceability | Security Engineer | Enterprise | 32h | £3,500 |
| Update the system security plan and relocation procedure (including concealment/misdirection expectations, handling of non-public timing/targets, operational runbook alignment) | Data Protection Officer | Enterprise | 20h | — |
| Run end-to-end pilot move (test environment or controlled production window) and complete lessons learned, then harden for repeatable quarterly operations | Operations Lead | Business Unit | 24h | £2,000 |
| Establish quarterly operational cadence (calendar generation, CAB scheduling, readiness checks, rollback rehearsal) for the first two quarters | Service Delivery Manager | Business Unit | 24h | — |

**Total Estimated Effort:** 252h  
**Total Estimated Cost:** £11,500

###### Actions Required for Compliance

- [ ] Create and approve a version-controlled list of the application’s processing and/or storage locations that are eligible to be moved.
- [ ] Set up a scheduler that creates quarterly “move windows” using random time periods, and includes them in a controlled change package.
- [ ] Set up the relocation orchestration to move computing and storage using replication, failover, and a blue-green cutover, and record the cutover date and time.
- [ ] Link the relocation process to the organisation change management system so that each move must be approved in advance and the system records the “from” and “to” locations for every relocation.
- [ ] Automate updates to the configuration database (CMDB) and configuration baselines so they reflect the new processing and storage locations, and link those updates to the relevant change record.
- [ ] For each relocation, store and keep audit evidence—such as change approval and completion records, plus platform, database, and storage logs—so it is available for audit review.
- [ ] Update the system security plan to include the relocation procedure, the evidence you must provide, and the operational limits for concealment and misdirection.


---

#### SC-30.4 — Misleading Information (Enhancement)

This requirement is about intentionally presenting a public-facing website and its public-facing online programming links in a way that makes outsiders believe the organisation’s security protections are different from what they actually are.  

The real risk it addresses is that attackers often look at what protections appear to be in place, then choose the most effective way to test, break into, or disrupt the service. If the information they see is realistically misleading, it can slow them down and steer them towards less effective approaches.  

To meet this expectation, the organisation must clearly decide which parts of the public website and public programming links are in scope. It must then consistently show realistic but intentionally misleading statements about the service’s security position across those pages and responses.  

The organisation must also:  
- document what is being misrepresented and how  
- assign named responsibility for maintaining it  
- include the approach in its system planning and design records  
- keep the relevant settings and documentation up to date  
- keep audit evidence showing that changes were made through authorised processes, so an independent reviewer can confirm the misleading information is present and intentional

##### Deception catalogue for public web/API security posture messaging

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define and approve the in-scope public surface for deception (web routes/pages, API endpoints incl. unauthenticated error paths, and public documentation/security sections) with a signed-off scope record | Compliance Manager | Enterprise | 16h | — |
| Design the versioned deception catalogue schema (claim text, placement mechanism, security-posture rationale, internal truth/difference notes, content hash strategy, and retirement metadata) | System Design Authority | Enterprise | 24h | — |
| Implement the centrally managed catalogue service/storage and versioning mechanism (single source of truth; content-hash generation; controlled access for authors/approvers) | Platform Engineer | Enterprise | 56h | £12,000 |
| Implement the single injection mechanism across web and API surfaces (shared templates/blocks for web; controlled public response elements/headers/structured error payload fields for APIs) | Software Lead | Department | 64h | — |
| Build the authorised change workflow and governance controls (approval gates, role-based access, audit trail capture of approvals and catalogue version identifiers) | Project Manager | Enterprise | 24h | — |
| Implement immutable audit logging and deployment evidence (log catalogue version, content hash, build/release identifier to immutable store; ensure retention alignment) | Operations Lead | Enterprise | 24h | £6,000 |
| Create CI/CD validation: automated crawl/smoke checks for web placements and sampled API response assertions for the deployed catalogue version (fail build on drift) | DevOps Lead | Department | 40h | — |
| Produce and publish the written procedure for review/approval/update/retirement of deception content, including safeguards to keep claims realistic and posture-focused (not operational details) | Data Protection Officer | Enterprise | 16h | — |

**Total Estimated Effort:** 288h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] List and record the exact public-facing web routes and pages, and the application programming interface (API) endpoints, that are in scope for sc-30.04_odp (including error pages and endpoints that can be accessed without authentication).
- [ ] Create a version-controlled deception catalogue that includes the claim wording, where each claim should be placed, and internal notes explaining what is true and what differs.
- [ ] Set up one central, catalogue-based injection method for web templates and for API response fields and headers.
- [ ] Set up an authorised approval process and tamper-proof audit records for catalogue updates, including the version, a content fingerprint (hash), and the deployment reference (deployment ID).
- [ ] Set up automated continuous integration and continuous delivery (CI/CD) checks to crawl the in-scope pages and test sample in-scope application programming interface (API) endpoints, to confirm the expected misleading claims are present.
- [ ] Write and keep up to date a procedure that sets out who is responsible, how often the deception content is reviewed, and the conditions for retiring it.


---

#### SC-30.5 — Concealment of System Components (Enhancement)

This requirement is about making key systems harder to locate and harder to access by keeping them hidden behind carefully designed protections. Without this, attackers could more easily target your most important operational technology servers, industrial gateways, and identity servers, and then use stolen or intercepted information to gain a foothold or cause disruption.

To meet this expectation, the organisation must protect and conceal these components by:
- separating their network connections from other systems,
- using encryption to protect data both when it is stored and while it is being sent, and
- using virtual or container-based setups to isolate and disguise the components.

The organisation must also keep clear records showing:
- which components are covered,
- which concealment methods are used,
- how the concealment is designed, implemented, and managed over time, including approved procedures,
- the system design and configuration details, and
- evidence that changes are controlled, so the concealment is not accidentally weakened.

##### Conceal OT control servers/gateways/DCs via segmentation, encryption, isolation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce in-scope concealment mapping (OT control servers, industrial gateways, domain controllers) including component-to-technique matrix (segmentation, encryption in transit, encryption at rest, virtualisation/container isolation) | Compliance Manager | Enterprise | 16h | — |
| Design target network segmentation for concealment (zone definitions, default-deny inter-zone routing, explicit allow rules for required management/service paths; include OT Management zone and OT Gateway/DMZ zone) | Network Security Engineer | Enterprise | 24h | — |
| Implement segmentation controls (firewall/router/security group rules, routing policies, and verification tests showing default-deny and only required paths to in-scope components) | Infrastructure Lead | Enterprise | 32h | £6,000 |
| Enforce encryption in transit for management/service communications (TLS/SSH/VPN requirements, certificate/CA alignment, disable/block plaintext alternatives, and validate protocol/cipher posture) | Security Engineer | Enterprise | 28h | £3,500 |
| Implement and verify encryption at rest for in-scope components (enable storage/volume encryption, database/storage encryption where applicable, and validate encryption status and key usage) | Platform Engineer | Enterprise | 24h | £8,000 |
| Implement virtualisation/containerisation isolation where feasible (dedicated hardened hosting placement, restricted inter-VM/container networking, and repeatable deployment templates/images) | DevOps Lead | Enterprise | 32h | £10,000 |
| Update system security plan and configuration management evidence pack (zone diagrams, mapping, enforced encrypted protocols, encryption status reports, and isolation evidence) | Compliance Manager | Enterprise | 20h | — |
| Establish change-control “no weakening of concealment” checks (workflow updates, required evidence outputs, configuration diff/audit logging, and run-through for a test change) | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 190h  
**Total Estimated Cost:** £27,500

###### Actions Required for Compliance

- [ ] Create an authoritative, in-scope inventory of operational technology (OT) control servers, industrial gateways, and domain controllers, and map each one to the concealment techniques used.
- [ ] Set up separate operational technology (OT) network zones. Use “deny by default” routing, and only allow traffic to the in-scope components through clearly defined rules for the specific management and service connections that are required.
- [ ] Require encrypted connections for management and service access (Transport Layer Security (TLS), Secure Shell (SSH), Virtual Private Network (VPN), and private connectivity), and block any unencrypted (plaintext) alternatives for the in-scope components.
- [ ] Turn on and confirm encryption for data stored on the in-scope components’ storage volumes, and document that key management is aligned.
- [ ] Where possible, deploy the in-scope components in separate virtual machines or container environments, and limit network connections between hosts and containers.
- [ ] Update the system security plan to include zone diagrams, a link between each component and the security techniques it uses, and the rules for how data must be encrypted when systems communicate with each other.
- [ ] Add concealment settings—such as segmentation policies, encryption enforcement, and isolation parameters—to configuration management. Also require change tickets to include a “no weakening” check, with the supporting evidence kept on record.


---

### SC-31 — Covert Channel Analysis (Control)

This requirement is about checking whether information could leak out through the way systems communicate—either through what they store or through small, hard-to-spot differences in timing—and then assessing how much information such a hidden path could carry. Without this work, someone could potentially send unauthorised information between different parts of an organisation (or between an internal system and an external connection) in ways that are difficult to detect, particularly when sensitive data is involved.

To meet this expectation, the organisation must:
- define the scope of the analysis
- analyse the system’s communications to identify potential hidden storage routes and potential hidden timing routes
- record what was found
- estimate, for each identified route, the maximum possible amount of data it could carry

The organisation should use its system design and configuration records as evidence, keep clear and auditable records of the analysis (including the method used, assumptions made, and results), ensure the activity is included in the system’s security plan, and update the analysis when changes are made that affect communications.

##### Covert storage/timing channel analysis with bandwidth estimates

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create and get approval for an “in-scope communications” inventory covering service-to-service/API traffic, message buses, admin channels, and external ingress/egress paths | Compliance Manager | Enterprise | 16h | — |
| Build a channel-candidate register for each in-scope interface, identifying potential **covert storage** and **covert timing** channels with rationale tied to protocol/system behaviour | Security Engineer | Department | 24h | — |
| Develop a documented, repeatable bandwidth estimation template (storage + timing) including conservative upper-bound assumptions, observation granularity, symbol/response rate model, and distinguishability constraints | System Design Authority | Enterprise | 16h | — |
| Perform maximum bandwidth estimation for each identified channel using the template; produce per-channel results with explicit assumptions and calculation/estimation method | Security Engineer | Department | 32h | — |
| Collect and link traceability evidence for each channel (queue depths, buffering/persistence, caching TTLs, retry/backoff state, timeouts, rate limiting, concurrency/load balancer settings, scheduling/jitter sources) and record artefact references | Platform Engineer | Business Unit | 24h | — |
| Version, date, and package the analysis outputs (inventory + channel register + bandwidth estimates + evidence index) and reference them in the system security plan for SC-31 audit traceability | Compliance Manager | Enterprise | 12h | — |
| Define and document the update/review process for communications-related changes (triggers, ownership, re-analysis scope rules) and complete at least one review cycle record (or documented rationale) | Project Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 136h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create and get approval for an in-scope communications inventory that covers all relevant internal connections and any external or cross-domain connections.
- [ ] Run structured workshops to create a list of potential channel candidates for each interface, separating candidates related to hidden storage from candidates related to hidden timing.
- [ ] Document a repeatable method for estimating bandwidth and apply it to each candidate using clear, conservative assumptions.
- [ ] Link each channel finding to the specific architecture and design documents, and to the configuration evidence, that shows how storage and timing behaviour is affected.
- [ ] Store the analysis results in a version-controlled repository, including an audit-ready record of the method used, the assumptions made, the results obtained, and the dates.
- [ ] Update the system security plan to refer to the scope of the SC-31 analysis and where the supporting evidence is stored.
- [ ] Define and carry out a re-check trigger whenever communications-related changes are made (protocols, timeouts, queueing, caching, rate limiting, and external integrations).


---

#### SC-31.1 — Test Covert Channels for Exploitability (Enhancement)

This requirement is about checking whether there are hidden ways for information to get through your systems that could be used to move unauthorised data. Without testing, an organisation might assume these “covert channels” are harmless, but in reality they could let someone pass information in ways that get around normal protections. This could lead to data leakage or other serious misuse.

To meet this expectation, the organisation must take the list of identified covert channels and select a sensible subset to test, following its documented procedures and using the real system setup described in its design and configuration records. It then runs the tests for each selected covert channel, records clear results showing whether each one can be used (or not), keeps the supporting evidence in audit records, and updates its covert channel analysis documentation and the system’s security plan to reflect what was tested and the results.

##### Exploitability testing of selected covert channels with auditable evidence

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm scope: select documented subset of identified covert channels using risk-based method (likelihood × impact × exposure) and produce selection rationale mapped to the identified covert channel list | Compliance Manager | Enterprise | 16h | — |
| Define measurable, repeatable exploitability test criteria per channel (exploitable / not exploitable / inconclusive) including pass/fail thresholds, evidence requirements, and decision rules | Security Architect | Enterprise | 24h | — |
| Prepare staging/test environment alignment: obtain configuration baselines/version snapshots and ensure logging/telemetry/packet capture paths mirror relevant production-like design/configuration (without using production) | Platform Engineer | Enterprise | 20h | — |
| Build and validate controlled exploitability test workflow/harness for the selected channels (repeatable runbook, test identifiers, timing, data-path mapping, evidence capture checklist) | Security Engineer | Enterprise | 32h | — |
| Execute exploitability tests per selected channel in staging, capturing auditable evidence (timestamps, configuration baseline references, involved components/data paths, raw artefacts such as logs/telemetry exports/packet captures, and test outputs) | Operations Lead | Enterprise | 40h | £2,500 |
| Perform per-channel outcome assessment against predefined criteria and produce an auditable results pack (exploitable / not exploitable / inconclusive) with evidence pointers and justification | Compliance Manager | Enterprise | 16h | — |
| Update covert channel analysis documentation and the system security plan to reflect tested subset scope, outcomes, follow-on actions/mitigations, and explicitly mark remaining channels as untested | Data Protection Officer | Enterprise | 16h | — |

Total Estimated Effort: **164h**  
Total Estimated Cost: **£2,500**

###### Actions Required for Compliance

- [ ] Compile the current list of identified covert channels and confirm that it is the official source of information for SC-31(1) testing.
- [ ] Choose a risk-based subset of covert channels and document why you selected them, including the limits of what is and is not covered.
- [ ] Before any testing begins, define measurable criteria for how exploitable each selected channel is (exploitable, not exploitable, or inconclusive).
- [ ] Set up a staging or test environment that matches the relevant system design and configuration settings, and export a baseline configuration reference for audit purposes.
- [ ] Run controlled vulnerability testing for each communication channel, and collect evidence that can be audited (for example, logs, telemetry data, and packet captures where relevant), using unique test reference numbers.
- [ ] Record the results for each channel, along with supporting evidence references and the reason they meet the predefined criteria.
- [ ] Update the covert channel analysis report and the system security plan to reflect the scope that was tested and the results found.


---

#### SC-31.2 — Maximum Bandwidth (Enhancement)

This requirement is about preventing hidden ways that information could be smuggled through a system. It does this by setting a strict limit on how quickly any identified hidden “data storage” or “timing” signals can carry information. Without this limit, a determined attacker could potentially hide messages in the system’s behaviour—by exploiting subtle differences in what the system does or when it does it—which could weaken confidentiality even if normal safeguards are in place.

To meet this expectation, the organisation must:
- Have clear written procedures to review systems, identify any hidden channels, and use the findings to redesign or reconfigure the affected systems.
- Ensure that, for each identified hidden channel, the maximum hidden information rate is no more than **50 kilobits per second**.

The organisation must also:
- Record the target and the specific system changes in system plans and design records.
- Include the same requirement in purchase and supplier contracts.
- Assign clear responsibilities to the right staff.
- Keep audit evidence showing that the **50 kilobits per second** limit remains in place over time.

##### Enforce 50 kbps covert-channel bandwidth budgets via config baselines

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Consolidate covert-channel analysis outputs into a channel register (storage/timing), including measurable behaviours, assumptions, and the target ceiling of 50 kbps per channel | Security Engineer | Enterprise | 24h | — |
| Define “control knobs” per identified channel (scheduler/timing parameters, buffering/queue limits, storage access patterns, IPC/service behaviours) and produce a mapping worksheet from channel → knob(s) → expected bandwidth impact | Security Engineer | Enterprise | 32h | — |
| Produce justification pack for each mapping (vendor documentation, internal test results, or formal analysis) demonstrating mapped constraints enforce maximum bandwidth ≤ 50 kbps | Compliance Manager | Enterprise | 24h | — |
| Implement hardened configuration/design constraints as policy-as-code / configuration baselines across environments (dev/test/prod/DR), including non-overridable defaults and validation rules | Platform Engineer | Enterprise | 56h | £8,000 |
| Build drift detection and continuous enforcement (configuration compliance checks, alerting, and automated remediation runbooks) for the mapped knobs with evidence capture | DevOps Lead | Enterprise | 40h | £6,000 |
| Integrate change control workflow: require CAB approval for any change touching mapped knobs, with mandatory linkage to the channel register/justification pack and a compliance check that constraints remain ≤ 50 kbps | Project Manager | Enterprise | 24h | — |
| Generate audit evidence automation: per-environment effective configuration values, linked analysis record IDs, and change ticket references; produce an audit-ready report template | Compliance Manager | Enterprise | 24h | £3,000 |
| Run pilot on representative services/environments and remediate gaps (mapping accuracy, enforcement coverage, false positives/negatives), then sign-off for rollout | Service Delivery Manager | Enterprise | 32h | — |

**Total Estimated Effort:** 256h  
**Total Estimated Cost:** £17,000

###### Actions Required for Compliance

- [ ] Carry out covert-channel analysis to identify the hidden storage and timing channels that have been found, and to describe what behaviours affect them.
- [ ] Set clear “control knobs” for each channel’s configuration and design, and record the reason why the maximum bandwidth that results is **50 kilobits per second (50 kbps) or less**.
- [ ] Set fixed bandwidth limits of **50 kilobits per second (kbps) or less** in secure, standard configuration templates for all relevant environments, using automated policy controls (policy-as-code).
- [ ] Run continuous checks to confirm configurations stay compliant, and stop any changes that cause “configuration drift” which could increase the capacity of hidden communication channels.
- [ ] Update the change control process so that any change to mapped “knobs” requires approval that references the covert-channel analysis record and the bandwidth budget.
- [ ] Automate the export of audit evidence that shows the effective configuration settings, links to the relevant analysis identifiers, and references the associated change tickets.


---

#### SC-31.3 — Measure Bandwidth in Operational Environments (Enhancement)

This requirement is about checking, in the real day-to-day environment where your system runs, how much hidden information could potentially be leaked through subtle system behaviour, such as patterns in timing or changes related to how data is stored. If this is not measured, an organisation may underestimate the risk that sensitive information could leak in ways that are difficult to detect, potentially harming business operations or mission outcomes.

To meet this expectation, the organisation must measure the “timing-based and storage-based” hidden information routes in the operational environment (not just in a laboratory), using its documented procedures for covert channel analysis. It must base the work on the relevant system design and current settings, record the measured bandwidth results in the organisation’s covert channel analysis documentation, and keep traceable supporting evidence in audit records, aligned with the system’s security plan and any other relevant records.

##### Operational covert channel bandwidth measurement (timing & storage)

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Confirm sc-31.03_odp covert channel subset scope and produce channel mapping (timing-based vs storage-based) from design/config to operational behaviours | Cyber Security Lead | Enterprise | 24h | — |
| Review and tailor the organisation’s approved covert channel analysis procedure for this system (encoding/bit mapping, receiver inference, windowing/stopping criteria, bandwidth metric, confidence handling) | Compliance Manager | Enterprise | 16h | — |
| Define operational measurement plan with bounded experiments: workload profiles, perturbation parameters, SLO/SLA impact assessment, stop/rollback criteria, safety constraints, and data classification/retention safeguards | Project Manager | Enterprise | 20h | — |
| Prepare operational telemetry and evidence capture: identify required logs/traces/metrics, configure sampling/retention for the measurement window, and ensure tamper-evident audit storage | SOC/Observability engineer | Enterprise | 18h | £6,000 |
| Execute change-managed operational measurements for timing-based covert channels (authorised runbooks, controlled workload perturbations, data collection, immediate validation against stopping criteria) | Operations Lead | Enterprise | 28h | — |
| Execute change-managed operational measurements for storage-based covert channels (authorised runbooks, controlled persistence/update/delete patterns, data collection, immediate validation against stopping criteria) | Operations Lead | Enterprise | 28h | — |
| Compute bandwidth results and produce auditable, reproducible evidence packs per channel type (raw/derived metrics, uncertainty/confidence, environment identifiers, configuration baselines, workload/perturbation parameters, traceability to security plan) | Data Protection Officer | Enterprise | 24h | — |

Total Estimated Effort: **158h**  
Total Estimated Cost: **£6,000**

###### Actions Required for Compliance

- [ ] Identify the defined covert channel subset (SC-31.03_ODP) and match it to specific timing-based and storage-based behaviours, using the system design and the current operational configuration.
- [ ] Choose and record the bandwidth measure to use, the encoding and receiving methods, the time periods for the measurements, and the conditions for when to stop, following the organisation’s covert channel analysis procedure.
- [ ] Get approval through the change-management process and set the operational limits, including the impact on service-level objectives and service-level agreements (SLOs and SLAs), the conditions for rolling back or stopping the change, and the rules for how data will be handled and retained.
- [ ] Carry out limited, authorised operational tests to measure timing-based hidden communication channels, and calculate the data transfer rate (bandwidth) from the recorded telemetry.
- [ ] Carry out limited, authorised operational tests to measure storage-based covert channels, and calculate the data transfer rate (bandwidth) from the recorded telemetry.
- [ ] Record the results and supporting evidence in the covert channel analysis records, with clear links to the audit records and alignment with the system security plan.


---

### SC-32 — System Partitioning (Control)

This requirement is about keeping different parts of your system in separate, clearly separated areas. This helps ensure sensitive information and important functions cannot be accessed casually. Without this separation, a mistake or compromise in one part (for example, a web service) could spread to other parts (such as databases that hold confidential records). That could disrupt operations, expose data, or allow unauthorised actions across the whole environment.

To meet this expectation, the organisation must split the system into separate logical areas for:
- network services,
- application services, and
- data stores.

Each area must be placed based on how sensitive and critical the data is (Secret/Confidential) and whether it is in an information technology (IT) environment or an operational technology (OT) environment.

The organisation must also use managed, controlled connection points between these areas. Only the information that is necessary should be allowed to flow between them, and everything else must be blocked by default.

Finally, the organisation must:
- document the reasons for the design,
- keep diagrams and an up-to-date list of the domains,
- ensure the live setup matches the documentation,
- maintain clear responsibilities and procedures, and
- record this approach in its security plan.

##### Zone-based logical partitioning with managed allow-listed interfaces

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authoritative zone/domain inventory covering network services, application services, and data stores (including production/test/DR separation) | System Design Authority | Enterprise | 24h | — |
| Produce zone placement rationale for each domain using data sensitivity/criticality (Secret/Confidential) and IT vs OT trust boundary mapping | Compliance Manager | Enterprise | 16h | — |
| Design managed-interface architecture (default-deny, central policy enforcement point, required allow-list flow model, logging requirements, identity/service context where feasible) | Security Engineer | Enterprise | 32h | — |
| Implement logical separation by provisioning/aligning subnets/VPCs/VNETs/tenants per zone and environment (dev/test/prod/DR) with baseline routing constraints | Infrastructure Lead | Business Unit | 40h | £8,000 |
| Configure managed interfaces with explicit allow-list rules between zones (source zone → destination zone, protocol/port, service context), and enable logging for allowed and denied attempts | DevOps Lead | Department | 48h | £12,000 |
| Establish version-controlled configuration and drift-resistant reconciliation (IaC/policy-as-code, diagram-to-config checks during change windows, evidence capture) | Platform Engineer | Enterprise | 40h | £6,000 |
| Operationalise governance: assign zone/interface owners, define CAB/change workflow for cross-zone allow-list changes, and update runbooks/incident procedures for denied-flow investigations | Project Manager | Enterprise | 24h | — |

| Total Estimated Effort | 224h |  |
| Total Estimated Cost |  | £26,000 |

###### Actions Required for Compliance

- [ ] Create and get approval for an inventory of zones and domains used for network services, application services, and data storage systems.
- [ ] Document where each zone is placed, and explain why, based on its Secret or Confidential sensitivity level and the trust boundary between information technology (IT) and operational technology (OT).
- [ ] Set up logical separation for each zone by using separate subnets, virtual private clouds (VPCs), virtual networks (VNETs), or tenants, as appropriate for the hosting setup.
- [ ] Set up managed connections between zones so that traffic is blocked by default, and only explicitly allow the specific data flows that are required.
- [ ] Store which security zones a system belongs to and the rules for its network interfaces in version-controlled infrastructure-as-code (IaC) and policy-as-code, and only deploy changes through change-controlled pipelines.
- [ ] Create network and facility diagrams, then compare the diagrams against the configuration records to confirm that the live environment matches the documented partitioning.
- [ ] Assign owners for each network zone and for rules that connect between zones, and require Change Advisory Board (CAB) approval for any changes that allow-list connectivity.


---

#### SC-32.1 — Separate Physical Domains for Privileged Functions (Enhancement)

This requirement is about protecting the most powerful, security-critical functions by running them in separate physical areas. That way, if something goes wrong in one area, the problem cannot automatically spread to the others.

If all “privileged” activities—those that can make important security changes—are carried out in the same place, then a break-in, equipment failure, or loss of service in that one area could stop or compromise everything at once. To meet this requirement, the organisation must first identify which functions are privileged. It must then place them into separate physical domains or environments, and ensure that a compromise or outage in one domain does not affect the others.

The organisation must also document how this separation works in its security policy, partitioning procedures, system design and architecture documents, configuration settings records, and its security plan. It must keep an up-to-date list of the physical domains in use.

Finally, it must maintain facility and network diagrams that clearly show where the privileged functions are located and how the separated environments connect. All documents must be consistent with each other.

##### Physically isolate privileged admin functions into separate domains

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce privileged-function inventory (authoritative list) and map each privileged function to a single physical domain (including break-glass tooling) | Security Engineering Lead | Enterprise | 40h | — |
| Define target domain architecture and separation boundaries (IdP/IAM Admin, Security Configuration Admin, Backup/Recovery Admin, and any additional platform privileged admin) including management-plane assumptions | System Design Authority | Enterprise | 32h | — |
| Implement dedicated admin environments per domain (hardened jump hosts/admin workstations) with separate management networks/VLANs/VRF and restricted routing | Infrastructure Lead | Enterprise | 56h | £18,000 |
| Configure inter-domain connectivity controls (allow-list routing/firewall rules; deny-by-default for admin control-plane; implement read-only telemetry/log export where required) | Security Engineer | Enterprise | 40h | £6,000 |
| Implement deployment guardrails (IaC/pipeline admission checks to prevent privileged components being provisioned into the wrong domain; validate host groups/network targets) | DevOps Lead | Enterprise | 32h | £4,000 |
| Update and version audit evidence: facility/network diagrams, system security plan, configuration records, and change-control artefacts reflecting the implemented partitioning | Compliance Manager | Enterprise | 24h | — |
| Run tabletop exercises and operational readiness checks (domain compromise/DoS scenarios; verify that privileged functions do not share failure domains; confirm break-glass procedures are domain-contained) | Service Delivery Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 240h  
**Total Estimated Cost:** £28,000

###### Actions Required for Compliance

- [ ] Identify and document all privileged functions for the application and its management system (security-sensitive administrative capabilities), and assign an owner to each.
- [ ] Define the required physical areas and environments, and assign each privileged function to its designated area.
- [ ] Set up dedicated administration workstations (jump hosts) for each domain, with separate management networks (virtual local area networks (VLANs) / virtual routing and forwarding (VRF)), and block all administrative network routes by default (deny-by-default) so only approved paths are allowed.
- [ ] Set up tightly limited connections between domains—for example, allowing only read-only telemetry and log exports—and explicitly block any cross-domain routes that would allow administrative control.
- [ ] Add deployment and provisioning safeguards (continuous integration and continuous delivery (CI/CD) approval checks or infrastructure as code (IaC) validation) to prevent highly privileged components from being deployed into the wrong physical environment.
- [ ] Update and version the facility and network diagrams, system security plan, architecture and design documents, and configuration records so they reflect the domain partitioning and stay consistent with each other.


---

### SC-34 — Non-modifiable Executable Programs (Control)

This requirement is about ensuring the classified system starts using software that cannot be changed, and that only approved applications run from similarly protected, unchangeable copies. If this is not in place, someone could alter the system’s starting code or install unauthorised software, allowing harmful changes to remain after every restart and giving attackers a dependable way in.

To meet this requirement, the organisation must ensure that the operating system and the virtual machine host components used for classified workloads are loaded and run only from hardware-protected read-only media. It must also ensure that only the approved mission and security applications packaged in read-only images are loaded and run from the same type of protected media.

The organisation must keep exact, documented lists of which system components and applications are allowed. It must record which specific read-only media are used, define and follow clear procedures for how these unchangeable images are created and used, and document the design, settings, and controls that enforce this behaviour. It must also keep audit records showing the system started and ran as expected, and it must check that attempts to use writable storage for starting or running applications are blocked.

##### Verified read-only boot and app images for classified hosts

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define and approve versioned allow-lists for authorised OS/hypervisor/VM host component sets and approved application read-only images (including required immutable identifiers: hashes/signing thumbprints/measurements) | Compliance Manager | Enterprise | 24h | — |
| Design the verified/measured boot enforcement approach for classified hosts (firmware capabilities, boot path restrictions, expected measurement mapping, fail-safe behaviour) and produce implementation runbook | System Design Authority | Enterprise | 32h | — |
| Implement firmware/host configuration for hardware-backed verified/measured boot and boot-order/boot-device lockdown for classified hosts; document configuration baselines | Platform Engineer | Enterprise | 56h | — |
| Build and sign read-only OS/hypervisor and application images in a controlled pipeline; generate runtime-verification evidence and ensure traceability to the allow-lists | Software Lead | Enterprise | 72h | £18,000 |
| Implement application execution enforcement to run only from approved read-only image identifiers (launcher/runtime policy, signature/hash/measurement checks, safe failure and logging) | Security Engineer | Enterprise | 40h | — |
| Integrate and validate audit evidence collection for boot and application execution (event schemas, correlation rules, SIEM forwarding, retention configuration) and conduct end-to-end verification testing | Operations Lead | Enterprise | 40h | £6,000 |
| Deliver operational governance: change/release process updates for image lifecycle, allow-list updates, key/certificate rotation procedure, and periodic access/audit readiness checks | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 328h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Create and approve version-controlled lists of approved components for authorised operating system and hypervisor software (sc-34_odp.01) and approved mission and security applications (sc-34_odp.02).
- [ ] Set up hardware-based verified and measured boot that only allows the system to start from approved, hardware-enforced read-only storage, and that checks that the expected measurements and digital signatures match.
- [ ] Create read-only images of the operating system, hypervisor, and applications using a controlled process, and digitally sign them when they are created using recorded, unchangeable identifiers.
- [ ] Configure the platform firmware and operating environment so that, if someone tries to start the application or system from writable or unapproved storage media, it will be blocked or will safely fail.
- [ ] Set up the application to start and run only from approved, read-only image identifiers (hash, signature, or measurement), and block any unapproved images.
- [ ] Keep audit records in one place for boot devices or media, the results of verification or measurements, and the identifiers of the executed application images.


---

#### SC-34.1 — No Writable Storage (Enhancement)

This requirement is about ensuring that any computer parts used to handle **Confidential** and **Secret** information cannot save changes to storage in a way that still exists after a restart or a power cut. In everyday terms, it stops a malicious person from installing harmful software or hidden files that would still be present the next time the device starts—an approach attackers commonly use to persist and maintain control.

To meet this expectation, the organisation must:

- Keep a documented list of every component that handles **Confidential** and **Secret** data.
- Configure each component so it has **no persistent writable storage** across restart or power on/off. This includes both internal storage and removable media such as **universal serial bus (USB)** drives or **secure digital (SD)** cards.
- Where removable storage is possible, enforce appropriate access restrictions for mobile or portable use, so persistent writable storage cannot be used.

The organisation must also:

- Document how these controls are enforced.
- Reflect them in system plans and design and configuration records.
- Keep evidence from system settings and audit records showing that the actual behaviour matches what is claimed.

##### Enforce stateless, non-persistent storage for in-scope components

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish the authoritative in-scope component list for sc-34.01_odp (inventory cross-check, data classification mapping, and component ownership tagging) | Compliance Manager | Enterprise | 24h | — |
| Define the target technical enforcement pattern(s) for stateless/non-persistent storage (read-only root/system partitions, tmpfs/ramdisk mapping, wipe-on-boot scratch, log/cache handling rules, and exceptions process) | System Design Authority | Enterprise | 32h | — |
| Implement configuration-as-code baselines for in-scope components (OS hardening/read-only settings, writable path remapping, wipe-on-boot configuration, and immutable deployment settings) | Platform Engineer | Enterprise | 56h | — |
| Build and deploy immutable, signed golden images/templates for in-scope workloads (replace-on-change rollout, remove in-place persistence, and validate boot-time wipe behaviour) | DevOps Lead | Enterprise | 64h | £12,000 |
| Configure centralised logging/telemetry for non-persistent operation (ensure logs/caches/temp outputs are routed to approved collectors and verify no local persistence) | Operations Lead | Enterprise | 32h | £6,000 |
| Implement detection and audit evidence collection (alert on writes to non-persistent paths, capture filesystem denials/controls drift, and produce restart/power-cycle evidence packages) | Security Engineer | Enterprise | 48h | £8,000 |
| Update system security plan and configuration/design records with enforcement mechanisms and verification results; run compliance validation and sign-off | Data Protection Officer | Enterprise | 24h | — |

**Total Estimated Effort:** 280h  
**Total Estimated Cost:** £26,000

###### Actions Required for Compliance

- [ ] Create and keep up to date the official list of all in-scope system components that handle Confidential and Secret information (sc-34.01_odp).
- [ ] Set up the in-scope components so that the operating system and system partitions are read-only, and any parts that need to be writable are redirected to memory-based storage or to scratch space that is cleared on every boot.
- [ ] Deploy the in-scope components from unchangeable, digitally signed “golden” images/templates, and replace them when changes are needed rather than updating them in place.
- [ ] Set up “configuration as code” baseline settings to stop changes from drifting over time in the mappings for read-only and non-persistent storage.
- [ ] Set up monitoring to detect write attempts to non-persistent paths and to identify configuration changes (configuration drift) events.
- [ ] Update the system security plan and the configuration and design records to document the technical method(s) that prevent data from being kept after shutdown, and to keep evidence that the system restarts and power cycles behave as expected.


---

#### SC-34.2 — Integrity Protection on Read-only Media (Enhancement)

This expectation is about making sure information is real and remains unchanged when it is copied onto read-only discs or similar storage, and then keeping tight control of the storage media after it has been written. Without this, someone could change the information before it is recorded, swap the disc for a different one, or reprogram a device that is meant to be read-only. This could cause systems to run altered or malicious content.

To meet this expectation, the organisation must protect the information before it is written so it cannot be changed during preparation, and must stop the media being swapped or reprogrammed before it is installed. After recording is complete, the organisation must control the media, check for any tampering or replacement, and take appropriate action if problems are found.

The organisation must also document how this is done, ensure that named authorised people are responsible for installing and maintaining the media, and keep records and audit information showing that the approach was applied and kept in place.

##### Sign read-only media content and verify at installation with custody control

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the end-to-end media integrity & custody control design (manifest schema, media identifier binding approach, failure handling, audit evidence requirements) | System Design Authority | Enterprise | 16h | — |
| Implement signed manifest generation in the release pipeline (per-release manifest with per-file hashes + metadata, signature creation workflow, release record storage) | Software Lead | Enterprise | 40h | £8,000 |
| Implement recording-time verification and controlled burn workflow (pre-burn signature verification, hash checks, media ID capture, burn tool integration, access restrictions/approvals) | DevOps Lead | Enterprise | 48h | £6,000 |
| Deploy signing key protection and verification services (HSM-backed signing integration or managed signing service, certificate/key lifecycle, trust chain management) | Security Engineer | Enterprise | 32h | £15,000 |
| Implement tamper-evident packaging labelling and custody workflow (asset tagging, seal/label process, controlled storage, custody transfer logging with authorisation and timestamps) | Compliance Manager | Enterprise | 24h | £4,000 |
| Build installation/receipt verifier tool (signature + hash + media identifier checks, operator UX, local execution hardening, and generation of audit logs for SIEM) | Platform Engineer | Enterprise | 40h | £7,000 |
| Establish quarantine and re-issue runbook with incident workflow integration (block installation/use on failure, ticket/incident creation, evidence capture, re-issue from authoritative pipeline) | Operations Lead | Enterprise | 16h | — |

**Total Estimated Effort:** 216h  
**Total Estimated Cost:** £40,000

###### Actions Required for Compliance

- [ ] Define which read-only media types are included in scope, and identify the locations where verification will be carried out for recording and installation.
- [ ] Add a step to generate a signed content manifest in the release pipeline, using a signing key that is protected by the organisation.
- [ ] Update the recording process so that each physical media identifier (serial number or label) is included in the signed manifest, and require checks before the media is burned.
- [ ] Set up tamper-evident packaging and a custody process that logs every handover of the item, including the identity of the authorised person and the date and time (timestamp) of each transfer.
- [ ] Create and standardise an installation and receipt checker that confirms the signature is valid, the file checksums (hashes) match, and the media is the expected type before it is used.
- [ ] Create an incident report and quarantine process, then re-issue the instructions (playbook) for verification failures. Make sure it runs automatically or through an auditable workflow that can be reviewed and recorded.
- [ ] Connect the verifier and custody records to the organisation’s central logging system and security information and event management (SIEM), and keep the evidence for audit purposes.


---

### SC-35 — External Malicious Code Identification (Control)

This requirement is about actively checking the outside world for dangerous software and websites before they can harm you. The real-world risk is that harmful code hosted on external sites, or hidden within web content, could be downloaded, opened, or triggered and then spread into your organisation’s systems. This could lead to disruption, loss of data, and financial or reputational damage.

To meet this expectation, the organisation must run automated tools that proactively check external networks, including the Internet, to identify suspicious malicious code and malicious websites. The organisation must also have clear, documented procedures covering how these checks are carried out, how often they run, what is scanned, and what happens when something is flagged.

Any suspicious content found must be handled only in a safely separated, controlled environment (for example, a virtualised sandbox) so it cannot affect production systems. The organisation must document how the scanning is built and configured, keep records of scanning activity and results, include this approach in its security planning, and name specific roles responsible for operating, installing, configuring, and maintaining the capability.

##### Proactive external web probing with sandbox detonation pipeline

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define external probing scope, target strategy, and cadence (risk-based rules, allow/deny lists, test domains, and change-controlled configuration) | Cyber Security Lead | Enterprise | 16h | — |
| Select and procure/enable proactive web probing capability (e.g., web threat defence / URL probing / threat emulation integration) and obtain required licences | Compliance Manager | Enterprise | 8h | £25,000 |
| Design and implement sandbox isolation architecture (virtualisation approach, ephemeral execution, deny-by-default egress, internal network route prevention, and resource limits) | Security Engineer | Enterprise | 24h | — |
| Implement automated pipeline workflow (probe → capture artefact/URL → sandbox detonation/analysis → verdict → triage) with strict separation so probing service cannot access internal resources | Platform Engineer | Enterprise | 40h | — |
| Configure logging, evidence capture, and SIEM forwarding (probe events, artefact identifiers, sandbox boundary identifiers, verdict outcomes, operator actions) with retention aligned to policy | Operations Lead | Enterprise | 16h | — |
| Develop operational governance and runbooks (role responsibilities, approval workflow for scope changes, incident/false-positive handling, escalation paths, and periodic access reviews) | Project Manager | Enterprise | 12h | — |
| Execute end-to-end testing and compliance validation (isolation verification, egress controls testing, verdict accuracy checks, audit evidence rehearsal, and sign-off for SC-35) | Quality Assurance Lead | Enterprise | 20h | £2,500 |
| Total Estimated Effort |  |  | **136h** | — |
| Total Estimated Cost |  |  | — | **£27,500** |

###### Actions Required for Compliance

- [ ] Document the external probing scope, the criteria used to choose targets, and the probing schedule in an auditable procedure.
- [ ] Set up and deploy an enterprise capability that actively checks external websites and domains for signs of malicious code.
- [ ] Set up a virtual “sandbox” environment where outgoing network traffic is blocked by default, and where there are no routes to the organisation’s internal networks.
- [ ] Set up an automated process that takes data from the initial probe, runs it in a safe test environment, records the outcome (verdict), and then sends the results to the security operations centre (SOC) for triage.
- [ ] Link probe and sandbox execution logs to the security information and event management (SIEM) system, and keep the evidence for audit purposes.
- [ ] Assign named responsibilities for operating, installing/configuring, and maintaining the probing and sandbox components.


---

### SC-36 — Distributed Processing and Storage (Control)

This requirement is about not keeping all your computing and data in one place. If one site has a problem, your work should be able to continue. Without this, an outage, maintenance issue, or other disruption at a single location could stop important services and make your information unavailable. This would directly affect day-to-day operations and the people who rely on them.

To meet this requirement, the organisation must spread its main processing components across multiple physical locations. This includes the application servers, the system that runs and manages containers, and the scheduled batch job services. It must also spread its storage components across multiple physical locations. This includes databases, file or object storage, and backup storage. The organisation must ensure there is no single location that is the only place where processing or storage can happen.

The organisation must:
- document where each component runs
- record how the sites are set out in design and security planning documents
- keep configuration records that support the multi-location setup
- assign named responsibilities for running and maintaining each location
- ensure contingency plans cover how operations and access to data can continue by using the other locations for parallel processing and storage

##### Multi-site processing and storage placement with parallel failover

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define authoritative multi-location component-to-location mapping (processing + storage) including target domains (e.g., DC-A/DC-B), placement constraints, and HA/parallel-capacity assumptions | System Design Authority | Enterprise | 24h | — |
| Design batch parallel execution model (sharding/partitioning + job ownership/leader election rules) and produce coordination runbook for preventing duplicate execution | Software Lead | Enterprise | 20h | — |
| Implement multi-site processing deployment (application + orchestration workers + batch services) with infrastructure-as-code placement constraints and health-aware routing/load balancing | Infrastructure Lead | Enterprise | 64h | £18,000 |
| Implement multi-site storage replication and access model (database replication, object storage cross-site availability, and backup storage targets in at least two locations) | Platform Engineer | Enterprise | 72h | £35,000 |
| Configure and validate failover/parallel capacity (location outage simulation, continued processing, replicated storage accessibility, and routing failover) with automated test evidence | DevOps Lead | Enterprise | 40h | £6,000 |
| Produce audit-ready evidence pack (architecture/security plan updates, configuration/IaC outputs, deployment manifests, placement evidence, and control traceability) | Compliance Manager | Enterprise | 28h | — |
| Update contingency/DR procedures and run at least one tabletop + one operational test demonstrating continued operation via the secondary location | Service Delivery Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 272h  
**Total Estimated Cost:** £59,000

###### Actions Required for Compliance

- [ ] Define and document how each system component is assigned to specific processing (sc-36_odp.01) and storage (sc-36_odp.03) locations across multiple physical sites (sc-36_odp.02, sc-36_odp.04).
- [ ] Set up application servers and container orchestration workers in at least two separate physical locations, and use infrastructure-as-code to control where they are placed.
- [ ] Set up batch processing so it can run at the same time in multiple locations. Use job partitioning (sharding) or a leader election approach to ensure only one location runs each job, preventing duplicate runs.
- [ ] Set up database and object storage replication and cross-site availability so the storage can be accessed from multiple locations, without relying on a single primary site.
- [ ] Set up backup storage in more than one physical location, and test restoring data from the secondary location.
- [ ] Update the system design, architecture, security plan, and configuration records to show that the system can operate across multiple locations and can process and store data in parallel.
- [ ] Assign specific operational responsibilities for each location. Then run a contingency test to show that processing continues and data remains accessible even if one location becomes unavailable.


---

#### SC-36.1 — Polling Techniques (Enhancement)

This expectation is about regularly checking that your on-premises systems are still working correctly. It does this by comparing the results produced by multiple copies of the same processing and storage, and acting quickly if they do not match. Without this, faults, data mistakes, or unauthorised changes could go unnoticed, which could lead to confidential information being exposed or changed, or to services becoming unavailable.

To meet this expectation, the organisation must keep a documented list of the on-premises application servers, databases, and storage clusters that hold Confidential and Secret data. It must also have a documented method for periodically comparing results and stored content across the distributed parts, using a clear decision approach rather than relying on a single component.

The organisation must keep evidence that these checks are carried out. If an inconsistency is found, it must record when it was detected and then respond by isolating the affected nodes or volumes, alerting the security operations centre (SOC), starting incident response, and rolling the affected components back to the last known good state. The organisation must keep records showing what was changed and that normal operation was restored.

##### Quorum polling for DB/storage replicas with automated quarantine

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce authoritative in-scope inventory for DB/storage replicas and volumes (IDs, node/replica mapping, volume identifiers, environments, ownership) | Compliance Manager | Enterprise | 24h | — |
| Define deterministic “consistency signals” per component type (DB: LSN/GTID + sampled/invariant hash strategy; Storage: snapshot IDs + block/hash sampling + metadata indicators) and document normalisation rules | System Design Authority | Enterprise | 40h | — |
| Design and implement polling collectors and normalisation layer (scheduled + on-demand, time-window alignment, sampling controls, secure signal transport) | Platform Engineer | Department | 72h | — |
| Implement voting/quorum decision engine with documented ruleset and full vote traceability (member IDs, signals, decision, correlation IDs) | Security Engineer | Department | 40h | — |
| Build automated response workflow (quarantine implicated node(s)/volume(s), SOC alert integration, incident trigger hooks, and rollback to last known good snapshot/version) | DevOps Lead | Department | 64h | — |
| Implement tamper-evident audit evidence logging for each run (run manifest, signals collected, vote result, mismatch details, actions taken, timestamps, retention and access controls) | Data Protection Officer | Enterprise | 32h | — |
| Execute integration testing and operational readiness (simulated divergence/corruption, runbooks, access/permissions validation, monitoring/alert tuning, DR/rollback rehearsal) | Quality Assurance Lead | Enterprise | 48h | £6,000 |
| Total Estimated Effort |  |  | **320h** | — |
| Total Estimated Cost |  |  | — | **£6,000** |

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date, official list of on-premises distributed processing and storage components that host Confidential or Secret data for polling.
- [ ] Define clear, repeatable consistency checks and the sampling and normalisation rules for each component type (database replicas and storage volumes).
- [ ] Set up scheduled polling to collect signals from each replica, node, and volume, and then calculate consistent, comparable summaries.
- [ ] Set up a documented voting method (for example, majority, quorum, or a defined ruleset) and make sure that, for each run, the voting inputs and the final voting decision are recorded.
- [ ] Set up automated mismatch detection and response to isolate the affected devices or storage volumes, notify the security operations centre (SOC), and start the incident response process.
- [ ] Set up automatic rollback so the system can return to the last known good snapshot/version, and record the rollback details using correlation identifiers (correlation IDs).
- [ ] Store tamper-evident audit evidence for each polling run, including the coverage (scope), the signals recorded, the vote result, and the actions taken in response.


---

#### SC-36.2 — Synchronization (Enhancement)

This requirement is about making sure your duplicate company directory—and the information it uses to decide who can sign in and what they can do—stays consistent across every data centre. If this is not done, different locations could end up with different user details or access rights. That could result in staff being incorrectly blocked, unauthorised access being allowed, or critical business systems behaving differently depending on where they are accessed.

To meet this expectation, the organisation must clearly identify and document what is duplicated (the on-premises directory service and the related sign-in and permission information). It must also describe and document how the synchronisation works, and include it in the system design, architecture, and security planning.

The organisation must configure the systems so synchronisation runs as intended, keep records proving it is working, monitor it over time, and be able to provide evidence that changes made in one data centre appear in the others within the organisation’s agreed acceptable timeframes.

##### Synchronise on-prem AD and auth/authorisation data across data centres

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Confirm and document in-scope “authentication/authorisation data” for synchronisation (users, groups, group memberships, and any AD security settings driving access decisions), including object classes/attributes and exclusions | Compliance Manager | Enterprise | 16h | — |
| Design multi-site AD replication for each data centre (AD Sites/Subnets, connection objects, replication schedules, and topology documentation aligned to network topology) | System Design Authority | Enterprise | 24h | — |
| Standardise authoritative DC deployment per data centre (resilient DC coverage, baseline build checklist, and documented compensating controls where DC deployment is not feasible) | Infrastructure Lead | Enterprise | 32h | — |
| Enforce replication prerequisites consistently across sites (NTP/time sync, DNS configuration, DC baseline hardening, and controlled change process for replication-related settings) | Security Engineer | Enterprise | 24h | — |
| Define and approve acceptable convergence window (timeliness target), including measurement method, normal vs degraded operating assumptions, and escalation thresholds | Compliance Manager | Enterprise | 12h | — |
| Implement monitoring and audit evidence capture for replication health (collect replication status/errors/queue/lingering indicators; integrate with SIEM/monitoring; configure alerting and evidence retention) | Operations Lead | Enterprise | 40h | £6,000 |
| Execute controlled validation tests (documented change in one data centre; verify propagation to other data centres within convergence window; record results and remediation actions) | Quality Assurance Lead | Enterprise | 24h | — |

| Total Estimated Effort | 172h |  |
|---|---:|---:|
| Total Estimated Cost |  | £6,000 |

###### Actions Required for Compliance

- [ ] Confirm and record the exact Active Directory (AD) objects and security-relevant information that the organisation defines as “authentication and authorisation data” for sc-36.02_odp.
- [ ] Set up Active Directory (AD) sites and subnets, and define the replication layout so that each data centre has “authoritative” domain controllers (DCs) that take part in replication.
- [ ] Standardise the requirements needed for data replication across all participating data centres, including time synchronisation (Network Time Protocol (NTP)), Domain Name System (DNS) settings, and a consistent baseline configuration for domain controllers (DCs).
- [ ] Set an acceptable time window for when authentication and authorisation changes must take effect, and record how you will measure it.
- [ ] Set up and centralise monitoring of Active Directory (AD) replication health and failures in the security information and event management (SIEM) and monitoring platform, with alerts.
- [ ] Keep records of replication health and event evidence for audit purposes, with access restricted to authorised users.
- [ ] Run regular controlled checks (for example, when group membership changes) and record the results showing that the system settles within the agreed acceptable time window.


---

### SC-37 — Out-of-band Channels (Control)

This requirement is about ensuring that the most sensitive items needed to run and update your on-premises systems are delivered using safe, separate routes, rather than the usual everyday computer connections. If this is not done, someone could intercept or alter items such as secret keys, login details, security updates, or system update packages while they are being sent over normal working networks. This could result in unauthorised access or harmful changes.

To meet this expectation, the organisation must keep a documented and approved list of “out-of-band” delivery methods and use only physically separate options for these sensitive items. The approved options are: physically separate courier delivery, dedicated offline media transfer such as encrypted USB, or the United States Postal Service.

The organisation must also:
- send these items only to named, authorised system owners and designated receiving custodians for each on-premises system
- keep clear records of what was sent, to whom, and when
- maintain written procedures and supporting documentation (including system plans and design notes) showing how these separate delivery routes are used and who is responsible

##### Out-of-band delivery register with authorised recipients and evidence

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define and approve the SC-37 compliant out-of-band channel list (courier, dedicated offline encrypted media, U.S. Postal Service) including exact operational rules and “no in-band fallback” rejection/escalation criteria | Compliance Manager | Enterprise | 16h | — |
| Create the in-scope item matrix mapping each item type (cryptographic keys/key-management information, authenticators/credentials, security updates, configuration change packages) to required out-of-band channel(s) and evidence requirements per channel | Compliance Manager | Enterprise | 20h | — |
| Establish authorised recipient roster per on-prem system (authorised system owner(s) and designated receiving custodian(s)), including approval workflow, periodic review cadence, and change control triggers | Data Protection Officer | Enterprise | 24h | — |
| Design the tamper-evident chain-of-custody and evidence model per channel (courier waybill/tracking + signed receipt; postal tracking + signed receipt; offline media serial logging + encrypted handling + issue/return/disposal record signed by custodian) | Security Engineer | Enterprise | 28h | — |
| Implement the operational procedure and dispatcher controls (dispatch request template, mandatory selection of approved channel and authorised recipient, evidence capture checklist, deviation handling and escalation route) | Project Manager | Enterprise | 24h | — |
| Set up the controlled evidence repository and retention approach (record types, access controls, audit trail expectations, indexing by system/item/channel/date, and retention schedule aligned to policy) | Operations Lead | Enterprise | 20h | — |
| Run pilot deliveries to generate audit-ready evidence for at least one recent delivery per channel type, including end-to-end testing with dispatchers and custodians and remediation of any evidence gaps | Service Delivery Manager | Enterprise | 40h | £3,000 |
| Conduct training and sign-off (dispatcher, receiving custodian, system owner) plus tabletop audit readiness review against SC-37 acceptance criteria | Quality Assurance Lead | Enterprise | 16h | — |

**Total Estimated Effort:** 188h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Approve and publish the out-of-band channel list: use a physically separate courier, dedicated encrypted offline storage media, and the United States Postal Service.
- [ ] Create an in-scope inventory matrix for cryptographic keys and key management information, authenticators and credentials, security updates, and configuration change packages.
- [ ] Maintain an approved list of recipients for each on-premises system (authorised system owners and named receiving custodians).
- [ ] Define and document the evidence handling requirements (chain of custody) for couriers, postal services, and encrypted offline media, including serial numbers, how items are issued, returned and disposed of, and signed receipts.
- [ ] Add a delivery request and check step that requires dispatchers to choose only approved delivery channels and only authorised recipients for in-scope items.
- [ ] Keep proof of delivery and receipt in a secure, controlled system for audit purposes, including tracking numbers and signed custody records.


---

#### SC-37.1 — Ensure Delivery and Transmission (Enhancement)

This requirement ensures that sensitive items are delivered only to the correct people and the correct systems. Without it, confidential and highly restricted information, approved software or firmware updates, and authorised equipment could be given to the wrong recipient, intercepted, or installed by unauthorised staff. This could lead to data exposure, disruption to operations, or malicious interference.

To meet this expectation, the organisation must use an approved courier service for these deliveries. The courier must check the recipient’s government-issued photographic identification and only hand over the items after the required checks are completed.

The organisation must also limit deliveries to authorised, security-cleared personnel and the named system owners for the specific receiving information system or operational technology network. The courier must deliver the correct items to the correct receiving system or network.

The organisation must keep delivery records that show the approved courier was used and that the identification and handover checks were completed.

##### Approved courier ID-verified handoff for confidential and OT/IT items

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define SC-37(1) courier handoff process requirements (ID verification, registry validation, refusal/escalation, evidence expectations) and publish as an enterprise-controlled procedure | Compliance Manager | Enterprise | 16h | — |
| Create and populate the recipient-to-receiving-system registry (including receiving system/network identifiers, designated recipients, authorised alternates, and approval workflow) | Data Protection Officer | Enterprise | 24h | — |
| Define delivery classes and acceptance points (confidential/Secret data, approved updates, authorised OT/IT components) with required checks and acceptance desk/mailroom instructions | Security Engineer | Enterprise | 16h | — |
| Update courier contract/SOP to enforce ID verification (government-issued photographic ID), delivery reference validation, and access-controlled handoff only after successful verification | Procurement / Vendor Management | Enterprise | 20h | £3,000 |
| Implement delivery reference generation and label/manifest requirements (unique reference per shipment, printed on labels, mapping to receiving system/network and recipient registry entry) | Platform Engineer | Enterprise | 24h | — |
| Establish refusal and escalation procedure runbook (including incident logging triggers, contact paths to system owners, and handling of failed verification/mismatched recipient) | Operations Lead | Enterprise | 12h | — |
| Define audit-ready evidence retention standard and operational record templates (POD fields: reference, date/time, location, recipient, ID verification outcome, handoff confirmation) and confirm retention period | Compliance Manager | Enterprise | 16h | — |

Total Estimated Effort: **128 Hours**  
Total Estimated Cost: **£3,000**

###### Actions Required for Compliance

- [ ] Set up and get approval for a recipient register that links each receiving system and operational technology (OT) control network to the named system owner and an authorised backup alternate.
- [ ] Define clear acceptance checkpoints and refusal or escalation steps when identity verification fails or when the recipient does not match the expected record.
- [ ] Update the approved courier contract and standard operating procedure (SOP) to require verification of a government-issued photographic identity document and an access-controlled handover.
- [ ] Add a unique delivery reference to each label and manifest, and require courier and receiving staff to check that the delivery reference matches the correct recipient.
- [ ] Train reception and secure mailroom staff on how to verify requests, when to refuse them, and how to escalate concerns
- [ ] Store delivery evidence that is ready for audit in a way that makes changes obvious. This includes the delivery reference, the recipient’s identity, the result of identity checks, the time and location of delivery, and confirmation that the handover was completed.


---

### SC-38 — Operations Security (Control)

This requirement is about protecting the most sensitive project information while you are building, testing, and launching systems, so it does not reach the wrong people. Without this, attackers could learn how your organisation plans to operate, what weaknesses exist, and how your suppliers and testing activities work. That would make it easier to interfere with, steal from, or disrupt your services.

To meet this expectation, the organisation must use a structured approach across the entire build-and-test process: identify which specific information is critical to the organisation’s mission, consider who might try to obtain it and what could go wrong, assess the risk of it being disclosed or misused, and then put practical safeguards in place.

This must cover not only internal development and testing, but also information shared with suppliers, potential suppliers, and external testing or evaluation partners. Information sharing must be limited to those who need it.

The organisation must also document who is responsible, maintain a plan and a list of safeguards, record the key decisions and risk assessments, track any required fixes until they are completed, and ensure relevant staff follow the documented approach.

##### SDLC OPSEC workflow with supplier/test sharing gates

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define OPSEC governance model and RACI for SDLC (OPSEC owner, security architect, system/product owner, supplier management lead, test/evaluation lead, release/change gate owners) | Compliance Manager | Enterprise | 16h | — |
| Create OPSEC security plan mapping the five OPSEC steps (critical info ID, threat analysis, vulnerability analysis, risk assessment, countermeasures) to SDLC phases and required evidence types | Security Engineer | Enterprise | 24h | — |
| Establish OPSEC-critical information register template and populate initial register entries by SDLC artefact type (including user identities, element uses, suppliers/supply chain processes, functional/security requirements, system design specs, testing/evaluation protocols, security control implementation details) | Cyber Security Lead | Enterprise | 40h | — |
| Implement SDLC OPSEC assessment record workflow (intake triggers, required fields, linkage to deliverables/releases, audit trail requirements, approval/attestation steps) | Project Manager | Enterprise | 32h | — |
| Perform OPSEC assessments for priority SDLC deliverables/releases (requirements, design, build/integration, testing/evaluation) and produce auditable assessment records with countermeasures and residual risk decisions | Security Architect | Enterprise | 56h | — |
| Define and document supplier/potential supplier sharing gate controls for OPSEC-critical information (need-to-know rules, purpose/recipient approvals, data minimisation/redaction, contractual/technical handling, return/destruction requirements) | Service Delivery Manager | Enterprise | 24h | — |
| Define and document testing/evaluation sharing gate controls for OPSEC-critical information (test protocol handling, environment specifics, security control implementation details, approval checkpoint, evidence retention) | Quality Assurance Lead | Enterprise | 24h | — |
| Set up remediation tracking and closure evidence process for OPSEC gaps (create remediation actions, link to tickets, verify closure, retain evidence for audit) | Operations Lead | Enterprise | 24h | — |

Total Estimated Effort: **240h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Assign named operational security (OPSEC) roles and publish an operational security (OPSEC) plan that maps the five OPSEC steps to software development life cycle (SDLC) phases.
- [ ] Create and keep up to date an operations security (OPSEC)-critical information register, with clear, real-world examples for each software development life cycle (SDLC) document type.
- [ ] Carry out and record operational security (OPSEC) assessments for each deliverable that is relevant to OPSEC. This includes identifying critical information, analysing threats, analysing vulnerabilities, assessing risk, and defining countermeasures.
- [ ] Define and enforce “need-to-know” sharing rules for suppliers (and potential suppliers) and for testing and evaluation partners, including approval checkpoints.
- [ ] Set up a software development lifecycle (SDLC) approval checkpoint so that external sharing of operational security (OPSEC)-critical information cannot happen unless there is recorded OPSEC approval.
- [ ] Track operational security (OPSEC) issues to the corrective actions taken, and keep proof that each issue is closed so it can be checked during audits.


---

### SC-39 — Process Isolation (Control)

This requirement is about keeping each part of a running system in its own protected space, so one software component cannot interfere with another component’s code or information. Without this separation, a faulty or malicious programme could disrupt other programmes, change what they do, steal or damage information, or use one component as a way to spread harm across the system.

To meet this expectation, the organisation must design and build the system so that every running process has its own separate execution environment, and so that any communication between processes happens only through approved, controlled routes. The organisation must document how this separation is achieved in its system design and architecture, and keep evidence from independent testing showing that the separation works as intended. This includes evidence that attempts to interfere with another process are blocked, while authorised communication still works.

Developers and system integrators must implement the isolation measures described. The organisation must also keep the supporting records showing that this approach is enabled and applied to the relevant processes.

##### OS-enforced per-process isolation with controlled IPC

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Harden OS/container host baseline for process isolation (enable NX/DEP, ASLR, restrict debugging/ptrace, disable cross-process inspection where feasible) via configuration-as-code | Infrastructure Lead | Enterprise | 40h | £6,000 |
| Implement least-privilege process/service identities per application component (service accounts/containers), including MAC/capability restrictions and removal of privileged execution paths | Security Engineer | Enterprise | 32h | — |
| Configure platform isolation primitives per deployment model (VM/host and container): separate namespaces/process boundaries, prevent cross-container process access, enforce capability drops and no privileged containers | Platform Engineer | Enterprise | 40h | £4,000 |
| Define and implement approved, security-mediated IPC channels (authenticated sockets/message broker/OS IPC objects) with strict ACLs and endpoint authorisation checks | Software Lead | Business Unit | 48h | £10,000 |
| Replace/retire any ad-hoc IPC/shared-memory patterns; update application integration contracts and deployment manifests to use only approved IPC interfaces | DevOps Lead | Business Unit | 24h | — |
| Produce architecture/design records mapping each executing process to its isolation boundary and listing allowed IPC mechanisms + authorisation rules (audit-ready) | Compliance Manager | Enterprise | 16h | — |
| Execute independent IV&V: negative tampering tests (attach/ptrace-like, memory write attempts, unauthorised IPC) and positive authorised IPC tests; retain objective evidence and reports | Quality Assurance Lead | Enterprise | 32h | £8,000 |

**Total Estimated Effort:** 232h  
**Total Estimated Cost:** £28,000

###### Actions Required for Compliance

- [ ] Define and publish a more secure operating system (OS) and container host standard that enables memory protection and limits the ability for one process to inspect or attach to another process.
- [ ] Deploy each application component as its own operating system identity (for example, a service account or a non-privileged container process) and give it the minimum permissions it needs (least privilege).
- [ ] Set operating system and container security rules (for example, mandatory access control and capability limits) so one process cannot read, write to, or attach to another process’s memory.
- [ ] Update inter-process communication so that all process-to-process data sharing uses approved secure communication routes, with identity checks (authentication) and permission checks (authorisation).
- [ ] Create and keep an up-to-date architecture record that links each running process to (1) how it is isolated and (2) which inter-process communication (IPC) routes it is allowed to use.
- [ ] Run independent tests to check for unauthorised tampering (for example, attaching to another process, writing to memory, and unauthorised inter-process communication) and keep test evidence suitable for audit purposes.
- [ ] Run independent positive inter-process communication (IPC) tests to confirm that authorised communication still works.


---

#### SC-39.1 — Hardware Separation (Enhancement)

This requirement is about using built-in hardware safeguards to keep the computer’s different tasks separated, so one task cannot easily interfere with or reveal information from another. Without this, a problem in one part of the system could spread, allowing attackers or faults to move between tasks and potentially access sensitive information or disrupt services.

To meet this expectation, the organisation must decide which hardware separation features it will rely on (for example, hardware memory management), set out that choice in its security policy, and clearly describe it in the system design and overall architecture. It must also make sure the system is configured so those features are enabled and working as intended, and it must keep records of the configuration settings.

The organisation must keep supplier documentation that supports the selected features, and it must also retain independent verification evidence showing that the separation has been implemented and is effective. The same chosen feature must be referenced consistently across the policy, design, configuration records, and verification reports.

##### Enable hardware-enforced process isolation on managed compute

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select and standardise hardware separation mechanisms (record exact vendor feature names, enforcement layer, and scope of in-scope CPU/hypervisor/firmware combinations) | System Design Authority | Enterprise | 16h | — |
| Define isolation boundaries and update system architecture/security design (e.g., production vs admin tooling, tenant/workload boundaries, security tooling vs business workloads) | Security Engineer | Enterprise | 24h | — |
| Configure compute layer to enable mechanisms (BIOS/UEFI/firmware + hypervisor settings) and implement enforcement verification hooks in deployment/cluster build process | Platform Engineer | Enterprise | 40h | — |
| Create auditable configuration baseline (expected values, allowed/blocked states, configuration management templates, and version-controlled baseline documentation) | Configuration Management Lead | Enterprise | 24h | — |
| Implement live evidence collection and baseline comparison workflow (hypervisor/host dumps, firmware reports, platform tooling outputs; automated evidence packaging for audit) | DevOps Lead | Enterprise | 32h | £6,000 |
| Update traceability across documentation and records (system security plan, architecture/design docs, and configuration evidence mapping using consistent mechanism naming) | Compliance Manager | Enterprise | 16h | — |
| Retain supplier/manufacturer documentation and commission independent verification (IV&V) to confirm isolation boundary enforcement and effectiveness; produce IV&V report and remediation actions | Compliance Manager | Enterprise | 32h | £15,000 |
| Run pilot on representative clusters and remediate gaps (confirm mechanisms active on all in-scope hosts; address configuration drift and any incompatibilities) | Operations Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 208h  
**Total Estimated Cost:** £21,000

###### Actions Required for Compliance

- [ ] Choose and document the exact hardware-based separation method(s) (using the vendor’s feature names) that are used to enforce process isolation on the computing platform.
- [ ] Update the system security plan and the overall system design to clearly define the separation boundaries between components, and to specify the enforcement layer that will control access and protections at the host level (host firmware and hypervisor).
- [ ] Set up the selected hardware separation settings in the basic input/output system (BIOS), unified extensible firmware interface (UEFI), firmware, and hypervisor configuration for all in-scope hosts and clusters.
- [ ] Create and keep a version-controlled record of the configuration baseline, including the expected hardware separation setting values.
- [ ] Set up automated evidence collection to export live host and hypervisor configuration outputs that list the enabled hardware isolation features.
- [ ] Carry out independent checks to confirm the mechanism is switched on and that separation boundaries are being enforced, and keep the independent verification and validation (IV&V) report.
- [ ] Keep supplier and manufacturer documentation that clearly confirms the selected mechanism(s) and explains how they are enabled.


---

#### SC-39.2 — Separate Execution Domain Per Thread (Enhancement)

This requirement is about ensuring that when your system handles **Confidential** and **Secret** work at the same time, each processing thread runs in its own separate and protected working environment. This prevents threads from accidentally using the same working area. Without this separation, one thread could affect another—potentially mixing data, exposing sensitive information, or producing unreliable results, particularly when different confidentiality levels are handled simultaneously.

To meet this expectation, the organisation must:
- clearly define and document how per-thread separation is achieved for multi-threaded processing of **Confidential** and **Secret** work;
- keep an up-to-date list of the separate working environments used per thread; and
- record the specific system settings that enforce this separation.

The organisation must also keep design and supplier/developer evidence that supports this approach, include it in the system’s security plan, and provide independent test evidence showing that each thread genuinely runs in its own separate environment for both **Confidential** and **Secret** workloads.

##### Enforce per-thread execution domains via process-per-worker isolation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Identify logical thread roles for Confidential/Secret multi-threaded processing and produce a thread-to-worker mapping specification (including dynamic instantiation rules) | Software Lead | Department | 24h | — |
| Refactor/implement process-per-logical-thread supervisor/dispatcher to spawn one OS process/container per worker role; remove shared in-process execution for those roles | Software Lead | Department | 80h | — |
| Define and implement strict IPC/message-passing contracts between supervisor and workers (schemas, validation, allow-listed endpoints, error handling) | Architect | Department | 48h | — |
| Implement OS/container confinement profiles per worker (namespaces/cgroups, MAC policy, seccomp syscall allow-lists) and least-privilege service identities where feasible | Security Engineer | Enterprise | 72h | £6,000 |
| Configure filesystem/network/memory isolation defaults for workers (no shared writable paths; explicit mounts; per-worker temp/log directories; IPC-only data flows) | Platform Engineer | Enterprise | 40h | — |
| Create auditable evidence pack: inventory (thread role → worker identity → IPC endpoints → confinement profile), retain configuration artefacts, and link to architecture/design documentation | Compliance Manager | Enterprise | 32h | — |
| Update System Security Plan to reference SC-39(2) implementation and enforcement evidence; run independent verification tests demonstrating concurrent Confidential/Secret processing with no cross-thread mixing | Compliance Manager | Enterprise | 56h | £2,500 |
| Operationalise and validate in CI/CD and staging (automated checks for worker identity separation, IPC contract validation, and confinement profile presence) | DevOps Lead | Business Unit | 40h | £3,000 |

**Total Estimated Effort:** 392h  
**Total Estimated Cost:** £11,500

###### Actions Required for Compliance

- [ ] Identify all logical thread roles used for the “Confidential” and “Secret” workload paths, and define the intended mapping between each thread role and its domain.
- [ ] Change the runtime so that each logical “thread role” runs in its own dedicated worker process (or an equivalent execution unit), instead of sharing the same in-process threads.
- [ ] Set up strict inter-process communication (IPC) and message passing, with checks that incoming messages match the expected format (schema validation). Also remove or disable any shared writable memory and prevent workers from writing to the default shared filesystem.
- [ ] Apply per-worker operating system and container confinement (using process and resource isolation plus mandatory access controls and system-call filtering) and enforce least-privilege permissions for each worker.
- [ ] Create and keep an auditable record that maps each logical thread role to the worker’s identity, its confinement profile, and its inter-process communication (IPC) endpoints.
- [ ] Update the system security plan to include the per-thread execution domain design, the configuration settings, and where the supporting evidence is stored.
- [ ] Run independent, simultaneous tests for **Confidential** and **Secret** information, and collect evidence that each thread’s role runs in its own separate execution area and that data cannot be mixed between threads.


---

### SC-40 — Wireless Link Protection (Control)

This requirement is about keeping your Wi‑Fi, mobile and Bluetooth connections safe from people who try to interfere with the radio signals or pretend to be something they are not. Without this, an attacker could disrupt service (for example by jamming or forcing devices off the network), trick devices into connecting to unauthorised networks, reuse old messages to impersonate users, or listen in to capture sensitive information—especially for connections that can be seen from outside your controlled sites.

To meet this expectation, the organisation must keep an up-to-date, approved list of every wireless connection it uses, both external and internal. It must clearly separate which connections can be accessed from outside and which are only available inside controlled facilities and operational areas, and document which types of signal attacks it needs to defend against. It must also have written procedures and assigned responsibilities for putting these protections in place and keeping them working, document the wireless design and the configuration settings used, include this approach in its security planning and policies, and keep audit records showing the protections are working and that wireless incidents are investigated and handled appropriately.

##### Wireless link protections via per-link security baselines

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce in-scope wireless link inventory (external/internal) and map each link to required SC-40 attack coverage (jamming, rogue AP, deauth/disassoc, spoofing, replay, interception) | Compliance Manager | Enterprise | 24h | — |
| Define per-technology wireless security baselines (Wi‑Fi WPA2/WPA3-Enterprise + 802.1X, cipher/protected management frame requirements, replay protection settings, rogue AP detection/containment, deauth/disassoc resilience settings, Bluetooth pairing/bonding restrictions, cellular SIM/eSIM/APN controls and session-layer protection requirements) | System Design Authority | Enterprise | 40h | — |
| Implement baseline enforcement via central management (WLAN controller/Wi‑Fi policy, MDM/UEM for client Bluetooth settings, cellular router/modem configuration management, SSID/VLAN mapping controls) across production and non-production environments | Infrastructure Lead | Enterprise | 56h | £18,000 |
| Configure wireless event telemetry and forwarding to SIEM/SOC (rogue AP alerts, auth failures, deauth/disassoc anomalies, pairing/bonding denials, cellular security-relevant events where available) with correlation rules for SC-40 | Security Engineer | Enterprise | 32h | £6,000 |
| Build configuration compliance checks and drift detection (template versioning, automated validation against baselines, alerting on drift, evidence capture per in-scope link) | DevOps Lead | Enterprise | 40h | £12,000 |
| Establish operational runbooks and incident workflows for wireless signal parameter attacks (triage, containment actions, reconfiguration/rollback, evidence handling, escalation paths) | Service Delivery Manager | Enterprise | 24h | — |
| Execute baseline rollout, remediation, and audit readiness (gap remediation sprints, change control records, test evidence pack per environment/link) | Project Manager | Enterprise | 32h | £4,000 |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £40,000

###### Actions Required for Compliance

- [ ] Build and maintain an auditable record of all in-scope external and internal Wi‑Fi, cellular, and Bluetooth connections, and label each one as either external or internal.
- [ ] Define and publish wireless security baseline standards for each technology. These standards must clearly cover the required attack types: jamming, spoofing, replay attacks, rogue access points, deauthentication/disassociation attacks, and interception.
- [ ] Set up the organisation’s Wi‑Fi networks (both external and internal) to require enterprise authentication (for example, Wi‑Fi Protected Access 2 Enterprise (WPA2‑Enterprise) or Wi‑Fi Protected Access 3 Enterprise (WPA3‑Enterprise)) and turn off insecure or older connection modes.
- [ ] Set up and test detection and alerts for unauthorised “rogue” Wi‑Fi access points connected to external networks, and configure containment and response steps where the system supports them.
- [ ] Make Bluetooth more secure by allowing pairing and bonding only with managed and authorised devices, and by requiring encryption at the connection level for any bonded connections.
- [ ] Set up cellular edge devices (routers and modems) so they can only access approved network services (using restricted APN settings), and ensure that application and session data is encrypted in transit (for example, using Transport Layer Security (TLS)) to reduce the risk of interception and replay attacks.
- [ ] Set up checks to detect changes (configuration drift) in the wireless network baseline, and send wireless security alerts to the security information and event management (SIEM) system and security operations centre (SOC) for monitoring and investigation.


---

#### SC-40.1 — Electromagnetic Interference (Enhancement)

This requirement is about keeping your anti-jamming wireless links working even if someone deliberately tries to disrupt them by transmitting interfering radio signals. If you do not use strong, carefully selected protection, an attacker could work out how your anti-jamming behaviour works, predict it, and then interfere in a way that blocks or reduces the quality of communications.

To meet this requirement, the organisation must first identify which wireless links are meant to resist jamming. It must then apply high-assurance cryptographic protections to those specific links, so that unauthorised people cannot predict the anti-jamming behaviour. The organisation must also make sure these protections are actually enabled for the wireless link behaviour, rather than left as a general setting that may not be applied.

This approach must be documented in the wireless link protection procedures and system design. The documentation must include clear diagrams, recorded configuration details, and architecture details, and it must name the staff responsible for implementing, maintaining, and approving the protected links.

Finally, the organisation must keep audit evidence that the protections remain enabled and working as intended. This includes evidence that unauthorised attempts cannot join the protected communications or make sense of them.

##### High-assurance crypto for anti-jam spread-spectrum links

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define in-scope anti-jam spread-spectrum links/endpoints and anti-jam cryptographic behaviour requirements (hopping/pattern selection, timing/parameters, enablement conditions, mutual authentication strength, key lifetimes) | Compliance Manager | Enterprise | 16h | — |
| Select and document high-assurance cryptographic mechanisms for anti-jam waveform behaviour (algorithm/key sizes, anti-jam mode design, mutual authentication model, downgrade resistance requirements) mapped to SC-40(1) enhancement | System Design Authority | Enterprise | 24h | — |
| Design radio/wireless stack integration for cryptographically keyed anti-jam mode enablement (join/synchronisation flow, failure modes, anti-downgrade enforcement, interoperability constraints) | Security Engineer | Department | 32h | — |
| Implement key management integration for anti-jam waveform keys (secure storage, authenticated distribution to authorised endpoints, rotation schedule, rekey event identifiers, access controls) | Platform Engineer | Enterprise | 40h | £18,000 |
| Configure auditable/tamper-evident configuration baselines and change control controls for anti-jam cryptographic parameters (immutable settings where supported, policy enforcement, configuration drift detection hooks) | Operations Lead | Enterprise | 24h | £6,000 |
| Implement device/system audit logging and SIEM forwarding for anti-jam crypto mode status, join/auth outcomes, key identifiers, and rekey events (including log schema, retention alignment, alerting thresholds) | Cyber Security Lead | Enterprise | 24h | £10,000 |
| Execute operational verification and acceptance testing (authorised vs unauthorised join/synchronisation attempts, predictability resistance tests, intentional interference resilience checks, evidence pack for audit) | Quality Assurance Lead | Department | 40h | £12,000 |

Total Estimated Effort: **200h**  
Total Estimated Cost: **£46,000**

###### Actions Required for Compliance

- [ ] Identify and record all in-scope wireless spread-spectrum anti-jamming connections and devices, including the anti-jamming mode and settings.
- [ ] Set the organisation’s “high assurance” encryption requirements for anti-jam waveform behaviour, and link them to the approved encryption methods, key lengths, and time periods for using keys.
- [ ] Set up radios and wireless systems so that frequency-hopping and pattern selection, and the generation of anti-jamming signals, are protected with cryptographic keys and require mutual authentication between devices for synchronisation.
- [ ] Integrate anti-jamming waveform keys with the organisation’s key management system and secure key storage, ensuring keys are shared only after successful authentication and are rotated on a planned schedule.
- [ ] Set standard security settings and use a formal change control process to prevent downgrades of anti-jam cryptographic protection, including only making changes that are signed off and approved.
- [ ] Turn on and centralise audit logs for anti-jamming crypto mode status, key identifiers, rekey events, and join and authentication outcomes, and send them to security information and event management (SIEM).
- [ ] Run acceptance tests to show that unauthorised devices cannot predict or synchronise to the anti-jamming signal, and that anti-jamming stays enabled after configuration changes.


---

#### SC-40.2 — Reduce Detection Potential (Enhancement)

This requirement is about making certain important wireless messages much harder for outsiders to notice, recognise, or figure out—especially for mission-critical covert links where avoiding detection and preventing location tracking are essential. Without strong protections, unauthorised people could intercept the transmissions, work out which devices are communicating, and use patterns to track or disrupt operations.

To meet this, the organisation must first clearly identify which wireless links are classed as high risk (mission-critical covert and anti-geo-location wireless links). It must then document the encryption and other cryptographic protections it will use to reduce the chance of detection, and ensure those protections are turned on for every such link on both sides of the communication path.

The organisation must also avoid predictable transmission behaviour by not using default or easily guessed settings. It must have a written approach for how encryption keys are handled, limit who is allowed to change it, and keep records showing that the protections remain enabled over time. These records should include the design, network locations, configuration settings, and evidence such as dated configuration snapshots and authorised change records.

##### End-to-end crypto for high covert/anti-geo wireless links

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce and approve the “high (mission-critical covert and anti-geo-location) wireless link” inventory model (CMDB fields, tagging rules, and evidence requirements) | Compliance Manager | Enterprise | 16h | — |
| Build/maintain the protected wireless link set and validate completeness against network diagrams, controller/AP/mesh/relay inventories, and change history | Project Manager | Enterprise | 24h | — |
| Select and document an approved wireless cryptographic protection profile (confidentiality + strong authentication; anti-identification features where supported) mapped to SC-40(2) “level of reduction” | System Design Authority | Enterprise | 24h | — |
| Implement end-to-end cryptographic enablement on all tagged high links (controller/AP/mesh/point-to-point radio configuration, bridging/relay path coverage, and verification on both ends) | Security Engineer | Department | 40h | — |
| Implement non-default, non-predictable keying: per-link/per-session credentials where feasible, disable insecure defaults, configure key rotation and revocation workflows, and integrate with enterprise PKI/IAM | IAM/PKI Administrator | Enterprise | 32h | £12,000 |
| Create configuration-as-evidence pipeline: generate dated exports/snapshots of wireless crypto settings per high link, bind to authorised change records, and store for audit retention | Operations Lead | Enterprise | 24h | — |
| Perform assurance testing and audit readiness: test for detection/identification predictability risks, confirm cryptographic settings remain enabled (drift checks), and produce an SC-40(2) evidence pack per link set | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 184h  
**Total Estimated Cost:** £12,000

###### Actions Required for Compliance

- [ ] Tag and record all “high (mission-critical covert and anti–geo-location)” wireless links in the configuration management database (CMDB) and in the network diagrams.
- [ ] Define and get approval for a wireless encryption protection profile that matches the “level of reduction” requirement in sc-40.02_odp.
- [ ] Set up the wireless network and connected devices so that encryption is enabled from start to finish for every tagged “high” connection.
- [ ] Use unique, non-default login details for each wireless link and each session, and follow the documented process to regularly change (rotate) and cancel (revoke) the wireless encryption keys.
- [ ] Implement configuration-as-evidence by exporting dated wireless security settings and linking them to authorised change records.
- [ ] Carry out regular compliance checks to spot changes from the approved settings (for example, disabled or outdated cryptography options) and fix them through the organisation’s change-management process.


---

#### SC-40.3 — Imitative or Manipulative Communications Deception (Enhancement)

This requirement is about preventing fake wireless messages from being accepted as genuine. Without it, someone could copy the usual wireless “signals” and trick your systems into treating their device or message as trusted. This could result in unauthorised access or harmful actions.

To meet this expectation, the organisation must use security codes for wireless connections. Each incoming wireless message must be checked against these codes, and any deliberate attempts to imitate or interfere with trusted wireless communications must be rejected and not acted upon.

The organisation must also ensure that the verification information cannot be easily guessed by outsiders, keep clear records explaining how the wireless protection is designed and which wireless connections it covers, and document the configuration settings that put it in place. In addition, it must keep audit records showing when rejected attempts occur because the security code checks failed, and include this approach in its system security planning.

##### Cryptographically authenticate wireless links and reject failed frames

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Wireless security standardisation: configure in-scope SSIDs/radios to WPA3-Enterprise (fallback WPA2-Enterprise) with 802.1X; disable open/shared-key/PSK modes; produce configuration baseline | Infrastructure Lead | Enterprise | 40h | £— |
| 802.1X/EAP integration design and implementation: configure RADIUS/EAP-TLS (or equivalent strong EAP), certificate trust chains, and per-user/per-device authentication flows | System Design Authority | Enterprise | 48h | £— |
| Enforce cryptographic gating and rejection behaviour: ensure controllers/APs drop traffic on failed authentication/handshake/session establishment; verify application/system acceptance logic is not based on radio/signal characteristics | Security Engineer | Enterprise | 32h | £— |
| IAM credential lifecycle: implement per-user/per-device certificate issuance, revocation on offboarding, and periodic rotation schedule; update operational runbooks | Data Protection Officer | Enterprise | 40h | £— |
| SIEM audit evidence and alerting: export AP/controller 802.1X/EAP failures and rejection events; create dashboards and alerts for repeated failed authentications by unauthorised identifiers | Operations Lead | Enterprise | 24h | £— |
| Coverage and audit pack: document SSID/radio/link coverage, cryptographic mechanisms used, disabled insecure modes evidence, and produce an audit-ready evidence pack | Compliance Manager | Enterprise | 16h | £— |
| Validation and assurance testing: test positive/negative cases (valid credentials accepted; imitative/manipulative attempts rejected), capture evidence, and complete sign-off against acceptance criteria | Quality Assurance Lead | Enterprise | 24h | £— |

**Total Estimated Effort:** 244h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] List all in-scope wireless connections (service set identifiers (SSIDs) and radios) and link each one to its trust zone and the systems it connects to.
- [ ] For in-scope networks, turn off open Wi-Fi and shared-key or pre-shared key (PSK) Wi-Fi modes. Require Wi-Fi protected access 3 (WPA3) Enterprise or Wi-Fi protected access 2 (WPA2) Enterprise using 802.1X.
- [ ] Set up access point (AP) and controller rules so network traffic is allowed only after a successful cryptographic authentication and the creation of a secure session key.
- [ ] Set up IEEE 802.1X with the organisation’s identity provider (IdP) and remote authentication dial-in user service (RADIUS) using credentials for each user and each device (for example, certificate-based extensible authentication protocol transport layer security (EAP-TLS)), and make sure access is revoked when someone leaves the organisation.
- [ ] Turn on and send wireless authentication and handshake failure logs, and session rejection logs, to the security information and event management (SIEM) system, including enough identifying details to link each event to the responsible user or device.
- [ ] Create and keep an auditable record of the agreed configuration baseline and coverage for the wireless cryptographic mechanisms used.


---

#### SC-40.4 — Signal Parameter Identification (Enhancement)

This requirement is about preventing outsiders from singling out and tracking the specific radio transmitters used for classified and confidential Department of Defense (DoD) communications. It does this by stopping people from copying each transmitter’s unique “signal fingerprint”.

Without this protection, someone could listen to the radio traffic, measure distinctive features of the signal, and reliably work out which transmitter is being used. This could enable intelligence gathering, tracking, or identifying the mission and users.

To meet this expectation, the organisation must:
- clearly define which wireless transmitters are covered by the protection;
- keep up to date diagrams showing where the protection is applied; and
- ensure the system uses cryptographic protections that deliberately change or hide transmitter signal settings, so unauthorised people cannot predict the resulting behaviour, while still allowing anonymity when it is needed.

The organisation must also:
- document how the protection works;
- record the system design and configuration details that implement it; and
- keep evidence that the settings are enabled and consistent for all covered links.

Only authorised personnel may make changes. There must be audit and change records, and testing must show that repeated observations do not produce a consistent, reliable way to identify the transmitter.

##### Cryptographic anti-fingerprinting for in-scope wireless transmitters

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Create authoritative inventory of in-scope wireless transmitters/links (sc-40.04_odp) and produce/refresh network diagrams mapping each transmitter to its controller-managed radio endpoint | Project Manager | Enterprise | 24h | — |
| Select approved cryptographic link-layer modes/cipher suites and define per-session/per-packet variability requirements based on supported wireless technology (e.g., WPA3-Enterprise, strong cipher suites, vendor secure features) | Security Architect | Enterprise | 32h | — |
| Implement configuration changes for all in-scope links across environments (dev/test/prod as applicable), including key establishment, rotation/rekey intervals, and enforcement of non-predictable observable behaviour | Wireless/Network Engineering Lead | Department | 56h | — |
| Build configuration baselines and policy-as-code (where supported) to lock anti-fingerprinting settings, restrict changes to authorised administrators, and integrate with change control/audit logging | Compliance Manager | Enterprise | 40h | — |
| Develop controlled capture testing plan and test cases (threat model, repeatability criteria, measurement approach, pass/fail thresholds) and obtain authorisations for test activity | Quality Assurance Lead | Enterprise | 24h | — |
| Execute controlled capture testing using spectrum/radio capture tooling and produce evidence showing that repeated observations do not yield consistent reliable identification without cryptographic secrets | Test/Validation Engineer | Department | 40h | £18,000 |
| Produce compliance evidence pack: configuration exports/snapshots, baseline enforcement proof, key/rekey configuration evidence, and test results mapped to SC-40(4) enhancement requirements | Data Protection Officer | Enterprise | 24h | — |

**Total Estimated Effort:** 240h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Create and keep up to date an official list of all wireless transmitters and links that are in scope for sc-40.04_odp, and match each item to the current network diagrams.
- [ ] Set up every in-scope wireless connection to use approved secure wireless settings, using strong encryption and cryptographic integrity checks.
- [ ] Set and enforce the key creation and key rekeying/rotation rules so that session-based signal settings are not kept the same over time.
- [ ] Implement configuration baselines (policy-as-code where feasible) to lock cryptographic anti-fingerprinting settings for all in-scope connections.
- [ ] Allow only authorised administrators to change wireless controller or radio encryption settings, and record (log) all such changes.
- [ ] Run controlled radio recording tests to show that repeated observations do not allow consistent identification of the transmitter without the required cryptographic secrets.
- [ ] Document the encryption method, the configuration details, and the test results that prove consistent anti-fingerprinting behaviour across all in-scope links.


---

### SC-41 — Port and I/O Device Access (Control)

This requirement is about preventing people from using certain plug-in connections and disc drives to move data into or out of important computers. If Universal Serial Bus (USB), Thunderbolt, Firewire (Institute of Electrical and Electronics Engineers 1394 (IEEE 1394)) ports, or CD/DVD drives are left available, someone could copy confidential information off a system or install harmful software by plugging in a device or using a disc.

To meet this requirement, the organisation must keep a documented, up-to-date list of:
- which ports and disc drives must be physically disabled or removed, and  
- which systems are covered.

This includes workstations, servers, engineering workstations, and operational technology (OT) control system gateways.

For every covered system, the organisation must physically block or remove these ports and disc drives (not just rely on software settings). It must also document how the blocking or removal is done, and keep procedures and records showing that the setup matches the actual hardware. Responsibility must be assigned to the people who install and maintain systems. The organisation must be able to prove compliance through inspections and records, including after any maintenance or hardware changes.

##### Physically block USB/Thunderbolt/Firewire and disable CD/DVD on in-scope hosts

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Create authoritative inventory of in-scope hosts (workstations, servers, engineering workstations, OT control system gateways) including asset IDs, locations, and ownership | Compliance Manager | Enterprise | 24h | — |
| Create authoritative inventory of in-scope physical ports/devices to be disabled/removed (USB, Thunderbolt, Firewire/IEEE 1394, CD/DVD drives) mapped to host models and expected hardware variants | Compliance Manager | Enterprise | 24h | — |
| Define standard physical hardening mechanisms and acceptance method (port blockers/covers vs port hardware disable/removal; optical drive removal vs bay lock) including docking station/external hub handling rules | System Design Authority | Enterprise | 16h | — |
| Procure standard hardening kits and consumables (tamper-evident USB/Thunderbolt/Firewire port blockers/covers; optical drive removal/lock components; labels/checklists) sized for initial rollout | Infrastructure Lead | Enterprise | 8h | £18,000 |
| Implement hardening during imaging/deployment and after hardware replacements (install/verify blockers; remove/disable/lock CD/DVD drives) for all in-scope hosts | Operations Lead | Enterprise | 56h | £2,500 |
| Update maintenance/change control and work-order workflow to require mandatory SC-41 physical verification step before closure (including technician checklist and approver sign-off) | Project Manager | Enterprise | 20h | — |
| Produce audit-ready evidence pack (per-host checklist, method used, completion dates, and photo evidence where practical) and run an initial compliance validation sampling exercise | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 172h  
**Total Estimated Cost:** £20,500

###### Actions Required for Compliance

- [ ] Create and get approval for an official, authoritative list of all in-scope systems and components (workstations, servers, engineering workstations, and operational technology (OT) control system gateways).
- [ ] Publish an approved list of ports and devices that must be physically disabled or removed, including USB, Thunderbolt, Firewire (IEEE 1394), and CD/DVD drives.
- [ ] Choose and standardise the physical ways to prevent unauthorised access to ports, such as using tamper-evident port blockers or covers, or removing port hardware; and for optical drives, either remove the drive or lock and disable the drive bay.
- [ ] Apply the physical security hardening to all in-scope systems and record the exact method used for each device.
- [ ] Update maintenance and repair work orders to require mandatory SC-41 physical checks and supporting evidence to be recorded before final sign-off.
- [ ] Carry out periodic inspection sampling and compare the results against the SC-41 checklists and photos for each device.


---

### SC-42 — Sensor Capability and Data (Control)

This requirement is about preventing phones and tablets from being used to secretly listen, watch, or track people in sensitive rooms. It also ensures that when sensors are used for a legitimate purpose, the right staff can clearly see that this is happening.

Without these safeguards, someone could remotely turn on features such as location tracking, microphones, cameras, or motion sensors in areas used for classified information storage and secure communications. This could enable covert surveillance and cause serious harm to privacy and security.

The organisation must block remote activation of these sensing features in those areas, except for authorised testing, incident response, or accessibility needs—where there is documented approval and the action is recorded for audit purposes.

Where sensor use is allowed, the device must display a clear, explicit indicator to authorised personnel who need access to mobile device sensors for mission or security purposes. This indicator must not be visible to non-authorised staff.

##### MDM geofenced sensor lockdown with auditable exception workflow

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm MDM capabilities and design the sensor lockdown model (GPS/location, camera, microphone, accelerometer) including remote activation denial logic and failure modes | System Design Authority | Enterprise | 16h | — |
| Define and publish the authoritative restricted-zone mapping (geofence IDs / facility location signals) and align it with MDM zone identifiers and device location sources | Compliance Manager | Enterprise | 12h | — |
| Configure MDM policy enforcement for restricted zones: deny remote enablement of specified sensors when device is inside restricted zones; validate behaviour in test and pilot devices | Mobile/Endpoint Security Lead | Enterprise | 24h | — |
| Implement time-bounded, device-specific exception workflow (request/approval) with required fields (reason, device identity, sensor types, start/end time) and enforce “authorised personnel” requester/approver roles | IAM/Identity Team | Enterprise | 28h | — |
| Configure audit logging for all activation attempts and exception lifecycle events (initiator, approver, device, sensor types, restricted zone, timestamps, request/approval IDs, outcome) and ensure logs are forwarded to SIEM with retention tags | Security Engineer | Enterprise | 20h | £6,000 |
| Implement explicit sensor-in-use indication during approved exceptions (OS-native indicator where available plus an enterprise overlay/notification for authorised personnel) and test for unambiguous visibility and correct scoping | Operations Lead | Enterprise | 18h | — |
| Execute end-to-end testing, pilot rollout, and audit evidence pack creation (test scripts, screenshots/log extracts, approval records, SIEM query examples) | Quality Assurance Lead | Enterprise | 20h | — |

Total Estimated Effort: **138h**  
Total Estimated Cost: **£6,000**

###### Actions Required for Compliance

- [ ] Map each classified storage area and secure communications room to the official zone identifiers used by the mobile device management (MDM) system and location services.
- [ ] Set up mobile device management (MDM) rules to block remote activation of GPS/location, the camera, the microphone, and the accelerometer when devices are in restricted areas.
- [ ] Set up an approval process for authorised exceptions that requires a written reason, the device and sensor types involved, and the start and end times.
- [ ] Limit exception requests and approvals to the approved group of authorised staff by using enterprise identity and access management (IAM) and strong authentication.
- [ ] Connect mobile device management (MDM) and automation logs to the security information and event management (SIEM) system to record who initiated and approved actions, which device was used, what sensor types were involved, the zone, the date and time, and whether each activation succeeded or failed.
- [ ] Check that any approved exceptions produce clear “sensor in use” warnings that authorised staff can see, and that unauthorised users are not given misleading access information.


---

#### SC-42.1 — Reporting to Authorized Individuals or Roles (Enhancement)

This requirement is about ensuring that any information collected by your network intrusion detection sensors and endpoint telemetry agents is sent only to the correct people within your organisation, and never to unauthorised people or to other organisations. Without this, sensitive monitoring information could be sent to the wrong place, shared by mistake, or forwarded to the wrong systems. That could expose confidential information, personal data, or internal security weaknesses, and could also damage or undermine investigations.

To meet this expectation, the organisation must set up the sensors so that where they send information is restricted at the moment the data is sent. This should be done using an explicit list of approved recipients, and by blocking any destinations that are not approved, including backups. The organisation must also ensure that even when authorised staff trigger or activate the sensors, the information produced still follows the same approved sending routes.

Finally, the organisation should document the reporting settings and keep evidence that they are in place. It should be able to show, using records, that reporting was sent only to authorised roles and approved destinations, including where personal data is involved.

##### Allow-list sensor reporting destinations with enforced RBAC

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authorised reporting allow-list (collector FQDN/IP/ports) and map each destination to permitted roles (including DR environment) | Compliance Manager | Enterprise | 16h | — |
| Produce technical enforcement design for agent/forwarder destination restriction (disable dynamic discovery, fallback, backup endpoints; define block/allow behaviour) | System Design Authority | Enterprise | 24h | — |
| Configure and validate sensor/agent forwarding allow-list enforcement across environments (prod/test/DR), including negative testing for non-approved destinations | Security Engineer | Enterprise | 40h | — |
| Implement identity-bound forwarding: provision dedicated workload/service identities for sensors/agents and configure mTLS/workload identity; ensure collector rejects unauthorised identities | Platform Engineer | Enterprise | 32h | £8,000 |
| Configure SIEM/log platform RBAC/ABAC for ingested datasets: restrict view/query and explicitly block export/reporting paths (API tokens, scheduled reports, CSV/PDF, email/webhook) to authorised roles only | Security Engineer | Enterprise | 28h | — |
| Constrain downstream routing/integrations (pipelines, stream processors, SOAR/webhooks, data lake ingestion, backup copies) to the same allow-list and authorised roles; verify no alternate egress path exists | Operations Lead | Enterprise | 24h | — |
| Implement audit-ready evidence: retain configuration snapshots and enable/verify audit logging for forwarding decisions and access/export actions; produce evidence pack for SC-42(1) | Data Protection Officer | Enterprise | 20h | — |

**Total Estimated Effort:** 204h  
**Total Estimated Cost:** £8,000

###### Actions Required for Compliance

- [ ] Define an authorised list of where sensor reports are allowed to be sent (one primary destination and approved secondary destinations), and link each destination to the authorised roles that can use it.
- [ ] Set up each network intrusion detection system (IDS) sensor and each endpoint telemetry agent to send data only to the approved (allow-listed) collector fully qualified domain name (FQDN) or IP addresses, and only on the approved ports.
- [ ] Turn off dynamic endpoint discovery, automatic fallback, and any backup or secondary reporting routes that are not approved in the agent/forwarder settings.
- [ ] Set up data collection so that incoming data is authenticated using identity-bound credentials from dedicated service or workload identities, with the minimum necessary permissions (least privilege).
- [ ] Set up role-based access control (RBAC) and attribute-based access control (ABAC) on the receiving security information and event management (SIEM) and log platform, so that only authorised roles can view, search, and export the ingested datasets.
- [ ] Limit export and reporting options (application programming interface (API) tokens, scheduled reports, downloads, webhooks and emails) to authorised roles and approved destinations.
- [ ] Collect and keep evidence: saved snapshots of the agent/forwarder configuration, plus audit logs showing forwarding activity and any authorised access or data export actions.


---

#### SC-42.2 — Authorized Use (Enhancement)

This requirement is about making sure any information collected by your sensors is used only for the specific, approved purposes your organisation intends. Without this, sensitive information such as location or other observations could be misused to monitor people for the wrong reasons, or shared with outsiders who then use it in ways you never agreed to.

To meet this expectation, the organisation must:
- Clearly define and document what each type of sensor data may be used for.
- Publish an authorised-use policy that staff can follow.
- Restrict access so only people whose job role matches an approved purpose can view or use the data.

Relevant staff must complete mandatory annual training on authorised use, including examples of how misuse can happen and the consequences.

Where sensor data is shared with contractors, or stored or maintained by external parties, the organisation must include contractual terms that limit their use to authorised purposes only and require them to follow your rules.

##### Purpose-tagged sensor data access with RBAC enforcement

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce sensor data inventory and purpose taxonomy (dataset/feed catalogue, purpose tags, data lineage pointers, and mapping to SC-42 authorised purposes) | Compliance Manager | Enterprise | 40h | — |
| Define role-to-purpose mapping model (RBAC/ABAC policy specification, including default deny, action types: view/export/API/query, and exception handling rules) | System Design Authority | Enterprise | 32h | — |
| Implement purpose-tag propagation into the data access path (ensure purpose tags are carried from dataset metadata through API/data-layer queries and export pipelines) | Software Lead | Enterprise | 56h | — |
| Build and integrate purpose-based authorisation enforcement (policy-as-code/configuration, enforcement at UI/API/data-layer, deny-by-default for bulk export and direct data retrieval) | Security Engineer | Enterprise | 64h | — |
| Integrate with enterprise IdP and access lifecycle (SSO auth, joiner/mover/leaver automation, role assignment sync, and immediate revocation for unauthorised purposes) | IAM/Platform Engineer | Enterprise | 48h | — |
| Implement auditable decision logging and SIEM integration (log schema for allow/deny, user, dataset, purpose tag, action type, reason codes; retention and evidence export) | Operations Lead | Enterprise | 40h | £3,000 |
| Add training-completion gating for sensitive purposes (design, configuration, and enforcement hook for high-risk purpose tags; evidence of completion checks) | Compliance Manager | Enterprise | 24h | — |

| Total Estimated Effort |  |  | **304h** |  |
| Total Estimated Cost |  |  |  | **£3,000** |

###### Actions Required for Compliance

- [ ] List each sensor data set or feed and assign a clear, authorised purpose that matches **SC-42.02 ODP**.
- [ ] Define and get approval for which purposes each user and service role is allowed to access for sensor data.
- [ ] Implement purpose-based role-based access control (RBAC) and attribute-based access control (ABAC) for every way users can access data, including the user interface (UI), application programming interface (API), data exports, and data queries.
- [ ] Integrate enforcement with the central identity provider (IdP) and single sign-on (SSO), and automate updates to user roles when people join, move roles, or leave the organisation.
- [ ] Set up audit logs for decisions to allow or deny access, including the dataset or purpose and the type of action, and keep the logs for later review.
- [ ] Use test cases to confirm that access for unauthorised purposes (including bulk export and application programming interface (API) retrieval) is blocked.


---

#### SC-42.4 — Notice of Collection (Enhancement)

This requirement is about making sure people are told clearly when the organisation is collecting information about them, so they can make informed choices and protect their privacy. Without clear notices, people may not realise that network monitoring, tracking computer activity, or closed-circuit television (CCTV) and door-access systems are capturing personal information. This could lead to unexpected outcomes, complaints, misuse of trust, and legal or reputational harm.

To meet this requirement, the organisation must:
- show privacy notice banners on the login page and on web portals
- place clear signs at the locations where sensors are used (including CCTV and door-access areas)
- show in-app prompts

The wording must explicitly cover all three types of sensors. The notices must be easy to see, readable, and understandable at the point where people would reasonably notice them.

The organisation should also:
- document what it uses
- keep evidence that the notices are delivered
- ensure system and privacy policies and system settings match the notices
- assign clear responsibility to the people who implement, configure, and maintain these measures

##### Identity and app notice banners for PII collection by defined sensors

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define controlled notice content model (single source of truth) including sensor categories from **sc-42.04_odp.02** and measures alignment from **sc-42.04_odp.01**; produce versioned notice text and data-collection purpose summary | Privacy Engineering Lead | Enterprise | 24h | — |
| Implement IdP login-flow banner using the controlled notice content (pre-auth notice) with configurable notice versioning and sensor-category rendering | Identity & Access Management Lead | Enterprise | 32h | — |
| Build shared web portal banner component (or portal middleware) to render the same controlled notice content across landing/authenticated pages; include feature flags for relevant portal areas | Platform Engineer | Department | 24h | — |
| Add in-app prompts at the middleware/API gateway layer for sensor-supported features; implement mapping from application features to sensor categories and ensure prompts reference the defined sensor categories | Software Lead | Department | 32h | — |
| Implement deployment-time completeness validation (policy-as-code/config validation) to block releases if any sensor category from **sc-42.04_odp.02** is missing from the controlled notice content | DevOps Lead | Enterprise | 24h | — |
| Implement audit evidence logging for banner/prompt render events and (where enabled) user acknowledgement events, including timestamps, user/session identifiers, and notice version; ensure logs are retained per policy | Security Engineer | Enterprise | 24h | — |
| Validate end-to-end alignment with actual sensor scope and integration points (test plan, evidence pack, and sign-off) across representative environments (dev/test/prod) | Compliance Manager | Enterprise | 16h | — |

Total Estimated Effort: **196h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Create a controlled notice content structure that clearly includes every sensor type covered in **SC-42.04 ODP.02**.
- [ ] Set up the organisation’s identity provider (IdP) so the login banner shows the approved notice content, using version control.
- [ ] Implement a shared web portal banner that displays the same controlled notice content.
- [ ] Add in-app prompts through application middleware and the application programming interface (API) gateway for features that depend on the defined sensors.
- [ ] Add a check at release time to stop deployments if the notice text does not include every required sensor category.
- [ ] Enable audit logging for banner and prompt display events, and for the notice version (and acknowledgement events if they are used).


---

#### SC-42.5 — Collection Minimization (Enhancement)

This requirement is about collecting the smallest amount of personal information possible when using video analytics, so people are not identified more than necessary. Without this, a system could capture and store more detail than required, such as clear faces or other identifying features. It could also record sound when it should not, which could cause privacy harm and increase the risk that internal rules are applied incorrectly.

To meet this expectation, the organisation must set up its video analytics to blur or pixelate faces and use privacy masks that hide human features. It must also keep audio recording turned off by default, and only allow audio when there is explicit authorisation.

The organisation must be able to check what the sensors collect. It must keep clear records of what information is collected, including whether audio is on or off. It must document how the settings that reduce data are implemented and how they are intended to lower privacy risk. It must complete privacy assessments covering both the video and audio approach, and it must keep audit records showing the system behaved as configured.

##### Privacy-preserving sensor configuration with auditable audio gating

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define “minimising sensor profile” baseline for each sensor/edge node (privacy masks + face blurring/pixelation; audio capture disabled by default) including acceptance tests and configuration reference values | Privacy Engineering Lead | Enterprise | 24h | — |
| Implement policy-as-code / configuration management enforcement (CI/CD and deployment gates) to reject builds/configs where privacy mode is off or audio is enabled; include environment-specific overrides with guardrails | Platform Engineer | Enterprise | 40h | — |
| Build explicit audio authorisation workflow integration (change ticket/workflow) that issues time-bounded, scope-limited authorisation tokens; ensure sensors only accept audio-enable commands when approval evidence is present | Compliance Manager | Enterprise | 32h | — |
| Implement auditable logging for audio enablement and remediation events (who/when/justification/scope/validity window; correlation IDs across workflow, platform, and sensor logs) and centralise to existing logging/SIEM | Security Engineer | Enterprise | 24h | — |
| Develop continuous verification & drift detection (scheduled queries/health checks for privacy mode and audio state; alerting thresholds; automated remediation to baseline) | Operations Lead | Enterprise | 32h | — |
| Provide audit-ready evidence pack (configuration snapshots, current state metadata, retention mapping, and review report templates for production sensors) | Compliance Manager | Enterprise | 16h | — |
| Conduct end-to-end testing and pilot rollout (test cases for baseline enforcement, blocked deployments, authorised audio enablement, drift remediation, and evidence completeness) | Quality Assurance Lead | Enterprise | 24h | £8,000 |
| Total Estimated Effort |  |  | **212h** |  |
| Total Estimated Cost |  |  |  | **£8,000** |

###### Actions Required for Compliance

- [ ] Create a version-controlled “minimum data” sensor profile that enables face blurring or pixelation and privacy masks, and sets audio capture to “disabled” by default.
- [ ] Set up automated checks that enforce configuration rules and block any deployment where the “minimising profile” has not been applied.
- [ ] Set up an approval process that can be audited, so audio can only be turned on through an approved change request ticket. The ticket must record who approved it, their identity, the reason for approval, what is covered (scope), and the specific time period when audio is allowed.
- [ ] Set up the analytics platform and edge devices to record (1) whether “privacy mode” is on and (2) whether an audio stream is present or not, and send these records to the central logging system for audit evidence.
- [ ] Run scheduled checks to compare the current sensor settings against the agreed baseline, and raise an alert and fix the issue if they do not match.


---

### SC-43 — Usage Restrictions (Control)

This requirement is about making sure only approved people and approved equipment can connect to, use, or be installed on your systems, and that their activity is kept under monitoring. Without clear rules and permission checks, staff could accidentally or deliberately use unapproved mobile devices, wireless connections, or equipment such as printers, scanners, and optical devices. This could result in system damage, service disruption, or unauthorised access.

To meet this expectation, the organisation must set clear, practical day-to-day rules and setup guidance for mobile code, mobile devices, wireless access, and wired or wireless peripherals, and follow those rules during installation, configuration, and everyday use. The organisation must formally approve (authorise) the use of these components, monitor their use so authorised activity is recorded, and control or restrict behaviour to prevent unauthorised use or address it quickly.

##### Authorise and enforce approved mobile/wireless/peripheral usage

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce and obtain approvals for a version-controlled **Component Usage Policy** covering mobile code, mobile devices, wireless access, and wired/wireless peripherals (including allowed/blocked sets, prohibited behaviours, and evidence requirements) | Compliance Manager | Enterprise | 24h | — |
| Define the **authorised component model** (device groups/roles, peripheral types, approved connection paths, and failure modes “fail closed”) and publish enforcement requirements for Wi‑Fi/AAA, MDM/EMM, and peripheral gateways | System Design Authority | Enterprise | 32h | — |
| Implement **MDM/EMM device registration and compliance gating** for mobile devices and enforce conditional access to enterprise Wi‑Fi and peripheral access endpoints (including required device attributes and quarantine state) | Infrastructure Lead | Enterprise | 40h | £25,000 |
| Implement **802.1X enforcement with per-user/per-device credentials** and map authorisation to approved device groups/roles; disable/limit non-compliant attachment methods (e.g., ad-hoc hotspots where feasible) | DevOps Lead | Department | 48h | £10,000 |
| Configure **peripheral gateway allowlisting and authenticated access paths** (print/scan gateways), including network segmentation/VLAN controls and blocking of unauthorised peripheral subnets/ports/protocols | Network Engineering Lead | Department | 40h | £15,000 |
| Implement **logging and traceability**: ensure wireless auth (AAA/802.1X), MDM/EMM registration/compliance events, peripheral gateway job metadata, and policy decision outcomes are captured with user/account + device/peripheral identity and forwarded to SIEM | Security Engineer | Enterprise | 40h | £8,000 |
| Create **SIEM detections and SOAR/incident playbooks** for unauthorised attachment attempts, auth failures, peripheral misuse, and policy drift; run at least one controlled test/tabletop and document evidence | SOC/SIEM Team | Enterprise | 32h | £6,000 |
| Deliver **audit-ready evidence pack** (policy versions/approvals, configuration baselines, sample logs demonstrating traceability, test results, and change records) and complete handover to Operations for ongoing monitoring | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 272h  
**Total Estimated Cost:** £64,000

###### Actions Required for Compliance

- [ ] Create and get approval for a version-controlled **Component Usage Policy** covering mobile code, mobile devices, wireless access, and wired and wireless peripherals, including clear rules for what is allowed and what is prohibited.
- [ ] Set up managed-device registration and conditional access so that only authorised and compliant devices can sign in for wireless access and peripheral access endpoints.
- [ ] Require IEEE 802.1X for enterprise Wi‑Fi, allowing only devices and peripherals that are approved, based on their assigned access group and role.
- [ ] Limit peripheral connections by only allowing approved network routes and requiring authenticated access through the print and scan gateways (blocking unauthorised direct discovery where possible).
- [ ] Set up security information and event management (SIEM) logging for wireless sign-ins, device registration and compliance checks, and use of peripheral gateways, using both user and account identifiers as well as device and peripheral identifiers.
- [ ] Set up security information and event management (SIEM) alerts and security orchestration, automation and response (SOAR) action playbooks for unauthorised connection attempts, attempts to access connected devices, and changes to security policies, then test them using a controlled scenario.


---

### SC-44 — Detonation Chambers (Control)

This requirement is about safely testing suspicious digital content in a controlled, isolated environment before it reaches staff. The main risk is that a harmful email attachment, an untrusted or suspicious programme, or a web link could run malicious code and spread into everyday work systems, leading to disruption, data loss, or unauthorised access.

To meet this expectation, the organisation must run an on-premises “detonation” sandbox for email and web traffic inside the classified network enclave. In this sandbox, suspicious attachments, untrusted applications, and web (URL) requests are opened or run in isolation, so any harmful behaviour is identified quickly and cannot spread into users’ normal working environments.

The organisation must also document how the sandbox is set up and configured, keep its procedures and security plan up to date for its use, and keep audit records showing when the sandbox was used and the result.

##### Enclave detonation sandbox for email attachments and URL requests

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Design enclave detonation chamber architecture for sc-44_odp (network placement, isolation boundaries, ephemeral execution model, restricted egress rules, threat model) | System Design Authority | Enterprise | 40h | — |
| Procure and configure on-prem detonation sandbox platform components (detonation manager, analysis workers, storage for short-lived artefacts, HA sizing) | Infrastructure Lead | Enterprise | 24h | £180,000 |
| Provision and harden sandbox cluster inside the classified enclave (secure build, patch baseline, image hardening, secrets handling, admin access controls, network segmentation) | Security Engineer | Enterprise | 32h | £25,000 |
| Implement email attachment detonation integration (routing triggers, submission API/queue, verdict mapping to quarantine/block, fail-closed behaviour, rollback plan) | Software Lead | Enterprise | 48h | — |
| Implement web/URL detonation integration (URL retrieval in isolation, dynamic analysis execution, verdict mapping to link rewriting/block/disable, timeout and retry controls) | Software Lead | Enterprise | 48h | — |
| Enforce short-lived isolation and containment controls (ephemeral snapshot/throwaway lifecycle, no persistence, egress allow-list, artefact handling, malware sample containment) | Cyber Security Lead | Enterprise | 32h | — |
| Implement audit-ready evidence and operational logging (submission ID, start/stop times, artefact type, verdict, containment action; SIEM integration; retention alignment; evidence export) | Compliance Manager | Enterprise | 24h | £12,000 |
| Produce operating procedures and enclave design/configuration record (routing criteria, isolation controls, lifecycle, response actions, escalation/IR hooks, runbooks) | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 264h  
**Total Estimated Cost:** £217,000

###### Actions Required for Compliance

- [ ] Set up an on-premises detonation “sandbox” cluster inside the classified network enclave at the location specified by sc-44_odp.
- [ ] Set up the email security process so that any suspicious attachments are automatically sent to the detonation chamber for safe, isolated testing.
- [ ] Set up the website and web address (URL) security process so that any suspicious URLs are sent to the “detonation chamber” for isolated retrieval and live testing.
- [ ] Set up short-lived “detonation” runs by using a fresh, temporary environment for each submission, with outgoing network access restricted and no lasting connection or storage on users’ networks.
- [ ] Use the results of map detonations to decide what containment action to enforce in the email and web security layers (quarantine, block, disable, or allow with a warning).
- [ ] For every detonation (submission), enable audit logs that record the submission ID, artefact type, execution time window, outcome (verdict), and the containment action taken, and keep the logs according to the applicable policy.
- [ ] Document the rules for routing items through the detonation chamber, the isolation controls used to keep areas safe, the limits for how long records and items are kept (lifecycle and retention), and the procedures for day-to-day operational handling.


---

### SC-45 — System Time Synchronization (Control)

This requirement is about making sure every computer clock in your organisation shows the correct time, both within each system and across different systems and their parts. If clocks drift or disagree, important security checks can fail. For example, people may be wrongly accepted or rejected when they log in, certificates may appear valid or expired at the wrong time, and systems may behave unpredictably. This could lead to a denial of service or to credentials continuing to work when they should no longer be valid.

To meet this expectation, the organisation must put clear, written procedures in place for how clocks are synchronised. This includes which time source to use and how often synchronisation should happen. The organisation must then apply the approved settings to every relevant system component. Administrators must be able to follow these procedures in day-to-day work. The approach must be documented in system design and security plans, and records must be kept to show synchronisation is working and to demonstrate that any failures or excessive drift are detected and corrected promptly.

##### Authoritative NTP time sync with automated enforcement and drift alerts

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authoritative time-basis procedure (UTC handling, tolerance/offset thresholds, measurement method, degradation window, escalation triggers) and obtain security/compliance approval | Compliance Manager | Enterprise | 16h | — |
| Design authoritative time source architecture (redundant internal NTP servers, network placement, upstream reference health checks, authenticated time approach where feasible) and publish standards | System Design Authority | Enterprise | 24h | — |
| Procure/enable required time-sync capabilities (e.g., NTS-capable NTP stack licensing/support, hardened NTP server appliances/VM images, any required certificates/keys for authenticated time) | Infrastructure Lead | Enterprise | 8h | £12,000 |
| Implement authoritative NTP servers and hardening (config baselines, firewall rules, monitoring endpoints, upstream health monitoring, failover behaviour) | Operations Lead | Business Unit | 20h | £2,000 |
| Create and roll out automated client enforcement via configuration management (host OS, hypervisor, container runtime, CI/CD runners; enforce approved server list, UTC settings, enabled state; ensure idempotency after reboot/image refresh) | DevOps Lead | Enterprise | 40h | — |
| Implement continuous verification & drift alerting (collect per-host offset/reachability, evaluate against tolerance, generate alerts, define escalation/incident workflow, integrate with SIEM/observability) | Security Engineer | Enterprise | 32h | £6,000 |
| Produce audit-ready evidence pack and retention mechanism (scheduled snapshots of time-sync status, change records for configuration updates, evidence of tolerance breaches and resolutions; test evidence completeness) | Data Protection Officer | Enterprise | 16h | — |
| Validate end-to-end behaviour with controlled testing (planned maintenance/outage simulation, drift injection test, recovery verification, sign-off against acceptance criteria) | Quality Assurance Lead | Enterprise | 24h | — |
| **Total Estimated Effort** |  |  | **200h** |  |
| **Total Estimated Cost** |  |  |  | **£20,000** |

###### Actions Required for Compliance

- [ ] Define and get approval for the time standard to use (Coordinated Universal Time (UTC) versus local time offset) and the maximum acceptable difference in system clocks (clock offset/tolerance) for the in-scope components.
- [ ] Set up multiple (redundant) internal Network Time Protocol (NTP) servers that are the official source of time, and use authenticated time sources where possible. Document health checks that confirm whether their upstream time references are working correctly.
- [ ] Set up network time protocol (NTP) clients on all production, test, and disaster recovery computers, and across all virtualisation and container layers, to use only the approved internal time sources.
- [ ] Use automated checks and enforcement through configuration management and device baseline settings to keep time settings correct, and to fix any changes that occur after reboots or when new system images are installed.
- [ ] Set up continuous monitoring of the time-keeping status (whether it can be reached and whether it is in sync) and configure alerts and escalation if the allowed tolerance is exceeded.
- [ ] Store evidence of periodic time synchronisation status and records of configuration changes for audit purposes, including any cases where tolerance limits were exceeded and the remediation actions taken.


---

#### SC-45.1 — Synchronization with Authoritative Time Source (Enhancement)

This requirement is about making sure every system’s internal clock matches an official time source, so events are recorded with the correct time. If clocks drift or show different times, it becomes harder to investigate incidents, confirm what happened and when, and coordinate responses across different systems. This increases the risk of delays, mistakes, and unreliable records.

To meet this expectation, the organisation must configure systems to check their internal time against the organisation-approved Department of Defense (DoD) Global Positioning System (GPS) time servers within the approved network every 60 seconds. The system must automatically correct the system clock whenever the difference is more than 5 seconds.

The organisation must also document how these time checks and corrections work, record what the system did (including the size of the time difference when correction was triggered, where available), and include these responsibilities in its system plans so administrators can run the process consistently and reliably.

##### Enforce NTP sync to approved DoD GPS servers with 5s threshold

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authoritative NTP allow-list scope (approved DoD GPS NTP hostnames/IPs), network path constraints, and fail-safe/unreachable-source behaviour requirements | Compliance Manager | Enterprise | 8h | — |
| Produce standard NTP/chrony/ntpd baseline specifications for all supported OS/platforms (60-second comparison cadence; corrective resync only when offset > 5s; no corrective action when ≤ 5s) | System Design Authority | Enterprise | 16h | — |
| Implement configuration management enforcement (policy-as-code) to apply baseline across production, test, and DR; include idempotent remediation logic to re-apply config and restart/force time service only when out-of-policy | DevOps Lead | Enterprise | 40h | — |
| Implement drift detection and remediation triggering criteria (offset > 5s for more than one comparison cycle; not using approved sources) and ensure safe change management integration | Platform Engineer | Enterprise | 24h | — |
| Configure audit-ready evidence capture (time service logs/telemetry exports) for: selected authoritative source, comparison/sync attempts, measured offset at trigger time (where available), and timestamps of corrective actions | Security Engineer | Enterprise | 16h | — |
| Update system security plans and operational runbooks with NTP design, authoritative sources, 60-second cadence, 5-second threshold, and unreachable-source handling; include operator guidance and escalation steps | Compliance Manager | Enterprise | 16h | — |
| Execute validation testing at/around threshold (e.g., 4.9s vs 5.1s), confirm corrective resync occurs only when > 5s, and produce test evidence for audit | Quality Assurance Lead | Enterprise | 24h | — |

Total Estimated Effort: **144h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Create and approve an allow-list of the organisation’s Department of Defense (DoD) Global Positioning System (GPS) Network Time Protocol (NTP) server hostnames and Internet Protocol (IP) addresses that can only be reached from approved network segments.
- [ ] Set up a standard Network Time Protocol (NTP) / chrony timekeeping baseline on all in-scope systems so they can be compared and synchronised on a 60-second schedule.
- [ ] Set the system’s corrective behaviour so it only re-synchronises when the measured time difference is more than 5 seconds (and does not re-synchronise when it is 5 seconds or less).
- [ ] Roll out the baseline using central configuration management, and automatically fix any hosts that drift out of compliance.
- [ ] Enable and keep time service logs and telemetry that record which authorised time source was selected, any attempts to compare or synchronise with other sources, and the offset values used to trigger updates where available.
- [ ] Update each system security plan and runbook to use the authoritative source, check for differences every 60 seconds, treat differences lasting more than 5 seconds as a threshold, and follow the agreed process for when the source cannot be reached.
- [ ] Run timing threshold checks (for example, comparing 4.9 seconds versus 5.1 seconds offsets) and record the results as evidence.


---

#### SC-45.2 — Secondary Authoritative Time Source (Enhancement)

This requirement is about making sure your systems can always keep accurate time, even if their usual trusted time source becomes unavailable. Accurate time matters because many important business and security activities depend on events being correctly dated and in the right order. If time becomes wrong or inconsistent, investigations, audits, and troubleshooting can be misleading, and problems may be harder to spot or prove.

To meet this expectation, the organisation must:
- choose a second trusted time source in a different geographic region from the main one;
- record how the second source was confirmed as trustworthy;
- configure the systems so they automatically switch to the second source whenever the main source is unavailable.

When the main source is available again, the systems should switch back to it rather than staying on the backup unnecessarily. The organisation should also keep clear procedures for how the time switching works, and be able to demonstrate—using configuration settings and records—that the automatic switch actually took place during a primary outage.

##### Dual-region secondary authoritative time source with auto-failover

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select and document authoritative primary/secondary time sources (NTP/PTP endpoints), including connectivity requirements and supported protocols | System Design Authority | Enterprise | 16h | — |
| Prove geographic separation: capture provider region/country details and obtain independent geolocation evidence; store in an auditable evidence repository | Compliance Manager | Enterprise | 24h | — |
| Define failover/unavailability criteria and convergence targets (e.g., reachability, sync offset/stratum thresholds) aligned to OS time service capabilities | Security Engineer | Enterprise | 16h | — |
| Implement dual-source configuration baseline for supported OS time services (e.g., chrony/systemd-timesyncd/Windows time) with auto-switch and auto-return logic | Platform Engineer | Enterprise | 32h | — |
| Standardise rollout across production tiers using configuration management (web/app nodes, API nodes, job runners, message brokers, database hosts) with versioned baselines and change records | DevOps Lead | Enterprise | 40h | — |
| Enable audit evidence and monitoring: configure time sync status logging, source-active indicators, and SIEM/monitoring forwarding; define alerting for source switching and prolonged convergence failures | Operations Lead | Enterprise | 24h | £3,000 |
| Execute and document failover test: simulate primary outage, verify switch to secondary within convergence window, verify automatic return after restoration; produce an auditable test report | Service Delivery Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 196h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Choose a reliable main time source and a reliable backup time source that your systems can access.
- [ ] Record and provide evidence of the primary and secondary geographic regions using the provider’s location information and independent geolocation checks.
- [ ] Set up the operating system’s time-keeping service to use both time sources, choosing the one that is reachable and working (based on failures), and automatically switch back when the original source is available again.
- [ ] Apply the agreed time settings consistently across all production environments by using configuration management.
- [ ] Enable and centralise logging of time-synchronisation status so that active-source and switch events can be audited.
- [ ] Simulate a main service outage by blocking the main network time protocol (NTP) address, then check that the system automatically switches to the backup NTP address. After the issue is fixed, switch back to the main NTP address.
- [ ] Store the configuration details, geographic evidence, and test results in the organisation’s audit-ready evidence repository.


---

### SC-46 — Cross Domain Policy Enforcement (Control)

This requirement is about putting a strong, physical barrier in place between different “security areas”, so that traffic and access rules cannot be quietly bypassed. Without this, someone could potentially find a direct connection path that avoids the intended checks, which could allow unauthorised access or movement of data between areas that should be kept separate.

To meet this expectation, the organisation must physically implement a mechanism that enforces the access policy between the physical and/or network connection points that link those security domains. This mechanism must block any way to bypass the rules through a direct path, and it must not create any hidden, indirect route that could weaken the separation.

The organisation must also document how the enforcement works, where it sits in the overall design, and the specific settings used. Configuration records must be kept up to date. Audit records must be retained to show it is working as intended, and the approach must be included in the system security plan. Named staff must be assigned to install, configure, and maintain it, and they must follow the documented procedures.

##### Physically enforced cross-domain guard between security domains

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce in-scope interface inventory and bypass-path assessment (SC-46 physically): list connecting physical/network interfaces, identify potential bypass routes (including management-plane), and confirm which connections are in-scope | Security Engineer | Enterprise | 24h | — |
| Design the dedicated physical enforcement choke-point topology (including HA option), cabling/segmentation rationale, and one-way vs bidirectional flow approach | System Design Authority | Enterprise | 32h | — |
| Procure and stage dedicated cross-domain guard hardware/software (primary + HA where required), including spares and required transceivers/cabling components | Infrastructure Lead | Enterprise | 8h | £45,000 |
| Implement physical isolation and network adjacency controls: deploy guard network/segmented guard VLANs/ports, remove/disable alternative routing/static routes, and validate no dual-homing/shared infrastructure exists that could bypass | Operations Lead | Enterprise | 40h | £6,000 |
| Configure deny-by-default enforcement rules with explicit allow-lists (protocol/service/session controls), including stateful handling for required bidirectional flows and strict administrative access to the guard | Security Engineer | Enterprise | 32h | — |
| Establish change control and verification procedures: define peer-reviewed change workflow, configuration baselines, and perform routing/adjacency/path verification tests to demonstrate no direct logical path bypasses the guard | Compliance Manager | Enterprise | 24h | — |
| Enable and integrate boundary audit logging to SIEM (allowed/denied sessions, admin/policy changes, health/status), including log retention mapping and test of end-to-end evidence availability | Data Protection Officer | Enterprise | 20h | £12,000 |
| Update system security plan and configuration documentation with physical placement, cabling/segmentation rationale, enforcement rule set, maintenance/verification steps, and audit evidence references | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 196h  
**Total Estimated Cost:** £63,000

###### Actions Required for Compliance

- [ ] Create an inventory of all physical and network connections (interfaces) between security domains, and identify which connection paths are in scope for control SC-46.
- [ ] Design and set up a separate, physically isolated “guard” network segment so there is no direct network switching or routing connection between the domains.
- [ ] Set the guard to block everything by default, and then explicitly allow only the required protocols and services. Use one-way data transfer where business needs allow it.
- [ ] Remove or disable any connections between different network domains, any static routes, or any alternate network paths that could get around the guard.
- [ ] Turn on and send “guard boundary” audit logs to the security information and event management (SIEM) system, including records of allowed and denied sessions and any policy or administration changes, and keep them for an appropriate length of time.
- [ ] Update the system security plan and configuration documents to include where the security controls are placed, the rules they use, and the steps for checking and maintaining them.


---

### SC-47 — Alternate Communications Paths (Control)

This requirement ensures that the key people who make decisions can still communicate and direct operations even if the usual communication methods stop working. Without dedicated backup communication routes, a disruption during an incident could leave the organisation unaware of what is happening and unable to give timely instructions. This would slow recovery and increase harm.

The organisation is expected to set up and maintain dedicated secure voice communication and encrypted messages sent outside the normal systems. This should use satellite phones and approved secure email. It must also name the specific primary decision-makers, and name specific alternate decision-makers who take over when the primary people are unavailable. Each alternate’s authority must have clear, documented limits on what they are allowed to approve.

The organisation should document how these backup channels are used, include them in its system plans and design records, configure the arrangements so they work as intended, and keep evidence that the communication routes and named contacts are tested, up to date, and usable.

##### SC-47 Comms Kit: secure voice bridge + encrypted out-of-band messaging

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define SC-47 scope, communications objectives, and minimum requirements (voice bridge restrictions, OOB messaging methods, roster data fields, evidence expectations) | Compliance Manager | Enterprise | 8h | — |
| Select/confirm secure voice bridge and approved secure email approach; produce technical design for restricted access, join method, and operational separation | System Design Authority | Enterprise | 16h | — |
| Provision and harden dedicated secure voice bridge (conference/bridge service), including documented join instructions and access restrictions for SC-47 roster | Infrastructure Lead | Enterprise | 24h | £3,000 |
| Provision encrypted out-of-band messaging: procure/assign dedicated satellite phones and configure approved secure email workflow/gateway for SC-47 communications | Operations Lead | Enterprise | 32h | £12,000 |
| Create and maintain authoritative SC-47 roster (system of record): named primary/alternate decision-makers, activation triggers mapping, bridge join instructions, satellite asset IDs/numbers, and approved secure email addresses | Project Manager | Enterprise | 16h | — |
| Develop SC-47 activation runbook: activation triggers, handover/handback rules, alternate action limits (what they may authorise vs may not), escalation/notification requirements, and communications record-keeping steps | Security Engineer | Enterprise | 20h | — |
| Execute first supervised usability test cycle and retain audit evidence (voice bridge join test, satellite reachability test, secure email end-to-end test; capture results, participants, timestamps, and outcomes) | Service Delivery Manager | Enterprise | 16h | £1,500 |
| Establish quarterly test schedule and continuous improvement loop (test plan, roles/attendance, evidence retention, corrective actions and re-approval workflow for roster/runbook changes) | Compliance Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 144h  
**Total Estimated Cost:** £18,500

###### Actions Required for Compliance

- [ ] Set up a dedicated secure voice bridge with restricted access and documented joining instructions for SC-47 staff.
- [ ] Assign dedicated satellite phones as SC-47 assets and record their asset ID numbers in the SC-47 roster.
- [ ] Set up and approve a secure email process for SC-47 communications that uses encryption and a separate (out-of-band) channel.
- [ ] Publish an official SC-47 list naming the main and backup decision-makers, including contact details for bridge communications, satellite communications, and secure email.
- [ ] Document the activation triggers, the escalation and handover rules, and the point at which alternates take command during an SC-47 activation runbook
- [ ] Define and get approval for role-specific limits on what alternates are allowed to do, including clear items they are not permitted to do, and mandatory notifications when those limits are reached or relevant actions occur.
- [ ] Run and record supervised quarterly usability tests for bridge joining, satellite reachability, and secure email delivery.


---

### SC-48 — Sensor Relocation (Control)

This expectation is about changing where your “watchers” look for suspicious activity inside your own network, and where they collect key internal event records, so they are not always in the same place. The real-world risk it addresses is that a determined attacker could figure out where you are monitoring and then get through or steal information by using network paths you do not monitor—especially when they move between systems.

To meet this expectation, the organisation must keep a documented list of the specific internal traffic watchers and event collectors it will move. It must also identify any newly discovered network areas and operational technology monitoring points that were not previously monitored, and decide whether to move the watchers based on threat information that suggests likely routes for getting in or taking data out, or alternatively on a random timetable to make the pattern harder to predict.

Each move must be approved and recorded. The organisation’s configuration and design records must be updated to show the new locations, and evidence must be kept to prove the watchers started operating in the new, previously unmonitored places.

##### Threat-intel driven relocation workflow for east–west sensors

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create/refresh authoritative relocation inventory (sensor/collector IDs, current tap/span/log source mappings, owning team, current instrumented locations, evidence of current state) | Cyber Security Lead | Enterprise | 24h | — |
| Define target selection logic and “previously uninstrumented” filter (TI→candidate OT DMZ segments/points mapping rules; explicit exclusion of already-instrumented targets; documented assumptions and edge cases) | Security Engineer | Enterprise | 32h | — |
| Build relocation plan template and evidence checklist (TI reference linkage, from/to mappings, rationale, proof target was uninstrumented, required change record fields, rollback requirements) | Compliance Manager | Enterprise | 16h | — |
| Implement workflow automation/configuration support (software component or scripts to generate relocation plan outputs from inventory + TI inputs; enforce schema/validation; produce audit-ready artefacts) | Software Lead | Enterprise | 56h | £6,000 |
| Execute controlled relocation change(s) in non-prod first (pre/post snapshots, rollback rehearsal, configuration updates to repoint IDS sensors and log collectors, disable/retire old primary collection points in line with plan) | Network/OT Security Engineer | Department | 40h | — |
| Execute controlled relocation change(s) in production (CAB-approved deployment; apply repoint changes; capture deployment evidence; confirm old sources are no longer primary; implement rollback if acceptance fails) | Operations Lead | Department | 48h | — |
| Update configuration/design/security-plan documentation and configuration management records; implement audit evidence pack (monitoring platform/collector logs, start-of-receive from new sources, end-of-receive from old sources, TI→plan→change→evidence traceability) | Configuration Management (CM) Owner | Enterprise | 32h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date, authoritative list of the in-scope east–west intrusion detection system (IDS) sensors and security event log collectors, including their current instrumented locations.
- [ ] Set up rules that use threat intelligence to identify which operational technology (OT) locations could be targeted, and exclude any locations that are already instrumented.
- [ ] Create a relocation plan (from/to mapping) that points to the TI source and includes an evidence checklist to confirm “previously uninstrumented” items have been verified.
- [ ] Submit relocation plans through the organisation’s change management process, with Change Advisory Board (CAB) approval, rollback steps, and pre- and post-change configuration snapshots.
- [ ] Update the intrusion detection system (IDS) sensors and log collectors to the approved new network segments and operational technology (OT) demilitarised zone (DMZ) monitoring locations, and turn off the old primary collection points.
- [ ] Update configuration management and the design and security plan documents to reflect the new monitoring locations.
- [ ] Keep audit records from the monitoring and data-collection platforms that show (1) successful data ingestion from new sources and (2) that primary data collection has stopped at the old sources.


---

#### SC-48.1 — Dynamic Relocation of Sensors or Monitoring Capabilities (Enhancement)

This requirement is about being able to move your monitoring tools quickly and safely when circumstances change, so you can continue to see what is happening. If these tools cannot be moved during planned maintenance, while an incident is being contained, when there is a suspected security compromise, when the network layout changes, or when coverage or risk levels are no longer acceptable, you could lose visibility at the exact time you most need it. That can delay detection and response.

The organisation must have clear written procedures for dynamically relocating:
- network intrusion detection sensors,
- host-based logging agents, and
- security monitoring collectors

to the designated on-premises security monitoring zones and operational technology (OT) demilitarised segments whenever the triggers above occur.

The organisation must also:
- keep an up-to-date list of exactly what can be moved and where it is allowed to go;
- record each relocation through change control; and
- update the official records of configuration, system design, system settings, audit evidence, and the system security plan so they accurately show what was moved, when it was moved, and why.

##### Event-driven relocation runbooks for sensors and monitoring collectors

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Establish relocation scope register (capability types, eligible instances, current/owner location, relocation eligibility flags, and ownership metadata) | Platform Engineer | Enterprise | 40h | — |
| Define destination allow-list and connection constraints (on-prem security monitoring zones + OT demilitarised segments; include routing/firewall endpoints, certificate/identity constraints, and OT operational constraints) | Security Engineer | Enterprise | 32h | — |
| Design relocation triggers and approval gates mapped to the five circumstances (maintenance, incident containment, suspected compromise, topology changes, risk/coverage thresholds exceeded) including RACI and evidence requirements | Compliance Manager | Enterprise | 24h | — |
| Implement policy-as-code enforcement for relocation (authorise only scope-register capabilities; restrict destinations to allow-list; validate trigger-to-runbook mapping; implement guardrails and rollback rules) | Software Lead | Enterprise | 56h | £18,000 |
| Build automation-first orchestration for runbook execution (re-point/reconfigure sensor telemetry, host logging forwarders, and monitoring collectors; include idempotency and safe sequencing) | DevOps Lead | Enterprise | 72h | £12,000 |
| Implement pre-checks and post-checks with verification window (reachability, identity/certificate validity, telemetry/alert ingestion confirmation into SIEM/monitoring; define pass/fail criteria and escalation paths) | Security Engineer | Enterprise | 40h | — |
| Create auditable evidence capture and configuration/design record updates (change/config management integration; record capability ID/type, source/destination IDs, timestamp, trigger, authoriser, pre/post results; update system security plan/config/design or log rationale) | Data Protection Officer | Enterprise | 32h | — |
| Pilot execution and operational readiness (dry-runs for each circumstance, tabletop exercises with SOC/IR and OT gates, refine runbooks, train operators, and complete acceptance testing) | Service Delivery Manager | Enterprise | 40h | £6,000 |

**Total Estimated Effort:** 376h  
**Total Estimated Cost:** £36,000

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date relocation scope register for all eligible sensors and monitoring capabilities, including their identification numbers, types, current locations, and whether they can be relocated.
- [ ] Define and keep an approved list of allowed destinations for on-premises security monitoring zones and operational technology (OT) demilitarised segments, including the destination identifiers and the connection limits.
- [ ] Create relocation runbooks for each required situation (planned maintenance, incident containment, suspected compromise, network layout changes, and cases where risk or coverage thresholds are exceeded), and include the required approval steps before actions can be taken.
- [ ] Set up orchestration automation that redirects sensors, agents, and collectors only to approved destinations (use an allow-list so only approved options can be selected).
- [ ] Add pre-checks and post-checks in the runbook to confirm the system can be reached and that telemetry and alerts are successfully received after the move.
- [ ] Link the relocation work to the change and configuration management process so that you record what was moved, where it went, when it happened, and why, and then update the system security plan and the configuration and design records.


---

### SC-49 — Hardware-enforced Separation and Policy Enforcement (Control)

This requirement is about putting a strong, hardware-based protection in place between your **Secret (classified)** network area and your **confidential** information technology (IT) and operational technology (OT) network areas. The goal is to ensure that only the specific, approved connections and actions are allowed to move between these areas.

Without this protection, sensitive information could be exposed, or unauthorised systems could gain access to the more sensitive environment. This could lead to major operational disruption, and could also result in regulatory and reputational damage.

To meet this expectation, the organisation must:
- clearly define and document the two areas that must be separated;
- implement hardware controls that enforce the agreed rules for what traffic and actions can cross between them, blocking unauthorised activity;
- keep up-to-date design and configuration records showing how the protection works;
- maintain clear procedures for how the cross-area rules are created, changed, and checked;
- include this approach in the system security plan; and
- keep audit records that demonstrate the protection is working as intended.

##### Hardware cross-domain gateway enforcing Secret↔Confidential policy

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm boundary scope for sc-49_odp: produce authoritative mapping of Secret enclave vs Confidential IT/OT segments (IP ranges, routing ownership, VRFs/zones, DNS/service naming views) | System Design Authority | Enterprise | 24h | — |
| Network path assurance: document and implement routing constraints so cross-domain traffic can traverse only the dedicated hardware gateway (identify and remediate alternate paths) | Infrastructure Lead | Enterprise | 32h | — |
| Procure and deploy dedicated hardware cross-domain security gateway (appliance selection, sizing, interface/VRF/zone binding, HA approach if required) | Operations Lead | Enterprise | 16h | £45,000 |
| Configure hardware enforcement: implement default-deny for cross-domain traffic and create explicit allow rules (directionality, source/destination, protocol/port, session limits) aligned to approved business flows | Security Engineer | Enterprise | 40h | — |
| Implement tamper-evident audit logging and SIEM forwarding (rule/action/session identifiers, log integrity controls, retention alignment, alerting hooks) | Cyber Security Lead | Enterprise | 24h | £8,000 |
| Establish rule lifecycle and evidence: define CAB workflow for rule changes, versioning/export of rule-sets, and maintain configuration snapshots and architecture diagrams | Compliance Manager | Enterprise | 20h | — |
| Update system security plan and perform verification (configuration compliance checks, routing/path validation, sampling of allow/deny log events in SIEM; record verification results) | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 200h  
**Total Estimated Cost:** £53,000

###### Actions Required for Compliance

- [ ] Document the “Secret” and “Confidential” security domains for **sc-49_odp**, including the approved IP address ranges, who owns the network routing, and how the network interfaces map to the relevant virtual routing and forwarding (VRF) instances and zones.
- [ ] Set up a dedicated hardware “cross-domain” gateway with separate network interfaces and routing tables for each domain. Configure routing so this gateway is the only allowed route between domains.
- [ ] Set up the gateway to block everything by default (“default-deny”), and then add only the specific “allow” rules that follow the approved cross-domain policy, covering direction, protocol and port, and the allowed source and destination.
- [ ] Set up tamper-evident logging at the gateway to record every allow or deny decision, and send those logs to the enterprise security information and event management (SIEM) system with the required retention period.
- [ ] Use a controlled process for the full lifecycle of rules, including approval steps, version tracking, and checks after changes. Save exported configuration snapshots as evidence for audits.
- [ ] Update the system security plan to refer to the hardware separation boundary, and carry out regular checks to confirm that the security controls are working effectively.


---

### SC-50 — Software-enforced Separation and Policy Enforcement (Control)

This requirement is about using built-in software controls to keep different parts of your systems and data strictly separated, so that only the right people and systems can move between areas. Without this, someone could accidentally or deliberately access sensitive information or critical operational systems from the wrong place, or carry out actions they are not allowed to do. This could lead to data leaks, disruption, or unauthorised changes.

To meet this expectation, the organisation must clearly define the separation boundaries between:
- IT/OT network areas,
- user and administrator areas, and
- Secret and Confidential data areas,

and then enforce these boundaries using software, not policy alone. The organisation must document how the rules for moving across these boundaries are enforced, reflect this approach in system design and configuration settings, ensure installers and maintainers follow the documented method, and keep audit records and a system security plan that show the separation is working as intended, including any stronger measures needed for higher-risk situations.

##### Software-enforced domain separation via policy gateways and ABAC

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish domain model and enforcement point inventory (cross-domain paths, source/target domains, action types, required step-up rules for Secret) | Security Architect | Enterprise | 40h | — |
| Design ABAC/RBAC policy schema and attribute sources (IdP claims, service account attributes, resource tags for Secret/Confidential; deny-by-default rules) | Security Architect | Enterprise | 48h | — |
| Implement policy gateway enforcement (API gateway / reverse proxy / service-to-service authorisation layer) with deny-by-default and action-level separation | Platform Engineer | Department | 72h | £18,000 |
| Integrate IdP with policy engine (token/session handling, short-lived tokens, re-authorisation for sensitive actions, attribute mapping and validation) | IAM/Platform Engineer | Enterprise | 56h | £6,000 |
| Implement resource classification tagging and routing through enforcement points (Secret/Confidential data stores, database proxy/controls, application routing changes) | Software Lead | Department | 64h | £12,000 |
| Configure continuous enforcement and test coverage (request-by-request evaluation, negative/positive tests per domain pair, step-up flows, regression tests) | Quality Assurance Lead | Department | 48h | — |
| Enable audit evidence generation and SIEM forwarding (allow/deny decision logs with required fields, retention configuration, correlation rules, evidence pack template) | SOC/SIEM Engineer | Enterprise | 40h | £8,000 |
| Produce system security documentation and configuration baselines (enforcement design, rule sources, deployment settings, operational runbooks, audit-ready evidence mapping) | Compliance Manager | Enterprise | 32h | — |

**Total Estimated Effort:** 400h  
**Total Estimated Cost:** £44,000

###### Actions Required for Compliance

- [ ] Identify and record every way people or systems can access data across different areas, including connections between IT/operational technology (OT) zones, user and administrator areas, and Secret/Confidential data areas.
- [ ] Choose and set up software “enforcement points” for each path (for example: zero trust network access (ZTNA) / secure access gateway, application programming interface (API) gateway, reverse proxy, service-to-service authorisation, database proxy).
- [ ] Set up attribute-based access control (ABAC) and role-based access control (RBAC) rules with the organisation’s identity provider (IdP), using domain details and resource labels to decide who can access what. Block access by default for actions that cross between different domains.
- [ ] Set permissions at the individual action level for Secret and Confidential information, and require extra approval (step-up re-authorisation) before carrying out sensitive actions.
- [ ] Enable continuous checks for authorisation during each request and session, so policies cannot be bypassed using old (stale) tokens or reused sessions.
- [ ] Set up audit logging at every enforcement point to record each allow or deny decision, the user identity, the relevant domains, the resource classification, the action taken, and the enforcement component involved. Send these records to security information and event management (SIEM).
- [ ] Publish and keep up to date system security documents and configuration baselines that show how security is enforced and the exact policy settings that are currently in use.


---

### SC-51 — Hardware-based Protection (Control)

This requirement is about physically locking the most important built-in software on your devices so it cannot be changed without permission. It matters because if the built-in start-up settings, the system management functions, or the rules that control secure boot can be altered, an attacker could quietly take control of the device or make it behave in ways you may not easily notice.

To meet this expectation, the organisation must keep hardware write-protection switched on during normal operation for the Unified Extensible Firmware Interface (UEFI)/Basic Input/Output System (BIOS) firmware, the system management firmware (such as baseboard management controller (BMC), iDRAC, or iLO), and the secure boot configuration. When an approved firmware update is genuinely needed, the system owner, the firmware administrator, and the authorised change manager must follow documented, role-specific steps to manually switch the hardware write-protection off only for that approved change, and then switch it back on again before the device is returned to operational use.

##### Hardware write-protect lock and role-gated firmware change procedure

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Create device-model mapping for hardware write-protect mechanisms (UEFI/BIOS, BMC/iDRAC/iLO, secure boot configuration) including “enabled/locked” indicator states and supported disable/enable methods | System Design Authority | Enterprise | 24h | — |
| Define standard evidence requirements and lock-state verification checklist (pre-change locked state, post-change locked state, secure boot expected state, sign-off fields, timestamps, device identifiers) | Compliance Manager | Enterprise | 16h | — |
| Develop role-gated firmware change runbook with two-person workflow (firmware administrator performs physical actions; authorised change manager verifies and signs) including approved-change scope and step-by-step instructions | Project Manager | Enterprise | 20h | — |
| Produce secure boot post-change verification procedure per device model (UEFI interface checks, confirmation that configuration changes are blocked while locked where supported) | Security Engineer | Enterprise | 16h | — |
| Update operational process: integrate runbook into change management workflow (approval gates, “return-to-service” condition, rollback considerations, retention of change records for audit) | Operations Lead | Enterprise | 18h | — |
| Train authorised roles and run tabletop/practical dry-run for at least one representative device model; capture training attendance and competency sign-off | Service Delivery Manager | Enterprise | 14h | — |
| Establish audit-ready recordkeeping and periodic effectiveness checks (sampling plan, evidence review cadence, handling of exceptions/non-compliance) | Compliance Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 120h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] For each in-scope device model, identify and record the vendor’s hardware write-protection method for:

- Unified Extensible Firmware Interface (UEFI) / basic input/output system (BIOS)
- Baseboard management controller (BMC) / iDRAC / iLO

Also identify and record the secure boot configuration for each device model.
- [ ] Create a firmware change runbook that provides step-by-step instructions to disable and then re-enable the firmware, aligned to the three authorised roles.
- [ ] Set up a two-person process where the firmware administrator carries out the actions, and the authorised change manager checks the evidence and signs it off.
- [ ] Update the change management template to require: verification that the system is in a locked state before the change, verification that it is re-enabled after the change, and confirmation of the secure boot verification results.
- [ ] Train the system owner, firmware administrator, and authorised change manager on the runbook and the evidence they must provide.
- [ ] Carry out an initial baseline check of all in-scope devices to confirm that hardware write protection is enabled, and record the results.

