### MA-1 — Policy and Procedures (Control)

This requirement is about making sure your organisation has clear, written rules for how maintenance work is planned, carried out, recorded, and checked—and that these rules are kept up to date. Without this, maintenance may be done in different ways, important safeguards could be missed, and updates made after an incident, a major system change, or new legal requirements might not be reflected. This increases the risk of service disruption, data loss, and failing to meet legal or regulatory obligations.

To meet this expectation, the organisation must create and document an organisation-wide maintenance policy. This policy must explain its purpose, what it covers, who is responsible for what, how leadership supports it, how different teams coordinate, and how compliance will be managed. It must also align with all relevant laws and internal standards. The Security Policy Office must manage creating, documenting, and distributing the policy and supporting procedures to the Chief Information Security Officer (CISO), the Security Policy Office, the relevant security officers, and system owners. It must also distribute the procedures to system owners, operational technology/information technology (OT/IT) operations managers, and maintenance technicians.

Both the maintenance policy and the supporting procedures must be reviewed and updated every year, and also after security incidents or breaches, audit findings, major system changes, or changes to applicable laws and regulations.

##### Org-level maintenance policy & procedures with trigger-event reviews

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Draft organisation-level Maintenance Policy (IT/OT scope) using the approved template, including purpose, scope, coordination model (security/privacy + operations), roles/responsibilities, compliance approach, and references to relevant standards/laws | Compliance Manager | Enterprise | 24h | — |
| Draft Maintenance Procedures suite (implementation-focused) covering planning, authorisation expectations, pre-maintenance security checks, execution controls, verification/validation, rollback expectations (where applicable), and required records/evidence | Security Policy Office | Enterprise | 40h | — |
| Define and document the dissemination/acknowledgement model: policy distribution to CISO, ISSO/ISSO-equivalents, and system owners; procedures distribution to system owners, OT/IT operations managers, and maintenance technicians; include required acknowledgement artifacts | Compliance Manager | Enterprise | 16h | — |
| Implement controlled document lifecycle in the organisation GRC/document repository (versioning, effective dates, approval records, distribution logs, acknowledgement capture, retention settings) | Operations Lead | Enterprise | 24h | £3,000 |
| Establish annual review cadence and trigger-event workflow: intake queue, trigger sources (SOC/SecOps, Internal Audit, Change Management, Legal/Compliance), decisioning (update vs no update with rationale), assignment of an owner, and evidence requirements | Project Manager | Enterprise | 32h | — |
| Produce trigger-event evidence pack templates (e.g., review record, consultation/sign-off log for security & privacy programme collaboration, workflow run evidence, and “no update” rationale) | Compliance Manager | Enterprise | 16h | — |
| Run at least one end-to-end trigger-event workflow simulation (per trigger type: security incident/breach, audit finding, major system change, law/regulation change) and record outcomes to demonstrate responsiveness and audit readiness | Security Engineer | Enterprise | 20h | — |

**Total Estimated Effort:** 172h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Draft an organisation-wide maintenance policy that sets out its purpose, what it covers, who is responsible, how different teams coordinate, how compliance will be checked, and how it aligns with legal and regulatory requirements.
- [ ] Draft maintenance procedures that turn the policy into practical, step-by-step maintenance actions across the maintenance lifecycle, including the required records and supporting evidence.
- [ ] Make the Security Policy Office the official owner responsible for maintaining the security policy and its procedures.
- [ ] Publish both documents in a controlled document library with version control, recorded approvals, and records showing who received and acknowledged them.
- [ ] Share the Maintenance Policy with the Chief Information Security Officer (CISO), the Information System Security Officers (ISSO), and the system owners, and get written confirmation that they have received it.
- [ ] Share the maintenance procedures with system owners, operational technology (OT) and information technology (IT) operations managers, and maintenance technicians, and get confirmation that they have received them.
- [ ] Set up an annual review timetable and a process to report and assess “trigger events” for incidents or breaches, audit findings, major system changes, and legal or regulatory changes.


---

### MA-2 — Controlled Maintenance (Control)

This requirement ensures that any repairs, servicing, or part replacements are planned, approved, properly recorded, and checked. This helps prevent sensitive information being exposed and avoids accidentally weakening security. Without it, equipment could be serviced without oversight, important settings could be changed or turned off, and when devices are taken off-site for repair, stored information could be left behind or recovered by mistake. This creates a serious risk of data loss or unauthorised access.

The organisation must schedule maintenance using the manufacturer or supplier’s instructions (and its own rules), record exactly what was done, and review the records afterwards. Every maintenance activity—whether carried out on-site or remotely, and whether parts remain on-site or are moved—must be approved and monitored. Any removal of equipment for off-site maintenance must be explicitly authorised by the Authorising Official or the system Security Officer.

Before any equipment leaves the premises, the organisation must securely wipe all stored information, including secret keys and any backup copies and logs. After maintenance, it must check any areas that could have been affected still work correctly. It must also keep clear records showing when the work happened, what was done, who was involved, any escort details, and which components or equipment were removed or replaced.

##### ITSM-controlled maintenance with AO off-site approval and sanitisation evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define MA-2 ODP.01/02/03 requirements mapping and acceptance criteria for ITSM workflow (off-site approval gate, sanitisation evidence, mandatory record fields, closeout verification) | Compliance Manager | Enterprise | 16h | — |
| Configure ITSM “Controlled Maintenance” work-order template with mandatory fields (date/time, maintenance description, personnel names, escort name if applicable, removed/replaced component/equipment identifiers) and validation rules | Service Delivery Manager | Enterprise | 24h | — |
| Implement “Off-site removal” flag with role-based approval routing so AO/System Security Officer approval is mandatory (technician cannot submit/close without gate) | Operations Lead | Enterprise | 32h | — |
| Implement sanitisation evidence capture for off-site removed components/media: require attached sanitisation record/certificate referencing NIST SP 800-88 method and explicitly covering stored data and encryption keys (including configuration backups and logs) | Security Engineer | Enterprise | 24h | — |
| Integrate remote maintenance linkage into the same workflow: require association to remote session record (start/end time, remote operator identity, actions summary where available) and ensure audit trail is retained on the work order | Platform Engineer | Enterprise | 28h | — |
| Build post-maintenance security verification and closeout checklist per component type (configuration integrity, logging/telemetry continuity, restoration/validation where backups involved) with evidence attachments required before closure | Quality Assurance Lead | Enterprise | 24h | — |
| Implement second-person record review sign-off (system owner/security function) ensuring vendor/manufacturer instruction alignment and verification of security-relevant impacts; enforce as a closure prerequisite | Cyber Security Lead | Enterprise | 20h | — |
| Pilot rollout, training, and audit-readiness testing (end-to-end workflow tests, evidence completeness checks, and remediation of workflow edge cases across representative maintenance scenarios) | Project Manager | Enterprise | 32h | £6,000 |
| Total Estimated Effort |  |  | **200h** |  |
| Total Estimated Cost |  |  |  | **£6,000** |

###### Actions Required for Compliance

- [ ] Create an information-technology service management (ITSM) work-order template for controlled maintenance. Make these fields mandatory: date and time, maintenance description, names of the personnel involved, escort name (if applicable), and the identifiers of any components or equipment that were removed or replaced.
- [ ] Implement an “off-site removal” workflow flag that sends approval requests to the Authorised Officer (AO) and the system Security Officer for any removal from organisational facilities.
- [ ] Set rules so that any off-site handover of storage media requires a sanitisation record that meets the requirements of NIST Special Publication 800-88. This record must cover the stored data and the encryption keys, including configuration backups and logs.
- [ ] Link remote maintenance session details to the work-order record, including the start and end times and the remote operator’s identity and a summary of their actions, where this information is available.
- [ ] Add a post-maintenance security verification checklist for each component type, and require supporting evidence to be attached before the work order can be closed.
- [ ] Require a second person to review and formally approve the records to confirm they are complete and that any security-related functions that may have been affected were checked and verified.


---

#### MA-2.2 — Automated Maintenance Activities (Enhancement)

This requirement is about making sure all system maintenance, repairs, and replacements are planned, carried out in a controlled way, and fully recorded from start to finish. Without this, important work could be missed, carried out at the wrong time, or completed without clear evidence of what was changed—making it difficult for the organisation to prove what was done and when, and harder to spot problems or repeat safe fixes.  

To meet this expectation, the organisation must use automated scheduling to plan every maintenance, repair, and replacement activity within agreed maintenance windows, and use automated tools to apply updates and carry out controlled repairs. It must also automatically create maintenance records from the maintenance requests and change logs, keeping them up to date, accurate, and complete, and showing the status of each item as requested, scheduled, in progress, and completed.

##### Automated maintenance lifecycle with ITSM scheduling and CMDB-backed records

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define ITSM maintenance request types, mandatory fields, and workflow validation rules (requested → scheduled → in process → completed/failed) including CI/asset identifiers, environment alignment, risk tier, downtime/rollback/contingency, and security impact classification | Compliance Manager | Enterprise | 24h | — |
| Configure ITSM scheduled maintenance windows with blackout periods and enforce workflow gating (block execution outside valid windows; require approvals and downtime justification for downtime-required activities) | Project Manager | Enterprise | 20h | — |
| Implement ITSM↔CMDB integration for CI mapping and validation (asset tag/serial + environment), including automated checks to prevent drift and to fail fast when CI/environment mismatch occurs | Data Protection Officer | Enterprise | 28h | £6,000 |
| Develop configuration management automation trigger and guardrails (policy-as-code) to run only on approved/scheduled transitions; implement pre-checks (backups/health checks), patch baseline enforcement, and change-size limits | Security Engineer | Department | 40h | £12,000 |
| Build evidence capture and lifecycle status updates (automation run IDs, logs, validation results) and enforce closure blocking until evidence requirements are met; ensure accurate status timestamps for audit | Operations Lead | Enterprise | 32h | — |
| Create CMDB-backed maintenance record generation and continuous refresh logic by correlating ITSM lifecycle events with CMDB/configuration change logs (what changed, when, which automation run performed it) | Platform Engineer | Enterprise | 36h | £8,000 |
| End-to-end testing, audit readiness validation, and operational handover (test scenarios for success/failure/aborted, evidence completeness, and record timeliness/consistency) | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 204h  
**Total Estimated Cost:** £26,000

###### Actions Required for Compliance

- [ ] Set up information technology service management (ITSM) processes for maintenance, repairs, and replacements so that they require the following details: configuration item (CI) or asset, environment, risk tier, the required time window, and a rollback reference.
- [ ] Set up planned maintenance time slots in IT service management (ITSM), and use workflow rules to prevent maintenance work from being carried out outside the approved time slots.
- [ ] Link information technology service management (ITSM) tickets to the configuration management database (CMDB) so that each ticket is connected to the correct, official configuration items (CIs) and checks that environment and asset identifiers are valid.
- [ ] Set up configuration management automation (for example, Ansible) so it runs only when the information technology service management (ITSM) status changes to an approved or scheduled state. It should also enforce the approved patch standards and run required checks before patching.
- [ ] Automatically create maintenance records and update their status based on information from the IT service management (ITSM) lifecycle and the configuration management database (CMDB) and configuration change logs (requested, scheduled, in progress, completed).
- [ ] Require automatic evidence capture (automation run identifiers, logs, and validation results) and do not allow the item to be closed until the evidence has been attached.


---

### MA-3 — Maintenance Tools (Control)

This requirement is about ensuring that only approved maintenance tools are used when fixing or diagnosing systems, and that their use is monitored. Without this, staff could accidentally use the wrong tool, or a harmful tool could be introduced to a device or downloaded, allowing malicious software to enter your organisation’s systems during routine repairs.

To meet this expectation, the organisation must set up a clear, documented process for approving maintenance tools (whether they are software, hardware devices, or firmware). It must assign named people or teams to approve the tools, control how they are used, and monitor their use. The organisation must keep an up-to-date list of approved tools and make sure maintenance work uses only tools on that list, with evidence showing the approval and what each tool is allowed to be used for.

The organisation must also review previously approved tools every 90 days and remove approval for any that are outdated, unsupported, no longer relevant, or no longer used.

##### Approved maintenance tool allowlist with 90-day recertification

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish authoritative “Maintenance Tool Catalogue” template and governance (fields for tool identity/version, type, vendor/source, hash/signature where feasible, scope: systems/environments/use-cases, approval/expiry dates, evidence links) | Compliance Manager | Enterprise | 16h | — |
| Perform tool inventory and catalogue population: identify all maintenance tools used for diagnostics/repairs across environments; normalise identities (name/version), capture hashes/signatures where feasible, and map scope to authorised systems and maintenance use-cases | Operations Lead | Enterprise | 40h | — |
| Define and document the approval workflow in the change/ticketing system (tool request, security risk review steps, authorised approver decision, evidence requirements, recertification/expiry handling) | Project Manager | Enterprise | 24h | — |
| Configure workflow artefacts and operational procedures: ticket forms, required fields, approval routing, and catalogue record linkage (ticket/work order reference to tool execution/usage evidence) | Service Delivery Manager | Enterprise | 16h | — |
| Implement enforcement process at point of use (manual/operational controls): require maintenance sessions to be tied to an approved ticket/work order; verify tool identity against catalogue before execution; restrict installation/execution permissions to approved tool identities via existing access processes | Operations Lead | Enterprise | 32h | — |
| Define monitoring, alerting, and evidence retention requirements (SIEM/monitoring owner runbook): detection criteria for non-allowlisted tool execution, missing ticket/work order reference, and out-of-scope system usage; specify log fields to retain for audit | Security Engineer | Enterprise | 20h | — |
| Execute 90-day recertification cycle: review tool relevance/support/usage, withdraw approval for outdated/unsupported/unused tools, update catalogue outcomes with evidence, and communicate changes to maintenance teams | Compliance Manager | Enterprise | 32h | — |

| Total Estimated Effort | 180h | Total Estimated Cost |
|---|---:|---:|
|  |  | £0 |

###### Actions Required for Compliance

- [ ] Create and keep up to date an official list of maintenance tools, including each tool’s identity and version, and the approved scope of where and how each tool can be used (systems, environments, and use cases).
- [ ] Set up a documented approval process in the change or ticket system. Assign named approvers and record the evidence for each approval, including the ticket ID, approver name, approval date, and the scope of the change.
- [ ] Put controls in place for access to controlled maintenance routes so that only approved tool identities can be installed and run, and only when linked to authorised work orders.
- [ ] Set up central logging and security information and event management (SIEM) checks to monitor maintenance session activity and the identity of the tools used. Create alerts when a tool is not on the approved list (allowlist) or when it targets something outside the agreed scope.
- [ ] Complete a 90-day review to re-check the approved tool catalogue. Remove approval and take away permission to run and install tools that are outdated, no longer supported, irrelevant, or no longer used.
- [ ] Keep records of approvals and re-checks so audits can be completed, and confirm that any tools that have been withdrawn can no longer be used.


---

#### MA-3.1 — Inspect Tools (Enhancement)

This requirement is about making sure the tools used by maintenance staff are trustworthy before they are used, whether they are brought onto the site or downloaded from a supplier. Without this, someone could accidentally (or deliberately) introduce a tool that has been changed in the wrong way, changed without permission, or secretly contains harmful software. That could then be used to disrupt operations, steal information, or cause safety and financial damage.

To meet this expectation, the organisation must set clear rules and step-by-step procedures for checking every maintenance tool before use. This includes checks for unauthorised or improper changes and checks for harmful software. The organisation must also keep a record showing what was checked, when it was checked, and the outcome.

If any tool fails these checks, the organisation must treat it as an incident, follow its incident-handling process, record what happened, and make sure the tool is dealt with appropriately so it is not used again until it has been cleared.

##### Quarantine and verify maintenance tools before use

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define in-scope maintenance tool register, inspection triggers, and acceptance/rejection criteria (including tool identifier/version/package naming conventions) | Compliance Manager | Enterprise | 24h | — |
| Design the maintenance tool intake + quarantine workflow (staging steps, decision gates, evidence requirements, and integration points with incident handling) | System Design Authority | Enterprise | 32h | — |
| Implement intake workflow tooling: controlled intake point(s), managed repository/portal for vendor downloads, and quarantine storage with access controls | Platform Engineer | Enterprise | 56h | £18,000 |
| Configure integrity verification: baseline hash/inventory approach, vendor signature/hash validation where available, and deviation flagging logic | Security Engineer | Enterprise | 40h | £6,000 |
| Implement malicious code scanning for tool packages (executables/scripts/archives/installers) including sandbox/static analysis where feasible; tune for false positives | Security Engineer | Enterprise | 48h | £12,000 |
| Establish incident handling linkage: automatic incident creation on failed checks, quarantine release workflow, and audit trail completeness testing | Operations Lead | Enterprise | 24h | — |
| Run pilot and operational readiness: train maintenance tooling administrators/SOC oversight, execute test cases for brought-in media and vendor downloads, and perform audit sampling dry-run | Project Manager | Enterprise | 32h | — |
| Produce audit-ready documentation and evidence templates (inspection record schema, retention rules, sampling procedure, and runbooks for borderline cases) | Compliance Manager | Enterprise | 20h | — |

**Total Estimated Effort:** 276h  
**Total Estimated Cost:** £36,000

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date list of all maintenance tools that are in scope, including tools supplied by others and tools downloaded from vendors.
- [ ] Set up a controlled intake and staging process that prevents tools from connecting to in-scope environments until the inspection is complete.
- [ ] Set up integrity checks using vendor-provided digital signatures or file hashes where available and approved baselines otherwise.
- [ ] Enable malware scanning for all tool packages, archives, scripts, and installers, and use a sandbox and/or static analysis where this is feasible.
- [ ] Record inspection evidence for every released tool, including the tool identifier, source, date and time, checks performed, results, and scan or report identifiers.
- [ ] Link inspection failures to the organisation’s incident handling process, and quarantine or reject the tool until security clearance is granted.


---

#### MA-3.2 — Inspect Media (Enhancement)

This requirement ensures that any removable or downloaded items used to fix, test, or maintain a system are checked for harmful software before they are used. Without this, a virus or other malicious code could be brought in on a memory stick, software installer, diagnostic package, or even the files that come with a maintenance tool, and then run during maintenance. This could lead to disruption, data loss, or unauthorised access.

To meet this expectation, the organisation must have a clear, documented process for checking maintenance, diagnostic, and test media for malicious code. This includes the maintenance tools themselves and any related documentation, using an approved checking method. Staff responsible for maintenance must follow this process every time and keep evidence in the maintenance records showing the check was completed before use.

If malicious code is found, it must be treated as an incident and handled according to the organisation’s incident response procedures. The result must be recorded and kept.

##### Media inspection airlock with scan evidence before maintenance use

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define the end-to-end “media inspection & release” workflow (ingest → scan/inspect → evidence capture → quarantine/reject or release → connect/use) including decision gates and exception handling | Compliance Manager | Enterprise | 16h | — |
| Select/approve scanning approach for each media type (removable media, downloaded packages, suspicious executables/scripts) and document minimum scan scope, depth, and acceptable tools/mechanisms | Cyber Security Lead | Enterprise | 24h | — |
| Implement ITSM workflow gating: enforce that tickets/work orders cannot move to “Ready for use” without attached scan evidence (fields, mandatory attachments, status transitions) | Service Delivery Manager | Enterprise | 32h | — |
| Build evidence capture template and data model for auditability (media identifier/hash/serial, scanned file list/artifacts, scan tool/version, timestamps/operator, outcome, approval reference) and integrate into the ticketing workflow | Data Protection Officer | Enterprise | 24h | — |
| Configure and operationalise scanning tooling/integration (on-demand/offline scanning for removable media; package scanning for downloads; optional sandbox/detonation integration where available) | Security Engineer | Enterprise | 40h | £18,000 |
| Develop incident routing integration for malicious detections (auto-create incident, preserve evidence, quarantine media, prevent release, link ticket↔incident) | Operations Lead | Enterprise | 24h | — |
| Pilot the workflow with representative maintenance scenarios and perform audit readiness testing (evidence retrieval, timing enforcement, false-positive/exception process, incident triggers) | Project Manager | Business Unit | 24h | — |

**Total Estimated Effort:** 204h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Define and publish an auditable “media inspection and release” process, with a clear scan-before-use checkpoint.
- [ ] Set up IT service management (ITSM) and work-order templates so they must include: the media identifier, a list of scanned files, the scan tool and version used, the date and time (timestamp), the operator’s name, and the scan decision outcome.
- [ ] Add approved malware scanning to the workflow, using on-demand or offline scanning where appropriate, so that scan results are attached before anything is released.
- [ ] Set up workflow controls so media cannot be marked “ready for use” unless there is an attached scan evidence record.
- [ ] Set up automatic routing to the incident response process when scans detect malicious code, including actions to quarantine or block the affected items.
- [ ] Run the full workflow from start to finish using realistic maintenance materials, and confirm that the required audit evidence is recorded before they are used.


---

#### MA-3.3 — Prevent Unauthorized Removal (Enhancement)

This requirement is about making sure any maintenance equipment that could still contain your organisation’s information does not leave your site unless it has been properly checked or made safe. Without this, a laptop, storage drive, or other maintenance device could be taken away and its stored information could be accessed by someone who should not have access. This could lead to data leaks, fraud, and regulatory and reputational damage.

To meet this expectation, the organisation must first define what counts as organisational information. It must then set out and follow a clear process every time maintenance equipment is due to be removed. Before removal, staff must either:

- check and confirm the equipment contains no organisational information, and record the result; or  
- securely clean the equipment so the data cannot be recovered; or  
- destroy the equipment; or  
- keep the equipment on site.

If equipment ever needs to be removed without verification or cleaning, the organisation must obtain an explicit written exemption from the Chief Information Security Officer and the Authorising Official for the affected system. This exemption must state that removal of the specific equipment is authorised. The organisation must keep records of the checks, cleaning or destruction carried out, and any exemptions.

##### Maintenance equipment removal gate with sanitise/verify evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define scope, equipment categories, and sanitise/verify profiles (including allowed outcomes and evidence requirements per equipment/media type) | Compliance Manager | Enterprise | 24h | — |
| Update authoritative asset record model (asset ID, media/storage type, applicable sanitisation/verification profile, and linkage to removal events) | Data Protection Officer | Enterprise | 32h | — |
| Configure ITSM/asset workflow “removal gate” (enforce single allowed outcome, block off-site release without required evidence, and implement outcome-specific mandatory fields) | Platform Engineer | Enterprise | 48h | — |
| Implement verification path evidence capture (standardised checklists/attestations, residual storage/credential/key checks where applicable, and evidence attachment rules tied to asset ID) | Security Engineer | Enterprise | 24h | — |
| Implement sanitise/destruction path evidence capture (integrate/standardise wipe/erase verification logs and destruction certificates/chain-of-custody references; validate evidence completeness) | Operations Lead | Enterprise | 40h | £6,000 |
| Implement retention and exemption paths (retain-on-site enforcement; exemption request workflow requiring explicit dual authorisation by CISO and AO for the affected system; record approvers and audit trail) | Cyber Security Lead | Enterprise | 40h | — |
| Build audit readiness reporting (exportable report/dashboard showing asset ID, outcome, timestamps, evidence references, and exemption approvers; periodic review pack template) | Compliance Manager | Enterprise | 16h | — |
| Pilot, test, and remediate (end-to-end workflow testing, negative testing for blocked releases, evidence quality checks, and go-live readiness) | Project Manager | Enterprise | 32h | £3,000 |

**Total Estimated Effort:** 256h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Set out in policy which maintenance equipment categories are in scope because they may contain organisational information, and specify the required end results for handling them (check, sanitise, destroy, keep, or apply an exemption).
- [ ] Set up the IT service management (ITSM) and asset workflow so that off-site releases are not allowed unless the user selects an approved outcome and attaches supporting evidence linked to the correct asset ID.
- [ ] Use verification checklists and require signed or formally confirmed proof for the “verify” result. Store this proof for each asset and each time the asset is removed.
- [ ] Use sanitisation tools that produce verifiable wipe or erase records, and require those records as proof that the “sanitise” step has been completed.
- [ ] Set up evidence capture for destruction (including uniquely numbered certificates and a documented chain of custody) and make it mandatory when the outcome is “destroy”.
- [ ] Set up an exemption request process that requires clear written approval from both the Chief Information Security Officer (CISO) and the Authorising Officer (AO) for the affected system, and records the exemption for each specific asset.
- [ ] Create and review an auditable report of every removal gate event, including the outcome, references to the supporting evidence, the date and time, and the people who approved any exemptions, on a set schedule.


---

#### MA-3.4 — Restricted Tool Use (Enhancement)

This expectation is about making sure only the right people are allowed to use the special tools used to maintain and fix your systems. If unauthorised staff could use these maintenance tools, they could accidentally cause outages or, worse, make changes that are difficult to detect, potentially leading to service disruption, fraud, or data loss.

To meet this expectation, your organisation must:
- clearly define which tools count as maintenance tools;
- document how each maintenance tool is to be used during maintenance; and
- keep an up-to-date list of the specific people authorised to use each tool.

You must also:
- keep records every time a maintenance tool is used, showing who used it and when; and
- keep maintenance records that link the work carried out to the specific tool used.

Finally, your documented plans and responsibilities must name who carries out maintenance and who oversees information security, and your procedures must include checks that prevent unauthorised use.

##### Privileged maintenance tool access via PAM with tool-specific authorisation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define scope of “maintenance tools” and required maintenance activity linkage fields (work order/change record ID, target system, environment) | Compliance Manager | Enterprise | 16h | — |
| Create tool-to-user authorised register model (data fields, approval workflow, validity windows, segregation of duties rules, audit evidence requirements) and publish governance procedure | Data Protection Officer | Enterprise | 24h | — |
| Implement PAM access policy logic for tool-specific authorisation (named access only, disable shared routes, enforce per-tool/time-window checks, deny-by-default) | Security Engineer | Enterprise | 56h | — |
| Configure PAM session/activity recording and command/session metadata capture; integrate log forwarding to SIEM and validate end-to-end event schema | DevOps Lead | Enterprise | 40h | £12,000 |
| Build/enable maintenance activity correlation: require work order/change record ID at access request and store linkage in PAM/maintenance record; implement automated correlation rules where feasible | Platform Engineer | Enterprise | 32h | — |
| Establish tamper-evident evidence retention (immutable storage/write-once where available), retention schedules, and audit export procedures for auditors | Operations Lead | Enterprise | 24h | £8,000 |
| Run pilot for in-scope maintenance tools, perform access denial/approval testing, and complete evidence pack for MA-3(4) audit readiness | Quality Assurance Lead | Business Unit | 24h | — |

**Total Estimated Effort:** 216h  
**Total Estimated Cost:** £20,000

###### Actions Required for Compliance

- [ ] Take an inventory of all maintenance tools used for maintenance activities across all application and system environments, and categorise them.
- [ ] Define and publish a tool-specific authorised register format that includes: tool name, identity, approval reference, validity dates, and the scope of what it applies to.
- [ ] Set up individual (named) user access for maintenance tools, and turn off shared accounts for those access routes.
- [ ] Set up privileged access management (PAM) so that it only allows sessions when the user’s identity is listed in the authorised register for the specific tool and the request is made within the approved time window.
- [ ] Enable and centralise logging of maintenance tool sessions and commands, and send the logs to security information and event management (SIEM).
- [ ] Update the maintenance ticket and change processes so they must include a maintenance record identifier that privileged access management (PAM) can capture and link to the correct activity.
- [ ] Set record-keeping and tamper-protection controls for privileged access management (PAM) and identity provider (IdP) evidence, and run an initial audit check to confirm that actions taken by the tools can be traced.


---

#### MA-3.5 — Execution with Privilege (Enhancement)

This requirement is about closely monitoring special maintenance tools that have higher access than normal user accounts. That extra access could be misused to view or change sensitive information and systems. If these tool uses are not monitored and recorded, unauthorised activity could go unnoticed, mistakes could be difficult to trace, and the organisation would struggle to prove who did what, when, and why.

To meet this expectation, the organisation must:
- clearly define which maintenance tools count as “higher access”
- keep an up-to-date list of the specific people authorised to use each tool
- have written rules and step-by-step instructions for how each tool must be used

Every time an authorised person uses a higher-access maintenance tool, the organisation must record:
- the person’s identity
- the time of use
- the tool used
- the stated purpose

The organisation must also keep maintenance records that can be linked back to these tool-use entries. The organisation must then review these records to confirm that only authorised use occurred and that each use matches the approved maintenance purpose.

##### Privileged maintenance tool monitoring with ticket-linked audit logs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create privileged maintenance tool allow-list (register) with stable tool identifiers and qualifying criteria | Compliance Manager | Enterprise | 24h | — |
| Design controlled execution path (jump host/PAM/session workflow) enforcing named-user execution and allow-list enforcement | System Design Authority | Enterprise | 40h | — |
| Implement ticket/purpose capture integration (work order/change ID validation + purpose field stored with execution context) | Software Lead | Enterprise | 56h | — |
| Configure privileged execution telemetry collection and normalisation into SIEM (identity, timestamp, tool ID, purpose/ticket reference) | Security Engineer | Enterprise | 48h | — |
| Implement correlation/linking logic between execution events and approved tickets/work orders (including environment/asset identifiers where available) | Platform Engineer | Enterprise | 40h | — |
| Build alerting and operational monitoring (missing/invalid ticket reference, non-authorised identity, execution outside approved windows if tracked) | Operations Lead | Enterprise | 32h | — |
| Establish periodic review process and audit evidence pack (monthly/quarterly review workflow, sampling, sign-off records) | Compliance Manager | Enterprise | 24h | — |

Total Estimated Effort: **264h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Create and get approval for an approved list (allow-list) of privileged maintenance tools. Each tool must have a unique identifier and a defined level of execution privilege.
- [ ] Limit the use of privileged tools to an approved, identity-checked route (such as a jump host or administrator workstation, or a privileged access management session manager), using named user accounts.
- [ ] Link the privileged access workflow to the change or work-order system so that a valid ticket reference is required and the reason for the maintenance is recorded.
- [ ] Set up audit logging at the time the task is carried out to record the user, date and time, the tool used, and the ticket or purpose, and send it to the security information and event management (SIEM) system.
- [ ] Set up a link between logs and tickets so that every use of a privileged tool can be traced back to the approved maintenance record.
- [ ] Set up detection rules and alerts for privileged tool use when there is no valid ticket reference or when the user is not an authorised identity.
- [ ] Carry out and record periodic reviews of privileged tool execution logs to confirm authorisation and ensure the activity matches its intended purpose.


---

#### MA-3.6 — Software Updates and Patches (Enhancement)

This requirement is about making sure the tools your organisation uses to maintain and manage systems are kept up to date, with the latest fixes and security updates installed. If these maintenance tools use outdated or unpatched software, they can become an easy way for attackers to gain access or take advantage of weaknesses, which can cause major disruption and expensive recovery.

To meet this expectation, the organisation must clearly define which maintenance tools are covered, create and follow step-by-step procedures to check each tool’s update status and apply updates when needed, and confirm that the tool documentation matches what is actually installed. It must also ensure that only authorised people carry out these checks and updates, assign named responsibility for the work, and keep reliable records showing who used the tools, what was checked, what updates were applied (or that none were needed), and the result each time—so the organisation can demonstrate that everything remains current.

##### Automate maintenance-tool patch compliance with auditable evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Establish authoritative in-scope maintenance-tool scope (tool list, owners, install locations, runbook set mapping, and data fields for inventory) | Project Manager | Enterprise | 24h | — |
| Define patch baselines and exception governance (latest vendor security release mapping, baseline per tool, exception expiry rules, compensating controls template) | Compliance Manager | Enterprise | 32h | — |
| Design auditable inspection workflow and evidence model (cadence, compliance logic, evidence schema, operator/service-account attribution, retention requirements) | Security Engineer | Enterprise | 24h | — |
| Implement inspection automation (inventory collection + version/patch comparison against baselines; generate compliance reports and non-compliance work items) | Platform Engineer | Enterprise | 56h | £18,000 |
| Implement controlled update mechanism (pre-checks, change-window gating, deployment orchestration, before/after evidence capture, rollback criteria) | DevOps Lead | Enterprise | 64h | £12,000 |
| Integrate documentation/runbook alignment checks (validate inventory record references against installed tool version/patch state; flag and route mismatches) | Quality Assurance Lead | Enterprise | 24h | — |
| Operationalise accountability and audit readiness (authorised execution controls, access restrictions, evidence retention/exports, audit sampling support) | Data Protection Officer | Enterprise | 24h | — |

Total Estimated Effort: **248h**  
Total Estimated Cost: **£30,000**

###### Actions Required for Compliance

- [ ] Create and get approval for an official list of all in-scope maintenance tools, including who is responsible for each one, where they are installed, and the related documentation and runbooks.
- [ ] Set a patch baseline for each tool (either the latest vendor security release or an approved baseline set) and set up exception rules with expiry dates.
- [ ] Set up an automated check that records each tool’s current version and patch level, then compares it with the agreed baseline.
- [ ] Set up a controlled update process (software distribution and configuration management) that applies patches only during approved change windows, and keeps records showing the system state before and after the update.
- [ ] Use privileged access management (PAM) and identity and access management (IAM) roles, along with service account controls, to ensure only authorised systems can run inspection and update workflows.
- [ ] Store evidence from inspections and updates (inspection results, deployment records, and operator identity) in an audit-ready file, and review any queues of non-compliance.


---

### MA-4 — Nonlocal Maintenance (Control)

This requirement ensures that any remote help or troubleshooting carried out on your systems is tightly controlled, properly authorised, and recorded from start to finish. Without it, someone could use remote access to make unauthorised changes, run hidden checks, or leave access enabled after the work is finished—raising the risk of fraud, disruption, or data loss.

The organisation must approve each remote maintenance and diagnostic activity before it starts and must actively monitor it while it is under way. Only tools the organisation has explicitly allowed may be used, and these approved tools and conditions must be written into the system’s security plan.

Starting any remote maintenance session must require strong identity checks using more than one proof of who the person is, and these checks must not be reusable. The organisation must keep clear records of who did what, when, and which tools were used. As soon as the maintenance is completed, it must immediately end both the remote session and the underlying network connection.

##### Approved nonlocal maintenance via ZTNA with MFA and auto teardown

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Design target-state architecture for ZTNA/jump-based nonlocal maintenance (routing, session lifecycle, metadata capture, termination verification) | System Design Authority | Enterprise | 24h | — |
| Define IdP maintenance access policy-as-code (time-bound, target-scoped, protocol-scoped, deny-by-default) including step-up MFA requirements for maintenance sessions | Cyber Security Lead | Enterprise | 32h | — |
| Implement ticket/work-order gated access automation (approved ticket → ephemeral access grant; ticket closed/complete → revoke) with correlation context (ticket ID) | Platform Engineer | Enterprise | 40h | — |
| Configure ZTNA/jump service to enforce controlled path for maintenance traffic (allow-list of destinations/protocols; session start/stop hooks; device posture where available) | Infrastructure Lead | Enterprise | 32h | £15,000 |
| Implement phishing-resistant, replay-resistant MFA for maintenance (FIDO2/passkeys or certificate-based) and enforce step-up even for existing sessions | Security Engineer | Enterprise | 24h | £8,000 |
| SIEM/SOC integration for active monitoring and audit evidence (ingest ZTNA/jump telemetry + IdP session events; dashboards/alerts; immutable log retention mapping) | Operations Lead | Enterprise | 28h | £6,000 |
| Implement automatic teardown and verification (revoke ZTNA application/session; close tunnel/connection; confirm end-to-end in logs; regression tests for “ticket closed” and “maintenance complete”) | DevOps Lead | Enterprise | 24h | — |
| Update system security plan and operational runbooks (permitted tools/conditions allow-list where feasible; evidence requirements; incident/exception handling; periodic access review process) | Compliance Manager | Enterprise | 20h | — |

|  |  |  | **Total Estimated Effort** | **Total Estimated Cost** |
|---|---|---|---:|---:|
|  |  |  | **224h** | **£29,000** |

###### Actions Required for Compliance

- [ ] Set up a dedicated identity provider (IdP) and zero trust network access (ZTNA) maintenance access policy for specific systems and protocols, with a maximum session length.
- [ ] Link work-order and change approvals to automated, time-limited access permissions for non-local maintenance.
- [ ] Set up maintenance sessions so that, before the session starts, users must complete step-up, phishing-resistant, replay-resistant multi-factor authentication (MFA) (for example, FIDO2 or a certificate).
- [ ] Send all maintenance traffic that comes from outside the local network through a controlled gateway, jump host, or zero trust network access (ZTNA) path, and record monitoring information about each session from start to finish.
- [ ] Set up security information and event management (SIEM) logging for identity provider (IdP) session events and for gateway/zero trust network access (ZTNA) session start and stop events, and link the resulting logs to the work order or ticket ID.
- [ ] Set up automatic closing of user sessions and network tunnels when a ticket is closed or when a specific “maintenance complete” message is sent.
- [ ] Update the system security plan to record which remote maintenance tools and conditions are allowed, as enforced by the gateway.


---

#### MA-4.1 — Logging and Review (Enhancement)

This requirement ensures that every time someone connects from outside the organisation to carry out remote maintenance or to run diagnostics, the organisation keeps a clear record of what happened and then checks those records for anything unusual. Without this, a legitimate maintenance or troubleshooting session could be used to hide unauthorised access, unexpected changes, or suspicious activity—problems that might not be noticed until real damage has been done.

To meet this requirement, the organisation must record all required activity details for every remote maintenance session and every diagnostic session, and then regularly review those records to identify unexpected behaviour, such as actions outside the agreed purpose or activity at unusual times. These reviews must be carried out both by the people responsible for maintenance and by those responsible for information protection and audit/review. The organisation must keep evidence showing that each session was checked and that any concerns were followed up appropriately.

##### Brokered remote sessions with AU-2a logging and review evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select and confirm session-broker architecture and enforcement points (approved remote paths, bypass prevention approach, target system/service mapping model) | System Design Authority | Enterprise | 24h | — |
| Implement broker session workflow: ticket/reference validation, target scope/time-window enforcement, identity binding via enterprise IdP, and session authorisation checks | Security Engineer | Enterprise | 56h | £25,000 |
| Configure AU-2a-aligned structured audit event generation for nonlocal maintenance (ma-04.01_odp.01) and diagnostic sessions (ma-04.01_odp.02), including lifecycle (start/end), authorisation/scope checks, and action mapping | Security Engineer | Enterprise | 40h | — |
| Integrate broker audit event forwarding to SIEM/logging platform with integrity protections, normalisation, and retention alignment; validate end-to-end audit completeness | Platform Engineer | Enterprise | 32h | £8,000 |
| Implement central log access controls and tamper-evidence controls for broker audit records (RBAC, restricted write paths, immutable/append-only storage where supported) | Cyber Security Lead | Enterprise | 24h | — |
| Define and implement review workflow with evidence capture (SOC triage rules, anomaly criteria for scope/time/duration/frequency, review cadence, and linkage back to session + ticket) | Compliance Manager | Enterprise | 32h | — |
| Execute integration testing, pilot rollout, and audit evidence validation (test cases for in-scope sessions, negative tests for bypass attempts, SIEM query packs, and evidence pack sign-off) | Quality Assurance Lead | Enterprise | 40h | £5,000 |
| Operationalise: runbooks, monitoring/alerting for broker failures and missing audit events, and training for SOC/reviewers and broker operators | Operations Lead | Enterprise | 24h | — |

Total Estimated Effort: **272h**  
Total Estimated Cost: **£38,000**

###### Actions Required for Compliance

- [ ] Identify and record every in-scope remote access route used for non-local maintenance and diagnostics, and remove or disable any direct bypass routes.
- [ ] Set up the session broker so it only starts a session after the user has been authenticated and the ticket, permissions (scope), and allowed time window have been verified.
- [ ] Link audit events created by the broker to the organisation’s AU-2a event lists for non-local maintenance and diagnostic sessions
- [ ] Set up the broker to send audit event records to the central security information and event management (SIEM) system, with protections to keep the records trustworthy and with retention periods suitable for audit evidence.
- [ ] Set up a review process (who does what, how often, and how issues are escalated) that records the results of each review and links them to the relevant session or ticket references.
- [ ] Run a test set using example user sessions to confirm that all required AU-2a events are covered, and review the proof (evidence) that is produced.


---

#### MA-4.3 — Comparable Security and Sanitization (Enhancement)

This requirement is about ensuring that when someone performs remote maintenance or checks your equipment, they do not accidentally expose your information or introduce harmful software.

Without this, a remote technician could:
- access your systems from a less secure environment,
- handle a component in a way that leaves your confidential information behind, or
- introduce malware during the work, which could then be quietly connected back to your live systems.

To meet this requirement, the organisation must either:
- use a maintenance or diagnostic setup provided by the service provider that has security protections at least as strong as those on the equipment being serviced, and keep evidence of this; **or**
- remove the component before the remote work begins.

If the component is removed, it must be:
1. cleaned to remove organisational information,
2. checked after the service for potentially malicious software and cleaned again if needed,
3. and only then reconnected.

The organisation must document the process, assign responsible roles, ensure service provider agreements reflect this approach, and keep records showing the correct sequence of steps and the results.

##### Provider maintenance enclave with attested comparable security

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define “comparable security” baseline per system class (server/workstation/network device/cloud workload) mapped to serviced-system security baseline, including identity, privileged access, logging/auditing, malware/endpoint protections, secure configuration, and network segmentation | Security Architecture Lead | Enterprise | 40h | — |
| Produce provider maintenance enclave approval criteria and evidence pack template (architecture diagram requirements, control mapping, configuration evidence, attestation requirements, and acceptance checklist) | Compliance Manager | Enterprise | 24h | — |
| Design and implement provider connectivity pattern using ZTNA/SASE (or equivalent brokered access): allowlisted destinations, restricted admin tooling, segmentation boundaries, and session scoping to maintenance tasks | Infrastructure Lead | Enterprise | 56h | £25,000 |
| Implement identity-first maintenance access controls: named accounts, phishing-resistant MFA, conditional access, role-based authorisation limited to maintenance tasks, and integration with PAM/IdP workflows | Privileged Access Management (PAM) / Identity Team | Enterprise | 48h | £40,000 |
| Enable session-level accountability and monitoring for provider maintenance (session recording where feasible, command/action logging, SIEM ingestion, retention rules, and work-order correlation identifiers) | SOC / Monitoring Team | Enterprise | 40h | £18,000 |
| Create “gate reconnection/enablement” workflow: internal approval and verification step for any temporary security posture changes (e.g., firewall rule changes, credential enablement, tool installation), including documented rollback/verification evidence | Operations Lead | Enterprise | 32h | — |
| Update ITSM/Service Management process and controls to enforce enclave usage per work order (mandatory enclave approval reference, evidence attachments, audit trail requirements, and exception route using remove-and-sanitise) | Service Delivery Manager | Enterprise | 24h | — |
| Run provider onboarding pilots and assurance testing (2–3 provider enclaves): validate evidence against baseline, test access scoping and logging, and produce audit-ready reports and remediation actions | Project Manager | Business Unit | 32h | £6,000 |

**Total Estimated Effort:** 296h  
**Total Estimated Cost:** £89,000

###### Actions Required for Compliance

- [ ] Set security baseline standards that can be compared for each type of service system, and link each one to the organisation’s overall security baseline.
- [ ] Set up an approval process that requires proof from the provider enclave before any non-local maintenance can start.
- [ ] Require named user accounts, use phishing-resistant multi-factor authentication (MFA), and apply least-privilege access control for provider maintenance sessions
- [ ] Set up brokered or segmented access for provider maintenance connections (for example, zero trust network access (ZTNA) or secure access service edge (SASE) using approved destination lists).
- [ ] Set up and centralise records of maintenance sessions, and send the event details to the security information and event management (SIEM) system so they are kept for audit and record-keeping purposes.
- [ ] Add an IT service management (ITSM) work-order checkpoint that points to the approved secure enclave and requires a check and approval of the security status after maintenance is completed.
- [ ] Keep auditable records for each work order, including the enclave approval reference, session evidence, and the approvals for reconnection and enabling.


---

#### MA-4.4 — Authentication and Separation of Maintenance Sessions (Enhancement)

This requirement is about ensuring that anyone who connects from outside the office to carry out system maintenance uses a specially secured route that is clearly different from normal access. Without these protections, an attacker could trick staff into using stolen login details, or could use a maintenance connection to access parts of the system they are not allowed to reach, which could lead to disruption or data loss.

To meet this expectation, the organisation must require phishing-resistant multi-step sign-in for every remote maintenance session. This must use a security key approach that responds to a live challenge, so old sign-in attempts cannot simply be reused. The organisation must also keep maintenance communications separate from all other network communications to the system. This can be done by using physically separate connections, or—if that is not used—by using logically separate, encrypted pathways.

##### Maintenance-only ZTNA with FIDO2/WebAuthn and encrypted session separation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Confirm target ZTNA/access broker capabilities and design the maintenance-only access path (policy scope, maintenance app set, routing/authorisation model, encryption approach) | System Design Authority | Enterprise | 16h | — |
| Implement maintenance-only ZTNA policy: create dedicated non-local maintenance policy, bind to explicit maintenance application set, and deny general apps/admin apps from the same maintenance session context | Security Engineer | Enterprise | 24h | — |
| Configure phishing-resistant, replay-resistant authentication at the ZTNA entry point using FIDO2/WebAuthn only (no weaker MFA fallbacks) and enforce challenge-response for maintenance sessions | Security Engineer | Enterprise | 20h | — |
| Integrate/adjust IdP conditional access rules to ensure non-local maintenance sessions are evaluated against the maintenance policy and that only WebAuthn/FIDO2 methods satisfy the requirement | Data Protection Officer | Enterprise | 16h | — |
| Enforce encrypted session separation end-to-end for maintenance traffic (ZTNA tunnel/channel configuration, TLS settings, and verification that maintenance sessions cannot reach non-maintenance network services) | Infrastructure Lead | Enterprise | 20h | — |
| Implement audit evidence generation and SIEM forwarding: log ZTNA session establishment, MFA method (WebAuthn/FIDO2), maintenance policy match, target application, source location (non-local), and authorisation decisions | Compliance Manager | Enterprise | 16h | — |
| Build and execute validation tests for acceptance criteria (password-only/OTP-only failure, fresh WebAuthn challenge per attempt, maintenance-only reachability, and denial of non-maintenance apps/services) with documented results | Quality Assurance Lead | Enterprise | 24h | — |
| Produce audit-ready documentation pack (control mapping to NIST MA-4(4) enhancement, configuration screenshots/exports, test evidence, log retention notes, and operational runbook for ongoing maintenance) | Compliance Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 148h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create a clearly defined list of applications that are allowed for maintenance only, and block access to every other application that is not on that list.
- [ ] Set up the identity provider (IdP) and zero trust network access (ZTNA) integration so that the maintenance-only policy requires multi-factor authentication (MFA) using FIDO2/WebAuthn, with no weaker MFA fallback options.
- [ ] For every non-local maintenance session attempt, enable and verify Web Authentication (WebAuthn) challenge-response, and block older (legacy) authentication methods for maintenance.
- [ ] Set up encrypted, separate maintenance connections using the zero trust network access (ZTNA) access broker, and control the routing so maintenance sessions cannot access general network services.
- [ ] Set up audit logging to record when a non-local maintenance session is started, which multi-factor authentication (MFA) method is used (WebAuthn/FIDO2), which target application is involved, and the result of the policy decision.
- [ ] Run validation tests to confirm that attempts using only a password or only a one-time passcode (OTP) are rejected, and that maintenance sessions cannot access non-maintenance endpoints.


---

#### MA-4.5 — Approvals and Notifications (Enhancement)

This requirement is about ensuring that any maintenance carried out on your systems from outside the usual location is properly checked and that the right people are informed in advance. Without this, important changes could be made without the right oversight, increasing the risk of service disruption, accidental exposure of sensitive information, or delays in responding if something goes wrong.

To meet this requirement, the organisation must get approval for every non-local maintenance session before it starts. The Information System Security Officer and the System Owner must both agree that the planned work is appropriate. The organisation must also notify the Information System Security Officer, the System Owner, and the on-call Incident Response Lead of the planned date and time for each non-local maintenance session. This notification can be sent by the maintenance staff, as long as it reaches the named recipients. The people approving the work must have enough knowledge to judge whether the maintenance is suitable.

##### Dual-approval workflow and date/time notifications for nonlocal maintenance

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define Nonlocal Maintenance workflow requirements (fields, states, dual-approval rules, mandatory evidence) and map to MA-4(5) control objectives | Compliance Manager | Enterprise | 16h | — |
| Configure/extend ITSM workflow for Nonlocal Maintenance (ticket type, mandatory fields incl. planned start/end with timezone, scope/justification, remote access ticket reference) | ITSM/Service Management Owner | Enterprise | 40h | — |
| Implement dual-approval enforcement (ISSO + System Owner) and block progression to “Approved/Scheduled/Ready to start” until both approvals are recorded; restrict approver identities to approved role groups | Security Engineer | Enterprise | 32h | — |
| Integrate remote access tooling with approved ITSM ticket ID validation (ensure remote access cannot be initiated without referencing an approved ticket) | Platform Engineer | Enterprise | 48h | — |
| Configure automated notifications for planned date/time (submission and/or approved/scheduled stage) to ISSO, System Owner, and on-call incident response lead; integrate with on-call routing (PagerDuty/Opsgenie) for current lead | DevOps Lead | Enterprise | 32h | £6,000 |
| Implement audit-ready evidence capture and retention (approval identities/timestamps, planned date/time, notification delivery logs/message IDs, correlation between ITSM ticket and remote access session) | Data Protection Officer | Enterprise | 24h | — |
| Test, run parallel pilot, and produce implementation evidence pack (workflow test cases, negative tests for missing approvals/ticket IDs, notification verification, audit trail validation) | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 236h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Create a dedicated information technology service management (ITSM) workflow for non-local maintenance. Make these fields mandatory: the planned start date and time (including the time zone) and the maintenance scope.
- [ ] Set up workflow enforcement so that execution or scheduling is blocked until approval records are logged for both the information system security officer (ISSO) and the system owner.
- [ ] Link the remote access tool to the IT service management (ITSM) ticket, so remote access is only granted when there is an approved non-local maintenance ticket ID.
- [ ] Set up automated notifications when a request is submitted and when it is approved, to the Information System Security Officer (ISSO), the System Owner, and the current on-call incident response lead, including the planned date and time.
- [ ] Set up and limit who can approve actions in the workflow to only the Information System Security Officer (ISSO) and System Owner role groups.
- [ ] Add an internal pre-approval review step for high-risk maintenance categories to ensure approvers have enough knowledge of the systems involved.
- [ ] Turn on and keep audit logs for approval decisions, notification delivery, and linking the approved ticket to the related maintenance session.


---

#### MA-4.6 — Cryptographic Protection (Enhancement)

This requirement is about protecting any remote maintenance or diagnostic messages. It ensures that only the right people can access them, and that no one can secretly alter them while they are being sent.

Without strong protection, an unauthorised person could intercept a remote session, pretend to be a trusted party, and then:
- insert malicious code,
- make unauthorised changes to settings, or
- steal sensitive organisational information,

which could harm business or mission outcomes.

To meet this expectation, the organisation must configure all remote (non-local) maintenance and diagnostic communications to use the latest secure web-style encryption:
- Transport Layer Security 1.3 (TLS 1.3),
- using Advanced Encryption Standard 256-bit Galois/Counter Mode (AES-256-GCM) for both keeping the data secret and detecting tampering, and
- using Elliptic Curve Diffie-Hellman Ephemeral (ECDHE) for key exchange.

The organisation must also require both sides to prove their identity using digital certificates before any connection is allowed.

Finally, the organisation must use only cryptographic components that have been validated as meeting Federal Information Processing Standards 140-3 (FIPS 140-3), and must keep evidence showing which validated modules are in use.

##### Enforce mTLS over TLS 1.3 for nonlocal maintenance/diagnostics

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Identify all nonlocal maintenance/diagnostic communication paths and map them to enforcement point(s), including vendor portals, VPN/remote support tunnels, diagnostic consoles, and API/SSH-over-tunnel workflows | Compliance Manager | Enterprise | 24h | — |
| Define TLS 1.3 + AES-256-GCM + ECDHE + mTLS cryptographic policy baseline and acceptance criteria (including required certificate validation and revocation/validity checking approach) | Security Architect | Enterprise | 16h | — |
| Select and validate the TLS/mTLS enforcement component(s) that use FIPS 140-3 validated cryptographic modules; document module identifiers/validation evidence and confirm suitability for TLS 1.3 enforcement | Cyber Security Lead | Enterprise | 24h | £8,000 |
| Implement routing enforcement so all identified maintenance/diagnostic traffic is forced through the gateway/reverse proxy with no bypass paths (network rules, firewall/NAT, proxy routing, and deny-by-default where applicable) | Infrastructure Lead | Business Unit | 32h | — |
| Configure TLS 1.3-only listener(s) with AES-256-GCM and ECDHE, and enforce mTLS (required client certs, trust anchors, expiry checks, and CRL/OCSP configuration as applicable) | Platform Engineer | Department | 40h | — |
| Integrate/extend PKI and certificate lifecycle for maintenance/diagnostic clients (issuance profiles, trust chain management, revocation publishing/availability, and operational runbooks for renewal/rollover) | Data Protection Officer | Enterprise | 24h | £3,000 |
| Produce audit-ready evidence pack: exported gateway/TLS configuration, negotiated cipher/TLS version verification results, mTLS enforcement test results, and retained FIPS 140-3 module validation references | Compliance Manager | Enterprise | 24h | — |

| Total Estimated Effort | 204h |  |
|---:|---:|---:|
| Total Estimated Cost |  | £11,000 |

###### Actions Required for Compliance

- [ ] Identify and list every non-local maintenance and diagnostic communication route, and document any possible ways to bypass them.
- [ ] Set up the maintenance and diagnostic enforcement endpoint to use Transport Layer Security version 1.3 (TLS 1.3) only, with encryption using AES-256-GCM and key exchange using Elliptic Curve Diffie-Hellman Ephemeral (ECDHE).
- [ ] Set up mutual certificate authentication, and require client certificates for every maintenance and diagnostic session.
- [ ] Check that a certificate is valid (including the trust chain, expiry date, and whether it has been revoked or is still valid) before starting the session.
- [ ] Select and set up Transport Layer Security (TLS) termination components that use Federal Information Processing Standards (FIPS) 140-3 validated cryptographic modules, and keep records showing the cryptographic module validation evidence.
- [ ] Prevent direct access to maintenance and diagnostic services, so all traffic must pass through the enforcement point(s), and confirm this using test “handshakes”.


---

#### MA-4.7 — Disconnect Verification (Enhancement)

This expectation is about ensuring that when remote help or troubleshooting is finished, the access routes used for that work are fully closed off. If access is not properly ended, someone could potentially reuse it to get back in, get around safeguards, or keep access longer than intended—creating a real risk of unauthorised access and misuse.

To meet this expectation, the organisation must, after each completed period of remote (non-local) maintenance and diagnostics, review the relevant records to confirm that both the remote user session and the underlying network connection(s) created for that work have been ended and are no longer available. The organisation should clearly connect these checks to the specific maintenance activity, carry out the verification only after the work is marked complete, and keep dated evidence showing what was checked and the result, including references to the session and network termination records used.

##### Automated disconnect verification after non-local maintenance

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define correlation identifier schema and required log fields for non-local maintenance (user, source IP, destination system, gateway/tunnel/session ID, maintenance/work-order/ticket ID) and publish implementation standard | Compliance Manager | Enterprise | 16h | — |
| Implement/extend remote-access gateway/ZTNA/bastion logging configuration to emit session lifecycle and network teardown events with the correlation keys (including time synchronisation requirements) | Infrastructure Lead | Enterprise | 24h | £3,000 |
| Build SIEM/log queries and correlation logic to (a) retrieve all session/network events linked to a completed maintenance/work-order ID and (b) verify termination/disconnect and teardown occur after the completion timestamp | Security Engineer | Enterprise | 32h | £8,000 |
| Integrate verification trigger into the maintenance workflow (ticket/change system) to capture completion timestamp, pass correlation keys to the automation job, and ensure idempotent execution | Platform Engineer | Enterprise | 24h | — |
| Create immutable “Disconnect Verification” evidence record model (including query/time range, event references/hashes, pass/fail outcome, and approver/exception linkage) and implement retention controls | Data Protection Officer | Enterprise | 16h | — |
| Implement exception handling workflow: raise named approver exception when evidence is missing/delayed; optionally support forced teardown with explicit authorisation and full audit trail | Operations Lead | Enterprise | 24h | — |
| End-to-end testing and audit readiness: test across representative remote-access paths, validate evidence completeness, and produce an audit pack (test results, query samples, evidence retention mapping) | Quality Assurance Lead | Enterprise | 24h | £2,500 |
| Operational rollout: runbook, monitoring/alerting for verification failures, and training for SOC automation and network operations | Service Delivery Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 176h  
**Total Estimated Cost:** £13,500

###### Actions Required for Compliance

- [ ] Ensure that all remote maintenance and diagnostic work that is not performed on-site uses only approved remote-access gateways (also known as bastions). Use consistent reference details for each activity, including the relevant ticket or work-order ID, the user name, and the session or tunnel ID.
- [ ] Set up remote access and network equipment to record, with date and time stamps, both (1) when a session ends and (2) when the network connection is closed, using matching reference keys so events can be linked together.
- [ ] Set up the maintenance process so that checks are only started after the work ticket (or work window) is marked as completed, with the completion time recorded.
- [ ] Set up security information and event management (SIEM) and log-analytics checks that, for each completed time window, confirm that termination events are recorded after the window ends for both the session and the network connection(s).
- [ ] Create and securely store a record of the Disconnect Verification decision that can be audited later, showing the exact log searches and event IDs used to decide whether it passed or failed.
- [ ] Set up an exception process for cases where termination evidence is missing or arrives late, including named approvers and documented steps for how the case will be handled.


---

### MA-5 — Maintenance Personnel (Control)

This requirement is about ensuring that only approved maintenance staff—including external suppliers—are allowed to work on your systems, and that they have the right level of access for the task. Without this, the wrong person could tamper with equipment or software, access sensitive information, or make changes that are difficult to trace—particularly when maintenance is arranged at short notice or without someone from your organisation present to oversee it.

To meet this expectation, the organisation must:
- Set up a clear, documented process to approve maintenance staff and organisations.
- Keep an up-to-date record of who is allowed to maintain which systems, and update it whenever permissions change.
- Check that any maintenance worker who is not escorted has the correct access permissions before starting work.
- Appoint internal staff who are suitably authorised and technically capable to supervise maintenance activities when the external worker does not have the required access.

If temporary access is needed, it must be limited to a specific time period and recorded.

##### Authorised maintenance access workflow with time-bound credentials

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define MA-5 authorised maintenance workflow requirements (escorted/unescorted rules, supervisor criteria, temporary credential risk criteria, evidence requirements) and produce workflow specification | Compliance Manager | Enterprise | 24h | — |
| Configure ITSM workflow (e.g., ServiceNow) for maintenance work orders: mandatory fields (work order reference, maintenance identity/vendor, systems/areas, activities, escorted flag, maintenance window, requested access level) and start/stop gating logic | Project Manager | Enterprise | 40h | — |
| Implement authoritative “authorised maintenance list” in IAM/GRC (data model, Active/Inactive status, allowed systems/areas, allowed activities, escalation path) and integrate request validation against the list | IAM/PAM engineer | Enterprise | 56h | — |
| Build unescorted access verification enforcement: entitlement mapping to exact systems/roles, time-window checks, deny/pause behaviour, and escalation/exception handling | Security Engineer | Enterprise | 48h | — |
| Implement time-bound temporary credential issuance via workflow (one-time/short-lived, bound to work order + maintenance window, issuance/expiry recording, revocation/expiry automation hooks) | Platform Engineer | Enterprise | 64h | £12,000 |
| Implement supervisor assignment and validation for restricted access scenarios (supervisor must be authorised + technically competent; workflow prevents unescorted execution without approved supervisor where required) | System Design Authority | Enterprise | 32h | — |
| Configure audit-ready evidence generation and retention (approval trail, list lookups, access checks, credential issuance/expiry, supervisor assignment, work order linkage) and validate auditor traceability with test cases | Quality Assurance Lead | Enterprise | 40h | — |

Total Estimated Effort: **304h**  
Total Estimated Cost: **£12,000**

###### Actions Required for Compliance

- [ ] Define and document the process for approving maintenance work, including the rules for whether staff must be escorted or can work unescorted, and what proof or evidence is required.
- [ ] Set up identity and access management (IAM) and information technology service management (ITSM) integration so that when maintenance work orders are created, the system checks access rights and requires approval before changes are made.
- [ ] Create and keep an official, approved maintenance list that records: which systems or areas are allowed, which maintenance activities are allowed, and the current status.
- [ ] Set unescorted maintenance to be blocked unless the required access authorisations match the work order scope before the start time.
- [ ] Set up time-limited temporary access credentials using privileged access management (PAM) and just-in-time (JIT) access only through the approved workflow, and record when each credential is issued and when it expires, linked to the relevant work order.
- [ ] Put in place controls that require internal authorised, technically competent supervisors whenever the requested access cannot be fully granted.
- [ ] Check that audit evidence is produced correctly by running end-to-end tests for authorised, unescorted, and temporary-credential maintenance scenarios.


---

#### MA-5.1 — Individuals Without Appropriate Access (Enhancement)

This expectation is about stopping sensitive information from being viewed, copied, or altered during maintenance work by people who do not have the required clearance or permission to access it. Without these safeguards, an unauthorised visitor could see confidential information while repairs are being carried out, or leave behind information on parts of the system that still store data.

To meet this expectation, the organisation must have clear procedures for using maintenance staff. These procedures must ensure that maintenance staff are always escorted and supervised by approved staff who are fully cleared, properly authorised, and technically competent.

Before any work begins, the organisation must remove or clear any temporary stored data. It must also remove or physically disconnect any storage media that contains data, and then secure that media.

If any part cannot be cleared, removed, or disconnected, the organisation must isolate it in a locked area, disconnect all connections, allow only read-only access, and record all activity until the clearing work is complete.

##### Escort-gated maintenance sessions with media protection and logging

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the escort-gated maintenance control design (work order/system binding, concurrence rules, step-up auth, session binding, and failure modes) and produce an implementation-ready security plan aligned to MA-5(1) and ma-05.01_odp | System Design Authority | Enterprise | 24h | — |
| Implement identity attributes and eligibility model: define “maintenance eligibility/ineligibility” flags, map HR/contractor status and clearance/authorisation evidence into IdP claims, and implement authoritative attribute propagation | IAM Engineer | Enterprise | 32h | — |
| Build/implement the escort-gated maintenance workflow in the application/portal (IdP/authorisation enforcement): require work order ID, system ID, maintenance window, ineligible identity, escort identity; deny maintenance/diagnostic interfaces unless escort concurrence is validated for the same work order/system | Software Lead | Enterprise | 56h | — |
| Configure step-up authentication and session binding for escorts (phishing-resistant MFA) and enforce concurrent authorisation checks at session start and during session lifetime | Security Engineer | Enterprise | 24h | £18,000 |
| Implement pre-work media protection hard gates: integrate maintenance workflow with evidence attestation (volatile sanitisation confirmation; non-volatile media removal/physical disconnection + securement confirmation) and block session start until evidence is present and valid | Platform Engineer | Enterprise | 40h | — |
| Implement compensating controls automation when sanitisation/removal/disconnection cannot be completed: locked enclave isolation, disable all interfaces, enforce read-only access for ineligible person, and continuous full logging until completion evidence is received | Operations Lead | Enterprise | 48h | — |
| Logging, alerting, and audit evidence generation: produce audit-ready event schema and retention, integrate with SIEM, generate per-maintenance-event evidence packs (escort concurrence, media protection checklist, compensating control activation/completion, read-only enforcement confirmation) | SOC/SIEM Analyst | Enterprise | 32h | £12,000 |
| End-to-end testing, security validation, and operational readiness: test positive/negative flows, interface denial guarantees, compensating control triggers, evidence completeness, and runbook/training updates for maintenance supervisors and SOC monitoring | Quality Assurance Lead | Enterprise | 40h | — |

**Total Estimated Effort:** 296h  
**Total Estimated Cost:** £30,000

###### Actions Required for Compliance

- [ ] Define and get approval for system-specific maintenance procedures for people who are not authorised to work on the system, including escort or supervision requirements and steps to protect any media used.
- [ ] Create and keep an official escort roster that lists each escort’s security clearance or authorisation status and confirms they have the required technical competence.
- [ ] Set up identity checks so that maintenance staff are classified as ineligible if they are not security cleared or not authorised, or if they are not United States citizens.
- [ ] Set up conditional access and session controls so that maintenance access to system interfaces is blocked unless an approved escort is authorised at the same time for the same work order and system.
- [ ] Set up a pre-session checklist “gate” that requires proof that volatile data has been sanitised, and that non-volatile media has been removed, disconnected, and securely stored.
- [ ] Create compensating-control playbooks that keep the isolated environment locked down, disable its interfaces, allow only read-only access, and keep recording activity continuously until sanitisation is complete.
- [ ] Set up security information and event management (SIEM) logging and keep the records for maintenance sessions, to provide evidence for media protection, and to support the start and completion of compensating controls.


---

#### MA-5.2 — Security Clearances for Classified Systems (Enhancement)

This requirement is about ensuring that only properly checked and authorised people can work on systems that handle classified information, even for routine repairs and diagnostics. Without this, someone who does not have the right clearance or formal authorisation for the sensitivity level involved could accidentally view, change, or expose information during maintenance. This creates a serious risk of unauthorised disclosure or misuse.

To meet this requirement, the organisation must:
- Identify every person who carries out maintenance or diagnostic work on any classified system.
- Check that each person holds the correct security clearance for at least the system’s highest classification level and for every information compartment they could come across during the work.
- Confirm that each person also has matching formal authorisation for those same levels and compartments.

The organisation must then:
- Prevent maintenance from going ahead if either the security clearance or the formal authorisation is missing or not sufficient.
- Keep clear evidence in personnel and access records.
- Ensure maintenance logs record who carried out the work.
- Use documented procedures so these checks are completed before work starts and remain valid.

##### Gate classified maintenance by clearance and compartment authorisation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authoritative clearance & compartment attribute schema (clearance level, compartment list, validity/expiry, exception handling) and data sourcing rules from personnel security records | Data Protection Officer | Enterprise | 24h | — |
| Implement/extend identity integration to expose clearance/compartment attributes to the maintenance gating service (including token/claims mapping and expiry handling) | IAM/PAM engineer | Enterprise | 40h | £25,000 |
| Create system-to-compartment configuration registry (system identifier, highest classification level, maintenance-encounter compartments) with approval workflow for system owners/security approvers | System Design Authority | Enterprise | 32h | — |
| Update ITSM/work-order template and workflow to capture target system, required classification/compartments, and named technician(s); enforce completeness checks at work-order approval | Project Manager | Department | 24h | — |
| Build fail-closed pre-start authorisation check and enforcement point (work-order approval + immediate session start) that denies maintenance when clearance or compartment authorisation is missing/insufficient | Security Engineer | Enterprise | 56h | £40,000 |
| Integrate privileged maintenance access through the gated workflow (PAM/privileged session broker) so sessions are tied to technician, target system, and compartment set | DevOps Lead | Enterprise | 32h | £30,000 |
| Implement audit evidence generation and retention (clearance/compartment snapshot, approval references, maintenance session logs, SIEM export) and validate against audit requirements | Compliance Manager | Enterprise | 32h | £10,000 |
| Conduct end-to-end testing and operational readiness (test cases for expired/changed authorisations, missing compartments, denial/escalation path; runbooks and training for maintenance managers) | Quality Assurance Lead | Department | 24h | — |

Total Estimated Effort: **264h**  
Total Estimated Cost: **£105,000**

###### Actions Required for Compliance

- [ ] Create a system register that links each classified system to (1) its highest classification level and (2) the compartments that are relevant for maintenance.
- [ ] Create an official identity information model for clearance level, permission to access specific compartments, and the dates those permissions are valid, using information from personnel security records.
- [ ] Update the maintenance and diagnostic work-order template so it must include: the target system identifier, the required classification level, the required compartments, and the name(s) of the technician(s).
- [ ] Put in place a “fail-closed” check before maintenance starts. This check must block maintenance sessions if the required clearance or compartment authorisation is missing or not sufficient.
- [ ] Link the process for issuing privileged maintenance access to the approved, gated workflow, so that sessions are created only for verified technicians and for compartment sets that have been approved.
- [ ] Set up audit logging and retention so that records include the technician’s identity, evidence of their clearance or compartment, the target system, the approved access levels or compartments, and the maintenance time window.


---

#### MA-5.3 — Citizenship Requirements for Classified Systems (Enhancement)

This requirement is about making sure only the right people work on sensitive, classified systems. If maintenance or diagnostic work is carried out by someone who is not a United States citizen, there is a real risk that classified information could be seen, handled incorrectly, or exposed during repairs, testing, or troubleshooting.

To meet this expectation, the organisation must clearly set a rule that anyone who performs maintenance or diagnostic activities on systems that process, store, or transmit classified information must be a United States citizen, and it must apply this rule in day-to-day work. This means:
- documenting the rule in maintenance procedures  
- training staff to follow it  
- checking citizenship before anyone is assigned to do the work  

The organisation must also keep reliable records showing the citizenship status of maintenance and diagnostic personnel, and ensure that maintenance access permissions, credentials, and work records can be traced back to those citizenship checks.

##### US-citizen gating for classified-system maintenance access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define citizenship eligibility attribute model (e.g., `US_CITIZEN=true`) including validity dates, source-of-truth mapping, and attribute lifecycle rules (update, expiry, exception handling) | Data Protection Officer | Enterprise | 16h | — |
| Implement eligibility attribute ingestion from authoritative HR/personnel system into identity/privileged access system (including sync jobs, audit trail, and failure handling) | Platform Engineer | Enterprise | 24h | £8,000 |
| Update ITSM/work-order workflow gates for classified-system maintenance: enforce that privileged access/session start cannot be initiated without a recorded citizenship verification reference linked to the work order ID | Operations Lead | Department | 20h | — |
| Configure privileged access enforcement at the identity/PAM/jump-host layer for classified maintenance tooling: allow maintenance/diagnostic privileges only when eligibility attribute is present and valid | Security Engineer | Enterprise | 24h | £12,000 |
| Implement evidence binding and logging: ensure approvals and session start events write work order ID + citizenship verification reference into SIEM/ITSM logs with consistent identifiers | Cyber Security Lead | Enterprise | 20h | £6,000 |
| Add guardrails to prevent bypass: implement policy-as-code/automation checks in access request orchestration so requests lacking eligibility evidence are denied and recorded | DevOps Lead | Enterprise | 16h | £5,000 |
| Test, validate, and produce audit-ready evidence pack (remote + on-platform maintenance paths, negative tests, retention checks, and demonstration of denial without evidence) | Quality Assurance Lead | Enterprise | 24h | — |

|  |  |  | **Total Estimated Effort** | **Total Estimated Cost** |
|---|---|---:|---:|---:|
|  |  |  | **144h** | **£31,000** |

###### Actions Required for Compliance

- [ ] Set up an eligibility check for access to maintenance and diagnostic support that applies to people who are United States citizens, and obtain this information from official human resources (HR) or personnel records, including the dates for which it is valid.
- [ ] Update the information technology service management (ITSM) work-order templates and maintenance checklists for classified systems so they require a mandatory citizenship verification reference before any privileged access or session begins.
- [ ] Set up identity and privileged access controls (for example, privileged access management (PAM), a jump host, or remote support tools) so that maintenance and diagnostic permissions are granted only when the eligibility attribute shows the person is a United States citizen.
- [ ] Link requests for privileged access and the start of each access session to the work order ID and the citizenship verification reference in the logs.
- [ ] Set up automated controls (policy-as-code and workflow enforcement) to stop privileged maintenance access being issued unless the citizenship check has been completed.
- [ ] Validate that audit records can be traced by carrying out test maintenance activities and confirming that the security information and event management (SIEM) and IT service management (ITSM) records link the person who did the work, the work order, and the citizenship verification.


---

#### MA-5.4 — Foreign Nationals (Enhancement)

This requirement ensures that only foreign nationals who have the correct security clearance are allowed to carry out maintenance and diagnostic work on classified systems. It also limits this work to the specific cases where the system is covered by the correct ownership and operating arrangements with allied governments.  

Without these controls, sensitive information could be exposed through unauthorised access, there could be confusion about who is allowed to do which tasks, or work could be carried out on systems that are not covered by the agreed arrangements.  

To meet this expectation, the organisation must confirm that any foreign national carrying out this work has the appropriate security clearance. It must also confirm that the classified system is either:  
- jointly owned and operated by the United States and allied governments, or  
- owned and operated solely by allied governments.  

Before any such work begins, the organisation must have a Memorandum of Agreement in place. This document must clearly record the approvals, consents, and the detailed operating conditions for using foreign nationals for that maintenance and diagnostic activity.

##### MoA-gated access for foreign nationals on classified systems

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define MoA-gated access requirements: MA-5(4) mapping, completeness criteria for MoA metadata (approvals/consents/operating conditions), and decision outcomes (allow/deny) | Compliance Manager | Enterprise | 24h | — |
| Design the authoritative classified system register schema and governance process (system ownership/operation model, permitted maintenance/diagnostic activity types, versioning, change control) | System Design Authority | Enterprise | 32h | — |
| Implement MoA registry data model and ingestion workflow (structured metadata, active/expired status, system+activity linkage, validation rules, audit trail) | Platform Engineer | Enterprise | 56h | £25,000 |
| Integrate identity & clearance attributes into IAM (foreign-national indicator, clearance verification feed, attribute normalisation, and attribute release to the access decision point) | Security Engineer | Enterprise | 48h | £40,000 |
| Develop policy-as-code for access broker/PAM enforcement (MoA existence check, completeness checks, clearance suitability, permitted ownership/operation model checks; deny-by-default) | Software Lead | Enterprise | 72h | — |
| Enforce MoA-gated sessions and auditability (session establishment gating, MoA ID/version binding to session, tamper-evident logging fields, retention alignment) | DevOps Lead | Enterprise | 40h | £10,000 |
| Implement automated audit evidence generation and reporting (SIEM-ready logs, periodic review extracts, evidence pack for foreign-national maintenance/diagnostics) | Operations Lead | Enterprise | 32h | £8,000 |

Total Estimated Effort: **304 Hours**  
Total Estimated Cost: **£83,000**

###### Actions Required for Compliance

- [ ] Create and keep up to date a register of classified systems, including who owns and operates each system, and which types of maintenance and diagnostic activities are allowed.
- [ ] Add information about foreign national status and security clearance to the enterprise identity and access management (IAM) and privileged access management (PAM) decision inputs.
- [ ] Set up a memorandum of agreement (MoA) register with structured information to record approvals, consents, and the detailed operating conditions for each system and each type of activity.
- [ ] Define “model of authority” (MoA) completeness rules and link them to policy-as-code authorisation checks
- [ ] Set up the access broker and privileged access management to block privileged maintenance and diagnostic sessions unless the following checks are successful: clearance is valid, the ownership and operating model matches, and the method-of-approval (MoA) information is complete.
- [ ] Enable audit logging that records, for every authorised session: the identity of the person requesting access, the clearance attribute used, the system registration entry, and the MoA (memorandum of agreement) ID and version.


---

#### MA-5.5 — Non-system Maintenance (Enhancement)

This requirement is about making sure that people who carry out maintenance work nearby, but are not part of the system team, are only allowed into the relevant areas after they have been properly approved. Without this, staff who are not authorised, or who have not been checked properly, could accidentally or deliberately access sensitive equipment or areas. This would increase the risk of disruption, damage, or exposure of information.

To meet this expectation, the organisation must clearly define:
- which roles count as non-escorted maintenance staff (for example, facilities and cleaning teams), and  
- what “near the system” and “non-system maintenance” mean in practice.

Before any work starts, the organisation must check that each person has the correct, up-to-date permission for the specific physical areas they will enter. This must be done through an authorised approval process that includes the required personnel checks and any relevant security requirements.

The organisation must also:
- keep records of permissions and maintenance activity,
- ensure this approach is documented in the system’s security plan, and
- keep related policies and procedures aligned.

##### Authorise non-escorted maintenance via zone/time work orders

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define proximity zone catalogue and maintenance access rules (zone/door/room mapping to protected systems; maintenance categories; definition of “non-system maintenance”) | Security Engineer | Enterprise | 24h | — |
| Update maintenance work-order/ticket template and validation rules to require named personnel, maintenance category, exact zone(s)/door(s)/room(s), and time window; specify blocking/approval routing for missing fields | Operations Lead | Enterprise | 16h | — |
| Create authorisation workflow and approval matrix (Facilities/Operations vs Security Officer sign-off; any personnel security checks; per-zone/per-time scoping rules; exception handling) | Compliance Manager | Enterprise | 20h | — |
| Produce PACS/access-control enforcement procedure (how scoped authorisations are checked at entry; how work-order reference is bound; deny-by-default behaviour when no valid scoped grant exists) | Platform Engineer | Enterprise | 16h | — |
| Implement audit evidence requirements and retention approach (authorisation issuance logs, approvals, work-order references, entry verification events; correlation method for audit) | Data Protection Officer | Enterprise | 12h | — |
| Update system security plan and supporting procedures (MA-5(5) narrative; workflow steps; roles/responsibilities; handling of contractors; periodic review expectations) | Compliance Manager | Enterprise | 14h | — |
| Run pilot and operational readiness checks (test end-to-end for multiple zones/categories; verify denial when details missing; train Maintenance Supervisors and Security Officers; capture lessons learned) | Project Manager | Business Unit | 18h | — |

**Total Estimated Effort:** 120h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define and document the system’s proximity zones or areas, then link each zone or area to the relevant systems and the permitted maintenance categories.
- [ ] Update the facilities and maintenance work-order process so that every non-system maintenance request includes: named personnel, a maintenance category, the exact zone or zones, and the required time window.
- [ ] Set up an authorised approval process (Security Officer and Authorising Official) to approve and issue access permissions for each zone and time period.
- [ ] Set up the public access control system (PACS) to enforce limited permissions and block access when authorisation is missing or outside the allowed scope
- [ ] Set up logging and retention for records of authorisation issuance, approvals, and entry verification events that are linked to work orders.
- [ ] Update the system security plan to describe the process for authorising maintenance when staff are not escorted, and how exceptions are handled.


---

### MA-6 — Timely Maintenance (Control)

This requirement is about making sure that when important equipment or software stops working, you can get the right help or replacement parts quickly. Without this, a server, network or security device, storage system, or essential software licence could stay out of service for too long, leading to major disruption to services, financial loss, and damage to customer trust.

To meet this expectation, the organisation must clearly identify which servers, devices, storage systems, and software licences are mission-critical. For each one, it must be clear what maintenance support and spare parts are needed to restore service. The organisation must also have a documented maintenance policy and procedures, including named people responsible for raising requests, ordering parts, and coordinating any necessary security-related checks.

In addition, the organisation must have supplier contracts and agreed service commitments that support getting the required maintenance help and/or parts within 24 hours of the failure being confirmed. This must be supported by an up-to-date list of spare parts and evidence that these arrangements work in practice.

##### SLA-backed 24-hour maintenance support for mission-critical assets

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Build and maintain the component-to-maintenance entitlement matrix for ma-06_odp.01 assets (including required support type and/or specific spare parts per component) | Service Delivery Manager | Enterprise | 24h | — |
| Define and document the operational “failure declaration” criteria (severity/impact threshold) and ensure the ITSM workflow captures a timestamp as the start of the ma-06_odp.02 window | ITSM Process Owner | Enterprise | 16h | — |
| Review current maintenance contracts/SLAs and negotiate amendments where required so provider obligations explicitly cover acknowledgement/dispatch/arrival proof within ma-06_odp.02 of failure declaration | Compliance Manager | Enterprise | 32h | £15,000 |
| Configure ITSM-integrated automated maintenance request workflow (case creation to vendor via portal/API/email/call script), including required fields and evidence capture for acknowledgement and dispatch/arrival confirmation | DevOps Lead | Enterprise | 40h | £6,000 |
| Implement role-based approvals/escalation controls for triggering vendor escalation and security-relevant handling steps; ensure evidence is retained in ticket history | Security Engineer | Enterprise | 24h | — |
| Instrument reporting and audit evidence pack (timeliness metrics, timestamp integrity checks, retention rules) and run a sample of recent failures or tabletop exercises to validate ≤ ma-06_odp.02 | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 160h  
**Total Estimated Cost:** £21,000

###### Actions Required for Compliance

- [ ] Create a table that links each asset in **ma-06_odp.01** to the maintenance permissions required for it.
- [ ] Update maintenance contracts and service level agreements (SLAs) to explicitly guarantee support and/or spare parts within **ma-06_odp.02** of the failure being declared.
- [ ] Define and document an operational “failure declaration” rule, and make sure the IT service management (ITSM) system records the date and time.
- [ ] Set up an IT service management (ITSM) workflow with the supplier so that maintenance requests automatically fill in the relevant equipment and spare-part details, and so that the supplier’s confirmation and dispatch evidence are recorded.
- [ ] Set up role-based access control (RBAC) so only authorised roles can request vendor escalation and carry out security-relevant handling steps.
- [ ] Create an audit report that measures how long it takes for items to be acknowledged or dispatched against **ma-06_odp.02**, and keep the supporting evidence so it can be reviewed.


---

#### MA-6.1 — Preventive Maintenance (Enhancement)

This requirement is about keeping important equipment working properly through planned, regular servicing and checks. This helps identify problems early, before they cause disruption. If preventive maintenance is not carried out at least once every quarter on network devices, servers, storage systems, and critical security equipment, worn parts or developing faults could fail unexpectedly. This could result in downtime, loss of service, and a higher risk of security weaknesses being exploited.

To meet this expectation, the organisation must:
- clearly define which equipment is covered
- set a maintenance schedule for every quarter
- have clear written rules and step-by-step instructions for how maintenance is carried out, including inspection, testing, adjustments, replacing parts, and fixing developing issues

If external engineers are used, the organisation must have contracts and service expectations that require quarterly maintenance.

The organisation must also:
- keep an up-to-date list of the specific components that need maintenance
- assign named responsibilities to the right staff
- ensure the organisation’s security planning takes maintenance activities into account
- keep maintenance records showing what was done and when

##### Quarterly preventive maintenance via CMMS with audit-ready evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm MA-6(1) preventive maintenance scope: define in-scope system components (ma-06.01_odp.01), quarterly interval parameter (ma-06.01_odp.02), and evidence requirements (minimum fields and acceptable attachments) | Compliance Manager | Enterprise | 16h | — |
| CMMS asset inventory authoring: create/validate CMMS asset records with unique identifiers and equipment-class mapping for all in-scope assets; define asset-to-work-order linkage rules | Infrastructure Lead | Enterprise | 24h | — |
| Configure CMMS recurring preventive maintenance: implement quarterly work order generation for each in-scope asset; ensure interval matches ma-06.01_odp.02 and that environments (prod/test/DR) are correctly represented | DevOps Lead | Enterprise | 20h | — |
| Develop controlled, versioned maintenance procedures/checklists per equipment class: include inspection, tests, measurements, adjustments, parts replacement, and incipient failure correction; link checklist items to controlled documents | System Design Authority | Enterprise | 32h | — |
| Implement structured evidence capture in CMMS: enforce mandatory fields (date/time, asset ID, performed tasks, test/measurement results, adjustments, parts/serials where applicable, outcomes, sign-off) and configure attachment requirements | Security Engineer | Enterprise | 28h | — |
| Configure workflow approvals and security relevance: implement role-based sign-off for operational owner; add Information Security acknowledgement/review steps for security appliances/security-impacting findings | Cyber Security Lead | Enterprise | 20h | — |
| External maintenance integration (if applicable): create CMMS provider work order templates, evidence attachment requirements, and mapping of provider reports to the quarterly schedule/SLA | Service Delivery Manager | Enterprise | 16h | — |
| Compliance monitoring & audit reporting: implement automated overdue/missing-evidence checks and generate an auditable quarterly maintenance compliance report (coverage, last completed date, evidence completeness) | Operations Lead | Enterprise | 24h | £6,000 |
| **Total Estimated Effort** |  |  | **180h** |  |
| **Total Estimated Cost** |  |  |  | **£6,000** |

###### Actions Required for Compliance

- [ ] Maintain an up-to-date, official asset list in the computerised maintenance management system (CMMS) for the defined system components (network devices, servers, storage systems, and critical security appliances).
- [ ] Set up the computerised maintenance management system (CMMS) to automatically create recurring preventive maintenance work orders every quarter for every asset that is included in scope.
- [ ] Create controlled, versioned preventive maintenance checklists for each equipment type. Each checklist should cover inspection, tests, measurements, adjustments, replacement of parts, and correction of early signs of failure.
- [ ] Require structured evidence to be recorded in the computerised maintenance management system (CMMS) for every work order, including results, any changes made, parts that were replaced, the final outcome, and sign-off.
- [ ] Set up role-based approval steps for closing maintenance work, including a requirement to acknowledge information security for any security-relevant findings.
- [ ] If you use an external maintenance provider, make sure their work orders are recorded in the computerised maintenance management system (CMMS), and require quarterly uploads of supporting evidence that match the contract and service level agreement (SLA) requirements.
- [ ] Run automated compliance checks and produce an audit-ready report showing, for the most recent cycle, whether quarterly maintenance was completed and whether the supporting evidence is complete.


---

#### MA-6.2 — Predictive Maintenance (Enhancement)

This requirement is about keeping your most important equipment under close watch. The goal is to spot early warning signs and arrange repairs before the equipment starts to fail. Without predictive maintenance for critical on-premises servers, storage systems, network switches and routers, and industrial control equipment, problems can develop quietly. This can lead to unexpected downtime, reduced performance, expensive emergency repairs, and disruption to business operations.

To meet this expectation, the organisation must:
- Keep an up-to-date list of the specific critical assets covered.
- Continuously monitor the condition of these assets.
- Carry out scheduled inspections at least once every quarter.
- Analyse the monitoring results to predict how each asset’s condition is likely to change.
- Set clear limits for when performance is considered unacceptable.
- Schedule maintenance at the most cost-effective time, ensuring it is completed before performance falls below those limits.

The organisation should also:
- Document the approach.
- Assign named responsibilities.
- Keep maintenance records showing what was checked and what decisions were made.
- Ensure any work carried out by external suppliers is covered by contracts, including evidence that the required monitoring and quarterly inspections are delivered.

##### Predictive maintenance telemetry-to-CMMS workflow for critical assets

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm MA-6(2) monitored scope: map {{param ma-06.02_odp.01}} to authoritative CMDB/asset register, including asset class, identifiers, and ownership | Compliance Manager | Enterprise | 16h | — |
| Define predictive maintenance model inputs and quarterly inspection cadence: specify required telemetry/health metrics per asset class and set inspection frequency to meet {{param ma-06.02_odp.02}} | System Design Authority | Enterprise | 24h | — |
| Implement secure telemetry ingestion pipeline: asset-scoped, time-stamped collection with encrypted transport, normalisation, and data quality checks | Platform Engineer | Enterprise | 56h | £18,000 |
| Develop analytics/trend forecasting with SPC-style drift detection: produce risk score, predicted time-to-threshold, and “maintenance due” window | Software Lead | Enterprise | 72h | £25,000 |
| Configure CMMS/EAM orchestration for quarterly work orders: auto-create work orders per in-scope asset, pre-populate metrics/rationale, and enforce “maintenance performed” vs “no action” auditable outcome | Operations Lead | Enterprise | 48h | £12,000 |
| Implement decisioning and scheduling controls: ensure maintenance is scheduled within change/maintenance windows and occurs before predicted unacceptable threshold breach | DevOps Lead | Enterprise | 24h | — |
| Evidence & audit trail automation: retain traceable linkage between telemetry → analytics outputs → inspection cycle → CMMS outcomes; produce audit-ready reports | Data Protection Officer | Enterprise | 32h | — |
| Pilot, validate acceptance criteria, and operationalise: run end-to-end test for at least one quarterly cycle simulation, tune thresholds, and hand over runbooks/monitoring dashboards | Service Delivery Manager | Enterprise | 40h | £6,000 |

**Total Estimated Effort:** 312h  
**Total Estimated Cost:** £61,000

###### Actions Required for Compliance

- [ ] Match the authoritative asset register and configuration management database (CMDB) to the in-scope **system components**, and tag each asset for MA-6(2) predictive maintenance.
- [ ] Set up continuous monitoring of health and performance information for each type of asset (information technology (IT) and operational technology/industrial control systems (OT/ICS)), using methods that do not disrupt operations where needed.
- [ ] Use predictive analytics (statistical process control and trend forecasting) and set clear, measurable condition and performance limits for each asset class.
- [ ] Link the analytics results to the computerised maintenance management system (CMMS) / enterprise asset management (EAM) so that quarterly work orders are automatically created in line with **{{param ma-06.02_odp.02}}**.
- [ ] Use a workflow that produces an audit trail for inspection results. Each inspection must either include a reference to the maintenance work carried out, or include documented reasons for “no action” that are linked to the predicted thresholds.
- [ ] Set up maintenance scheduling to happen before the system is expected to reach its threshold limit, and only within the approved maintenance and change windows.


---

#### MA-6.3 — Automated Support for Predictive Maintenance (Enhancement)

This requirement is about making sure your equipment’s health information automatically reaches your maintenance system. That way, repairs and inspections can be planned and tracked without delay. If this connection is missing or unreliable, warning signs may be missed, maintenance may be carried out too late or unnecessarily, and it becomes harder to show what was done and when—creating real operational and cost risks.

The organisation must set up an automated, secure connection that sends predictive maintenance data from the equipment condition monitoring platform to the maintenance management system using protected, code-based data feeds. It must also ensure the maintenance system receives and uses this information to support planning, carrying out work, and reporting.

The organisation must keep clear records showing that the data transfer is running, that the connection is protected and authorised, and that staff can monitor failures and confirm recovery. It must also document responsibilities, maintenance procedures, service arrangements, and upkeep records for the platforms and the automated transfer mechanism.

##### Secure automated API feed for predictive maintenance data transfer

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define API interface contract: predictive maintenance payload schema, field mapping rules, required/optional fields, validation rules, and versioning approach | System Design Authority | Enterprise | 24h | — |
| Build integration service (event-driven or polling) with incremental cursor support, transformation layer, and continuous automated processing pipeline | Platform Engineer | Enterprise | 80h | — |
| Implement secure API feed: TLS 1.2+ enforcement, certificate validation, OAuth2 client credentials (or mTLS/signed JWT as agreed), and secrets retrieval from approved secrets manager | Security Engineer | Enterprise | 56h | — |
| Add reliability & idempotency controls: retry with exponential backoff, idempotency keys, schema validation, dead-letter queue/handling for malformed events, and replay strategy | Platform Engineer | Enterprise | 48h | — |
| Configure maintenance management system ingestion: create/adjust endpoints or connectors, persist incoming predictive maintenance data, map to maintenance objects, and enable downstream planning/execution/reporting workflows | Software Lead | Business Unit | 40h | — |
| Implement auditable evidence: end-to-end correlation IDs, structured logs/metrics for each transfer attempt, and forwarding/retention alignment with enterprise logging/SIEM | Operations Lead | Enterprise | 32h | — |
| Test, security validation, and go-live readiness: integration tests (happy path + failure modes), security testing (auth/TLS), performance/latency checks, and production deployment with change management evidence | Quality Assurance Lead | Enterprise | 40h | £3,000 |

**Total Estimated Effort:** 320h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Document the predictive maintenance event data format (schema) and how each field maps to the maintenance management system objects.
- [ ] Set up an automated integration service that connects systems using event-based webhooks or scheduled polling, using incremental cursors to track progress.
- [ ] Set up API security using Transport Layer Security (TLS) version 1.2 or higher and strong authentication (OAuth 2.0 client credentials, mutual Transport Layer Security (mTLS), or signed JSON Web Tokens (JWTs)), using credentials stored in the approved vault.
- [ ] Add unique idempotency keys so requests can be safely repeated, retry failed requests using exponential backoff (increasing wait times), validate the data against the required schema, and send payloads that still fail to a dead-letter queue for later review.
- [ ] Set up the maintenance management system to receive, store, and keep the data, and to start the next planning, execution, and reporting steps.
- [ ] Set up end-to-end logging using correlation identifiers, and send the transfer logs and performance metrics to the enterprise security information and event management (SIEM) system, keeping data for the period required by policy.


---

### MA-7 — Field Maintenance (Control)

This requirement is about protecting the most important equipment from casual on-site repairs. Only places that have been properly checked should be allowed to work on it. If critical systems are serviced at customer sites or other local locations, the checks may be less strict, the records may be incomplete, and unauthorised access during diagnosis or repairs could go unnoticed. This increases the risk of disruption or misuse.

To meet this expectation, the organisation must first write down exactly which systems and components it considers critical. For each one, it must then decide whether on-site (field) maintenance is restricted or completely prohibited. The organisation must also document clear procedures for how field maintenance is handled, and make sure that any permitted work is carried out only at certified depot or contractor facilities with approved security measures, using an up-to-date list of approved facilities.

For any diagnostic work carried out during maintenance, the organisation must require strong identity checks. It must also ensure that the maintenance session and any related connections are ended when the work is finished. The organisation must keep maintenance and diagnostic records, along with the supporting documentation.

##### Enforce critical-field maintenance via work-order gate

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define critical-system/component coverage model in authoritative CMDB/asset register (critical tag + maintenance rule: prohibited/restricted) and publish mapping to work-order validation logic | System Design Authority | Enterprise | 24h | — |
| Design and implement trusted maintenance facility registry data model (facility identifier, address, approval status, security-control evidence reference, recertification/expiry, audit metadata) and integrate with workflow lookup | Infrastructure Lead | Enterprise | 32h | — |
| Configure ITSM/work-order workflow: add mandatory “maintenance location” and “approved facility” fields; implement rule-based gating for critical items (block/reject scheduling as per prohibited/restricted) | Operations Lead | Enterprise | 40h | — |
| Implement exception handling controls (optional): exception record schema, required security approval workflow, risk acceptance linkage, and enforcement to prevent unapproved exceptions | Compliance Manager | Enterprise | 24h | — |
| Enforce strong identity for maintenance diagnostics sessions: integrate phishing-resistant MFA requirement, time-bound authorisation, and session/remote-access revocation hooks on work-order close | Security Engineer | Enterprise | 48h | £6,000 |
| Implement automated audit evidence capture in work-order system (critical item ID, maintenance location, facility reference, authorising roles, diagnostic start/end timestamps, remote-access termination confirmation) and ensure audit log retention | DevOps Lead | Enterprise | 32h | — |
| Build and execute end-to-end test plan (workflow gating, facility registry validation, exception paths, MFA/session termination, audit evidence completeness) and remediate defects prior to rollout | Quality Assurance Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 260h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Record all critical systems and components in the configuration management database (CMDB) / asset register, and assign a maintenance rule for each item (either prohibited or restricted).
- [ ] Create and keep an approved register of trusted maintenance facilities, including evidence that security controls are in place and the dates when each facility must be rechecked (recertified).
- [ ] Update the IT service management (ITSM) work-order process so that, for all critical items, the maintenance location and an approved facility are selected and recorded.
- [ ] Set up workflow controls to block or reject field or on-site maintenance requests that do not meet the MA-7 requirement.
- [ ] Set up maintenance diagnostics and remote access so that it requires phishing-resistant multi-factor authentication (MFA) and time-limited authorisation.
- [ ] Automate the end of sessions and network tunnels, and revoke privileged access when the work order is closed.
- [ ] Ensure work orders record audit evidence, including: the critical item, its location, the approved facility, the person who authorised the work, the start and end times of the diagnostic/session, and confirmation that the work was terminated.

